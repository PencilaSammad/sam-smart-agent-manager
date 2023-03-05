using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sam
{
    public partial class SamSettings : Form
    {
        // This function initializes the component of the SamSettings form.
        public SamSettings()
        {
            InitializeComponent();
        }

        // This function handles the save button click event and saves the user's entered API key and agent personality to the application settings.
        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            SamUserSettings.Default.GPT_API_KEY = txtApiKey.Text;
            SamUserSettings.Default.DefaultAgentPersonality = txtAgentPersonality.Text;
            SamUserSettings.Default.Save();
        }

        // This function loads the saved settings from the user's last session and populates the API key and agent personality textboxes.
        private void SamSettings_Load(object sender, EventArgs e)
        {
            txtApiKey.Text = SamUserSettings.Default.GPT_API_KEY;
            txtAgentPersonality.Text = SamUserSettings.Default.DefaultAgentPersonality;
        }

        // This function handles the reset button click event and clears the saved API key and agent personality settings, as well as the corresponding textboxes.
        private void btnReset_Click(object sender, EventArgs e)
        {
            SamUserSettings.Default.GPT_API_KEY = "";
            SamUserSettings.Default.DefaultAgentPersonality = "";
            SamUserSettings.Default.Save();
            txtApiKey.Text = "";
            txtAgentPersonality.Text = "";
        }
    }
}
