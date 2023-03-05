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
            grpAgentControl = new GroupBox();
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
            agentContainer.SplitterDistance = 343;
            agentContainer.TabIndex = 0;
            // 
            // agentSettingsGrp
            // 
            agentSettingsGrp.Controls.Add(settingsPanel);
            agentSettingsGrp.Dock = DockStyle.Fill;
            agentSettingsGrp.Location = new Point(0, 0);
            agentSettingsGrp.Name = "agentSettingsGrp";
            agentSettingsGrp.Size = new Size(343, 653);
            agentSettingsGrp.TabIndex = 0;
            agentSettingsGrp.TabStop = false;
            agentSettingsGrp.Text = "Agent settings";
            // 
            // settingsPanel
            // 
            settingsPanel.AutoScroll = true;
            settingsPanel.Controls.Add(grpAgentControl);
            settingsPanel.Controls.Add(grpPersonality);
            settingsPanel.Controls.Add(grpAgentID);
            settingsPanel.Controls.Add(grpName);
            settingsPanel.Dock = DockStyle.Fill;
            settingsPanel.Location = new Point(3, 19);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(337, 631);
            settingsPanel.TabIndex = 1;
            // 
            // grpAgentControl
            // 
            grpAgentControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAgentControl.Controls.Add(btnSaveAgent);
            grpAgentControl.Controls.Add(btnReset);
            grpAgentControl.Location = new Point(6, 520);
            grpAgentControl.Name = "grpAgentControl";
            grpAgentControl.Size = new Size(325, 108);
            grpAgentControl.TabIndex = 5;
            grpAgentControl.TabStop = false;
            grpAgentControl.Text = "Agent control";
            // 
            // btnSaveAgent
            // 
            btnSaveAgent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAgent.Location = new Point(6, 22);
            btnSaveAgent.Name = "btnSaveAgent";
            btnSaveAgent.Size = new Size(78, 80);
            btnSaveAgent.TabIndex = 3;
            btnSaveAgent.Text = "Save";
            btnSaveAgent.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(90, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 80);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // grpPersonality
            // 
            grpPersonality.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonality.Controls.Add(txtAgentPersonality);
            grpPersonality.Location = new Point(6, 117);
            grpPersonality.Name = "grpPersonality";
            grpPersonality.Size = new Size(325, 305);
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
            txtAgentPersonality.Size = new Size(319, 283);
            txtAgentPersonality.TabIndex = 1;
            // 
            // grpAgentID
            // 
            grpAgentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAgentID.Controls.Add(txtAgentID);
            grpAgentID.Location = new Point(6, 60);
            grpAgentID.Name = "grpAgentID";
            grpAgentID.Size = new Size(325, 51);
            grpAgentID.TabIndex = 1;
            grpAgentID.TabStop = false;
            grpAgentID.Text = "Agent id";
            // 
            // txtAgentID
            // 
            txtAgentID.Dock = DockStyle.Fill;
            txtAgentID.Location = new Point(3, 19);
            txtAgentID.Name = "txtAgentID";
            txtAgentID.Size = new Size(319, 23);
            txtAgentID.TabIndex = 1;
            // 
            // grpName
            // 
            grpName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpName.Controls.Add(txtAgentName);
            grpName.Location = new Point(9, 3);
            grpName.Name = "grpName";
            grpName.Size = new Size(325, 51);
            grpName.TabIndex = 0;
            grpName.TabStop = false;
            grpName.Text = "Agent name";
            // 
            // txtAgentName
            // 
            txtAgentName.Dock = DockStyle.Fill;
            txtAgentName.Location = new Point(3, 19);
            txtAgentName.Name = "txtAgentName";
            txtAgentName.Size = new Size(319, 23);
            txtAgentName.TabIndex = 1;
            // 
            // grpUserInput
            // 
            grpUserInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpUserInput.Controls.Add(pnlInput);
            grpUserInput.Location = new Point(3, 539);
            grpUserInput.Name = "grpUserInput";
            grpUserInput.Size = new Size(686, 111);
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
            pnlInput.Size = new Size(680, 89);
            pnlInput.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(599, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(78, 80);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserInput.BackColor = Color.White;
            txtUserInput.Location = new Point(3, 3);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(590, 80);
            txtUserInput.TabIndex = 0;
            // 
            // agentConversation
            // 
            agentConversation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            agentConversation.Controls.Add(conversationContentPanel);
            agentConversation.Location = new Point(0, 0);
            agentConversation.Name = "agentConversation";
            agentConversation.Size = new Size(686, 533);
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
            conversationContentPanel.Size = new Size(680, 511);
            conversationContentPanel.TabIndex = 0;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.White;
            txtChat.Dock = DockStyle.Fill;
            txtChat.Location = new Point(0, 0);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(680, 511);
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
            agentContainer.Panel1.ResumeLayout(false);
            agentContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)agentContainer).EndInit();
            agentContainer.ResumeLayout(false);
            agentSettingsGrp.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            grpAgentControl.ResumeLayout(false);
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
    }
}