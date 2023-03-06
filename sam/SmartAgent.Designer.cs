namespace sam
{
    partial class SmartAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartAgent));
            agentContainer = new SplitContainer();
            agentSettingsGrp = new GroupBox();
            settingsPanel = new Panel();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            checkedListSelectedSlaves = new CheckedListBox();
            groupBox2 = new GroupBox();
            txtSlaveMessage = new TextBox();
            grpAgentControl = new GroupBox();
            chkSmartAgentEnabled = new CheckBox();
            btnSaveAgent = new Button();
            btnReset = new Button();
            grpPersonality = new GroupBox();
            txtAgentPersonality = new TextBox();
            grpAgentID = new GroupBox();
            txtAgentID = new TextBox();
            grpName = new GroupBox();
            txtAgentName = new TextBox();
            grpUserInput = new GroupBox();
            pnlInput = new Panel();
            btnSend = new Button();
            txtUserInput = new TextBox();
            agentConversation = new GroupBox();
            conversationContentPanel = new Panel();
            txtChat = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)agentContainer).BeginInit();
            agentContainer.Panel1.SuspendLayout();
            agentContainer.Panel2.SuspendLayout();
            agentContainer.SuspendLayout();
            agentSettingsGrp.SuspendLayout();
            settingsPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            grpAgentControl.SuspendLayout();
            grpPersonality.SuspendLayout();
            grpAgentID.SuspendLayout();
            grpName.SuspendLayout();
            grpUserInput.SuspendLayout();
            pnlInput.SuspendLayout();
            agentConversation.SuspendLayout();
            conversationContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // agentContainer
            // 
            agentContainer.Dock = DockStyle.Fill;
            agentContainer.Location = new Point(0, 0);
            agentContainer.Name = "agentContainer";
            // 
            // agentContainer.Panel1
            // 
            agentContainer.Panel1.Controls.Add(agentSettingsGrp);
            // 
            // agentContainer.Panel2
            // 
            agentContainer.Panel2.Controls.Add(grpUserInput);
            agentContainer.Panel2.Controls.Add(agentConversation);
            agentContainer.Size = new Size(1036, 653);
            agentContainer.SplitterDistance = 361;
            agentContainer.TabIndex = 0;
            // 
            // agentSettingsGrp
            // 
            agentSettingsGrp.Controls.Add(settingsPanel);
            agentSettingsGrp.Dock = DockStyle.Fill;
            agentSettingsGrp.Location = new Point(0, 0);
            agentSettingsGrp.Name = "agentSettingsGrp";
            agentSettingsGrp.Size = new Size(361, 653);
            agentSettingsGrp.TabIndex = 0;
            agentSettingsGrp.TabStop = false;
            agentSettingsGrp.Text = "Agent settings";
            // 
            // settingsPanel
            // 
            settingsPanel.AutoScroll = true;
            settingsPanel.Controls.Add(groupBox1);
            settingsPanel.Controls.Add(grpAgentControl);
            settingsPanel.Controls.Add(grpPersonality);
            settingsPanel.Controls.Add(grpAgentID);
            settingsPanel.Controls.Add(grpName);
            settingsPanel.Dock = DockStyle.Fill;
            settingsPanel.Location = new Point(3, 19);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(355, 631);
            settingsPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(6, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 266);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Slave agent settings";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(checkedListSelectedSlaves);
            groupBox3.Location = new Point(9, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(325, 143);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Slave agent names";
            // 
            // checkedListSelectedSlaves
            // 
            checkedListSelectedSlaves.Dock = DockStyle.Fill;
            checkedListSelectedSlaves.FormattingEnabled = true;
            checkedListSelectedSlaves.Location = new Point(3, 19);
            checkedListSelectedSlaves.Name = "checkedListSelectedSlaves";
            checkedListSelectedSlaves.Size = new Size(319, 121);
            checkedListSelectedSlaves.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtSlaveMessage);
            groupBox2.Location = new Point(6, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 85);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Message to slave agent";
            // 
            // txtSlaveMessage
            // 
            txtSlaveMessage.Dock = DockStyle.Fill;
            txtSlaveMessage.Location = new Point(3, 19);
            txtSlaveMessage.Multiline = true;
            txtSlaveMessage.Name = "txtSlaveMessage";
            txtSlaveMessage.Size = new Size(325, 63);
            txtSlaveMessage.TabIndex = 1;
            // 
            // grpAgentControl
            // 
            grpAgentControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAgentControl.Controls.Add(chkSmartAgentEnabled);
            grpAgentControl.Controls.Add(btnSaveAgent);
            grpAgentControl.Controls.Add(btnReset);
            grpAgentControl.Location = new Point(6, 555);
            grpAgentControl.Name = "grpAgentControl";
            grpAgentControl.Size = new Size(343, 73);
            grpAgentControl.TabIndex = 5;
            grpAgentControl.TabStop = false;
            grpAgentControl.Text = "Agent control";
            // 
            // chkSmartAgentEnabled
            // 
            chkSmartAgentEnabled.AutoSize = true;
            chkSmartAgentEnabled.Location = new Point(172, 35);
            chkSmartAgentEnabled.Name = "chkSmartAgentEnabled";
            chkSmartAgentEnabled.Size = new Size(135, 19);
            chkSmartAgentEnabled.TabIndex = 7;
            chkSmartAgentEnabled.Text = "Smart agent enabled";
            chkSmartAgentEnabled.UseVisualStyleBackColor = true;
            // 
            // btnSaveAgent
            // 
            btnSaveAgent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAgent.Location = new Point(6, 20);
            btnSaveAgent.Name = "btnSaveAgent";
            btnSaveAgent.Size = new Size(78, 47);
            btnSaveAgent.TabIndex = 3;
            btnSaveAgent.Text = "Save";
            btnSaveAgent.UseVisualStyleBackColor = true;
            btnSaveAgent.Click += btnSaveAgent_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(88, 20);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 47);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // grpPersonality
            // 
            grpPersonality.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonality.Controls.Add(txtAgentPersonality);
            grpPersonality.Location = new Point(6, 117);
            grpPersonality.Name = "grpPersonality";
            grpPersonality.Size = new Size(343, 160);
            grpPersonality.TabIndex = 2;
            grpPersonality.TabStop = false;
            grpPersonality.Text = "Agent personality";
            // 
            // txtAgentPersonality
            // 
            txtAgentPersonality.Dock = DockStyle.Fill;
            txtAgentPersonality.Location = new Point(3, 19);
            txtAgentPersonality.Multiline = true;
            txtAgentPersonality.Name = "txtAgentPersonality";
            txtAgentPersonality.Size = new Size(337, 138);
            txtAgentPersonality.TabIndex = 1;
            // 
            // grpAgentID
            // 
            grpAgentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAgentID.Controls.Add(txtAgentID);
            grpAgentID.Location = new Point(6, 60);
            grpAgentID.Name = "grpAgentID";
            grpAgentID.Size = new Size(343, 51);
            grpAgentID.TabIndex = 1;
            grpAgentID.TabStop = false;
            grpAgentID.Text = "Agent id";
            // 
            // txtAgentID
            // 
            txtAgentID.Dock = DockStyle.Fill;
            txtAgentID.Location = new Point(3, 19);
            txtAgentID.Name = "txtAgentID";
            txtAgentID.Size = new Size(337, 23);
            txtAgentID.TabIndex = 1;
            // 
            // grpName
            // 
            grpName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpName.Controls.Add(txtAgentName);
            grpName.Location = new Point(9, 3);
            grpName.Name = "grpName";
            grpName.Size = new Size(343, 51);
            grpName.TabIndex = 0;
            grpName.TabStop = false;
            grpName.Text = "Agent name";
            // 
            // txtAgentName
            // 
            txtAgentName.Dock = DockStyle.Fill;
            txtAgentName.Location = new Point(3, 19);
            txtAgentName.Name = "txtAgentName";
            txtAgentName.Size = new Size(337, 23);
            txtAgentName.TabIndex = 1;
            // 
            // grpUserInput
            // 
            grpUserInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpUserInput.Controls.Add(pnlInput);
            grpUserInput.Location = new Point(3, 539);
            grpUserInput.Name = "grpUserInput";
            grpUserInput.Size = new Size(668, 111);
            grpUserInput.TabIndex = 1;
            grpUserInput.TabStop = false;
            grpUserInput.Text = "User input";
            // 
            // pnlInput
            // 
            pnlInput.AutoScroll = true;
            pnlInput.Controls.Add(btnSend);
            pnlInput.Controls.Add(txtUserInput);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(3, 19);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(662, 89);
            pnlInput.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(581, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(78, 80);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserInput.BackColor = Color.White;
            txtUserInput.Location = new Point(3, 3);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(572, 80);
            txtUserInput.TabIndex = 0;
            // 
            // agentConversation
            // 
            agentConversation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            agentConversation.Controls.Add(conversationContentPanel);
            agentConversation.Location = new Point(3, 0);
            agentConversation.Name = "agentConversation";
            agentConversation.Size = new Size(665, 533);
            agentConversation.TabIndex = 0;
            agentConversation.TabStop = false;
            agentConversation.Text = "Conversation";
            // 
            // conversationContentPanel
            // 
            conversationContentPanel.AutoScroll = true;
            conversationContentPanel.Controls.Add(txtChat);
            conversationContentPanel.Dock = DockStyle.Fill;
            conversationContentPanel.Location = new Point(3, 19);
            conversationContentPanel.Name = "conversationContentPanel";
            conversationContentPanel.Size = new Size(659, 511);
            conversationContentPanel.TabIndex = 0;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.White;
            txtChat.Dock = DockStyle.Fill;
            txtChat.Location = new Point(0, 0);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(659, 511);
            txtChat.TabIndex = 0;
            txtChat.Text = "";
            // 
            // SmartAgent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1036, 653);
            Controls.Add(agentContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SmartAgent";
            Text = "Smart Agent";
            FormClosing += SmartAgent_FormClosing;
            Load += SmartAgent_Load;
            agentContainer.Panel1.ResumeLayout(false);
            agentContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)agentContainer).EndInit();
            agentContainer.ResumeLayout(false);
            agentSettingsGrp.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpAgentControl.ResumeLayout(false);
            grpAgentControl.PerformLayout();
            grpPersonality.ResumeLayout(false);
            grpPersonality.PerformLayout();
            grpAgentID.ResumeLayout(false);
            grpAgentID.PerformLayout();
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            grpUserInput.ResumeLayout(false);
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            agentConversation.ResumeLayout(false);
            conversationContentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer agentContainer;
        private GroupBox agentSettingsGrp;
        private GroupBox agentConversation;
        private Panel conversationContentPanel;
        private Panel settingsPanel;
        private GroupBox grpUserInput;
        private Panel pnlInput;
        private Button btnSend;
        private TextBox txtUserInput;
        private RichTextBox txtChat;
        private GroupBox grpName;
        private TextBox txtAgentName;
        private GroupBox grpAgentID;
        private TextBox txtAgentID;
        private GroupBox grpPersonality;
        private TextBox txtAgentPersonality;
        private Button btnReset;
        private Button btnSaveAgent;
        private GroupBox grpAgentControl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSlaveMessage;
        private GroupBox groupBox3;
        private CheckedListBox checkedListSelectedSlaves;
        private CheckBox chkSmartAgentEnabled;
    }
}