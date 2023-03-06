using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace sam
{
    public partial class SmartAgent : DockContent
    {
        public AgentSettings? currentAgentSettings { get; private set; }

        public SmartAgent(AgentSettings? selectedAgentSettings = null)
        {
            InitializeComponent();

            if (selectedAgentSettings != null)
            {
                txtAgentPersonality.Text = selectedAgentSettings.AgentPersonality;
                txtAgentName.Text = selectedAgentSettings.AgentName;
                txtAgentID.Text = selectedAgentSettings.AgentID;
            }
            else
            {
                txtAgentPersonality.Text = SamUserSettings.Default.DefaultAgentPersonality;
                txtAgentName.Text = GenerateRandomAgentName();
                txtAgentID.Text = Guid.NewGuid().ToString();

                // Create a new agent settings object
                AgentSettings agentSettings = new AgentSettings
                {
                    AgentName = txtAgentName.Text,
                    AgentID = txtAgentID.Text,
                    AgentPersonality = txtAgentPersonality.Text,
                    SlaveAgents = new List<AgentSettings> { }
                };
                selectedAgentSettings = agentSettings;
            }
            this.currentAgentSettings = selectedAgentSettings;
            LoadSlaveAgents();
        }

        private void LoadSlaveAgents()
        {
            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();

            var slaveAgents = agentSettingsManager.LoadAgentSettings();
            var agentSetting = agentSettingsManager.LoadAgentSetting(currentAgentSettings.AgentName);
            if (slaveAgents != null)
            {
                foreach (var slaveAgent in slaveAgents)
                {

                    checkedListSelectedSlaves.Items.Add(slaveAgent.AgentName);
                }
                if (agentSetting.SlaveAgents != null)
                {
                    foreach (var agentSlave in agentSetting.SlaveAgents)
                    {
                        foreach (string chkItem in checkedListSelectedSlaves.Items)
                        {
                            if (agentSlave.AgentName == chkItem)
                            {
                                checkedListSelectedSlaves.SetItemChecked(checkedListSelectedSlaves.Items.IndexOf(chkItem), true);
                            }
                        }
                    }
                }
            }

        }

        private void SmartAgent_Load(object sender, EventArgs e)
        {

        }

        private string GenerateRandomAgentName()
        {
            // Create an array of ten possible agent name options
            string[] agentNames = new string[] { "Alex", "Avery", "Brooke", "Cameron", "Dakota", "Jordan", "Morgan", "Riley", "Taylor", "Logan", "Evelyn", "Madison", "Peyton", "Sydney", "Bailey", "Reagan", "Charlie", "Hayden", "Harper", "Parker", "Ariel" };

            // Generate a random number between 0 and 9 to select a random agent name from the array
            int index = new Random().Next(0, 10);

            // Return the selected agent name
            return agentNames[index];
        }

        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            SaveAgentSettings();
        }

        private void SaveAgentSettings()
        {

            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();

            // Create a new agent settings object
            AgentSettings agentSettings = new AgentSettings
            {
                AgentName = txtAgentName.Text,
                AgentID = txtAgentID.Text,
                AgentPersonality = txtAgentPersonality.Text
            };

            List<AgentSettings> slaveAgents = new List<AgentSettings>();
            foreach (string slave in checkedListSelectedSlaves.CheckedItems)
            {
                slaveAgents.Add(agentSettingsManager.LoadAgentSetting(slave));
            }
            agentSettings.SlaveAgents = slaveAgents;
            agentSettingsManager.SaveAgentSettings(agentSettings);

            MessageBox.Show("Agent settings saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
