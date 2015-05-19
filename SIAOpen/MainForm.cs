using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SIAOpen
{
    public partial class MainForm : Form
    {
        public String serverLocation { get; set; }
        public String localFilePath { get; set; }
        public int listeningPort { get; set; }
        


        public MainForm()
        {
            InitializeComponent();
            GoFullscreen(true);
            this.serverLocation = "75.108.123.53";
            this.listeningPort = 3000;
            this.localFilePath = "C:\\Spirit Ice Arena\\formData.csv";
            this.submissionForm = new submissionForm();
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.localFilePath))
            {

                File.AppendAllText(this.localFilePath, "Name, E-mail\n");
            }
            if (this.nameTextBox.Text != "" && this.emailTextBox.Text != "")
            {
                String name = this.nameTextBox.Text;
                String email = this.emailTextBox.Text;
                String finalString = name + ',' + email + '\n';
                File.AppendAllText(this.localFilePath, finalString);
                sendHTTPRequest(name, email);
                this.nameTextBox.Text = "";
                this.emailTextBox.Text = "";
                showSubmissionForm();
                
            }
            
        }

        public void sendHTTPRequest(string name, string email)
        {
            try
            {
                string reponseData = string.Empty;
                string url = "http://" + this.serverLocation + ":" + this.listeningPort;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        name = name,
                        email = email
                    });

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception x)
            {
                //throw x;
            }
            
        }

        private async void showSubmissionForm()
        {
            submissionForm = new submissionForm();
            submissionForm.Show();
            await Task.Delay(4000);
            submissionForm.Close();

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm = new Settings(this);
            settingsForm.Show();
        }


        public Settings settingsForm { get; set; }
        public submissionForm submissionForm { get; set; }
        
    }
}
