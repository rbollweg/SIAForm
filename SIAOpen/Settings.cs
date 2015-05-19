using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAOpen
{
    public partial class Settings : Form
    {

        private MainForm mainForm;

        public Settings(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.serverLocationTextArea.Text = mainForm.serverLocation;
            this.localPathTextArea.Text = mainForm.localFilePath;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.mainForm.serverLocation = this.serverLocationTextArea.Text;
            this.mainForm.localFilePath = this.localPathTextArea.Text;
            this.Close();
        }
    }
}
