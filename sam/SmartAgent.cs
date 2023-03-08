using FastColoredTextBoxNS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace sam
{
    public partial class SmartAgent : DockContent
    {
        public AgentSettings? currentAgentSettings { get; private set; }
        internal Conversation conversation { get; private set; }
        public SAM parentSAM { get; }


        public SmartAgent(AgentSettings? selectedAgentSettings = null, SAM sAM = null)
        {
            InitializeComponent();
            parentSAM = sAM;
            if (selectedAgentSettings != null)
            {
                txtAgentPersonality.Text = selectedAgentSettings.AgentPersonality;
                txtAgentName.Text = selectedAgentSettings.AgentName;
                txtAgentID.Text = selectedAgentSettings.AgentID;
                txtSlaveMessage.Text = selectedAgentSettings.SlaveAgentMessage;
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
                    SlaveAgents = new List<AgentSettings> { },
                    SlaveAgentMessage = txtSlaveMessage.Text

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
                    var itemsToCheck = new List<object>(); // create a new list to hold the items that need to be checked
                    foreach (var agentSlave in agentSetting.SlaveAgents)
                    {
                        foreach (var availableSlaves in checkedListSelectedSlaves.Items)
                        {
                            if (agentSlave.AgentName == availableSlaves.ToString())
                            {
                                itemsToCheck.Add(availableSlaves); // add the item to the list of items to check
                            }
                        }
                    }
                    foreach (var item in itemsToCheck)
                    {
                        checkedListSelectedSlaves.SetItemChecked(checkedListSelectedSlaves.Items.IndexOf(item), true); // check the items outside of the loop
                    }
                }
            }

        }

        private void SmartAgent_Load(object sender, EventArgs e)
        {

        }

        private string GenerateRandomAgentName()
        {
            // Create an array of twenty possible agent name options
            string[] agentNames = new string[] { "Alex", "Avery", "Brooke", "Cameron", "Dakota", "Jordan", "Morgan", "Riley", "Taylor", "Logan", "Evelyn", "Madison", "Peyton", "Sydney", "Bailey", "Reagan", "Charlie", "Hayden", "Harper", "Parker", "Ariel", "Phoenix", "Rowan", "Sage", "Aspen", "Emerson", "Dallas", "Skyler", "Casey", "Kendall", "Cassidy" };

            // Generate a random number between 0 and 19 to select a random agent name from the array
            int index = new Random().Next(0, 20);

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
                AgentPersonality = txtAgentPersonality.Text,
                SlaveAgentMessage = txtSlaveMessage.Text
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendUserConversationMessageAsync();

        }

        private void AppendTextToChat(string text, Color color)
        {
            // Set the color of the text that will be appended
            txtChat.SelectionColor = color;

            // Append the text to the control
            txtChat.AppendText(text);
            txtCode.AppendText(text);

            // Add a new line
            txtChat.AppendText(Environment.NewLine);
            txtChat.AppendText(Environment.NewLine);

            // Add a new line
            txtCode.AppendText(Environment.NewLine);
            txtCode.AppendText(Environment.NewLine);
        }

        private async Task SendUserConversationMessageAsync()
        {
            if (conversation == null)
            {
                List<string> systemPersonality = new List<string> { };

                systemPersonality.Add(txtAgentPersonality.Text);

                conversation = new Conversation(SamUserSettings.Default.GPT_API_KEY, systemPersonality);

                if (txtUserInput.Text != "")
                {
                    string userInput = txtUserInput.Text;

                    // Append the user's input to the chat with green text
                    AppendTextToChat(userInput, Color.Green);

                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.StartConversation(userInput);
                    foreach (string s in response)
                    {
                        AppendTextToChat(s, Color.Blue);
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        SendSmartAgentResponseToSlaves(response);
                    }

                    // Clear the user input field
                    txtUserInput.Text = "";
                };

            }
            else
            {
                if (txtUserInput.Text != "")
                {
                    string userInput = txtUserInput.Text;

                    // Append the user's input to the chat with green text
                    AppendTextToChat(userInput, Color.Green);

                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.StartConversation(userInput);
                    foreach (string s in response)
                    {
                        AppendTextToChat(s, Color.Blue);
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        SendSmartAgentResponseToSlaves(response);
                    }
                    // Clear the user input field
                    txtUserInput.Text = "";
                };
            }
        }

        private void SendSmartAgentResponseToSlaves(List<string> response)
        {
            AgentSettingsManager agentSettingsManager = new AgentSettingsManager();
            List<AgentSettings> slaveAgents = new List<AgentSettings>();
            foreach (string slave in checkedListSelectedSlaves.CheckedItems)
            {
                slaveAgents.Add(agentSettingsManager.LoadAgentSetting(slave));
            }
            foreach (SmartAgent slave in parentSAM.activeSmartAgents)
            {
                foreach (AgentSettings agentSettings in slaveAgents)
                {
                    if (slave.currentAgentSettings.AgentName == agentSettings.AgentName)
                    {
                        slave.SendSlaveMessageAsync(txtSlaveMessage.Text + String.Join(" ", response));
                    }
                }
            }


        }

        private async Task SendSlaveMessageAsync(string slaveMessage)
        {
            if (chkSmartAgentEnabled.Checked)
            {
                txtUserInput.Text = slaveMessage;
                await SendUserConversationMessageAsync();
            }
        }

        private void SmartAgent_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentSAM.activeSmartAgents.Remove(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            conversation = null;
            txtChat.Text = "";
            txtCode.SelectAll();
            txtCode.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only allow WAV files
            openFileDialog.Filter = "WAV files (*.wav)|*.wav";

            // Set the initial directory to the recordings directory
            openFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "rec");

            // Show the file dialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path and do something with it
                string selectedFilePath = openFileDialog.FileName;
                
                AnalyzeAudioAsync(selectedFilePath);
            }
            
        }

        private async Task AnalyzeAudioAsync(string selectedFilePath)
        {
            if (conversation == null)
            {
                List<string> systemPersonality = new List<string> { };

                systemPersonality.Add(txtAgentPersonality.Text);

                conversation = new Conversation(SamUserSettings.Default.GPT_API_KEY, systemPersonality);

                if (selectedFilePath != "")
                {
                   
                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.AnalyzeAudio(selectedFilePath);
                    foreach (string s in response)
                    {
                        AppendTextToChat(s, Color.Blue);
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        SendSmartAgentResponseToSlaves(response);
                    }

                    
                };

            }
            else
            {
                if (selectedFilePath != "")
                {
                   
                    // Start the conversation and append the system's response with blue text
                    List<string> response = await conversation.AnalyzeAudio(selectedFilePath);
                    foreach (string s in response)
                    {
                        AppendTextToChat(s, Color.Blue);
                    }

                    if (chkSmartAgentEnabled.Checked)
                    {
                        SendSmartAgentResponseToSlaves(response);
                    }
                   
                };
            }
        }
    }
}
