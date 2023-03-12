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
            components = new System.ComponentModel.Container();
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
            button1 = new Button();
            chkSmartAgentEnabled = new CheckBox();
            btnSaveAgent = new Button();
            btnReset = new Button();
            grpPersonality = new GroupBox();
            txtAgentPersonality = new TextBox();
            grpAgentID = new GroupBox();
            txtAgentID = new TextBox();
            grpName = new GroupBox();
            txtAgentName = new TextBox();
            tabDialogs = new TabControl();
            tabPageText = new TabPage();
            agentConversation = new GroupBox();
            conversationContentPanel = new Panel();
            txtChat = new RichTextBox();
            tabPageCode = new TabPage();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            txtCode = new FastColoredTextBoxNS.FastColoredTextBox();
            grpUserInput = new GroupBox();
            pnlInput = new Panel();
            btnSend = new Button();
            txtUserInput = new TextBox();
            agentStatus = new StatusStrip();
            agentStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            agentProgress = new ToolStripProgressBar();
            agentTools = new ToolStrip();
            btnTTS = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            ttsVoice = new ToolStripComboBox();
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
            tabDialogs.SuspendLayout();
            tabPageText.SuspendLayout();
            agentConversation.SuspendLayout();
            conversationContentPanel.SuspendLayout();
            tabPageCode.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCode).BeginInit();
            grpUserInput.SuspendLayout();
            pnlInput.SuspendLayout();
            agentStatus.SuspendLayout();
            agentTools.SuspendLayout();
            SuspendLayout();
            // 
            // agentContainer
            // 
            agentContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            agentContainer.Location = new Point(0, 42);
            agentContainer.Name = "agentContainer";
            // 
            // agentContainer.Panel1
            // 
            agentContainer.Panel1.Controls.Add(agentSettingsGrp);
            // 
            // agentContainer.Panel2
            // 
            agentContainer.Panel2.Controls.Add(tabDialogs);
            agentContainer.Panel2.Controls.Add(grpUserInput);
            agentContainer.Size = new Size(1036, 586);
            agentContainer.SplitterDistance = 361;
            agentContainer.TabIndex = 0;
            // 
            // agentSettingsGrp
            // 
            agentSettingsGrp.Controls.Add(settingsPanel);
            agentSettingsGrp.Dock = DockStyle.Fill;
            agentSettingsGrp.Location = new Point(0, 0);
            agentSettingsGrp.Name = "agentSettingsGrp";
            agentSettingsGrp.Size = new Size(361, 586);
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
            settingsPanel.Size = new Size(355, 564);
            settingsPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(6, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 221);
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
            groupBox3.Size = new Size(325, 101);
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
            checkedListSelectedSlaves.Size = new Size(319, 79);
            checkedListSelectedSlaves.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtSlaveMessage);
            groupBox2.Location = new Point(6, 126);
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
            grpAgentControl.Controls.Add(button1);
            grpAgentControl.Controls.Add(chkSmartAgentEnabled);
            grpAgentControl.Controls.Add(btnSaveAgent);
            grpAgentControl.Controls.Add(btnReset);
            grpAgentControl.Location = new Point(6, 453);
            grpAgentControl.Name = "grpAgentControl";
            grpAgentControl.Size = new Size(343, 108);
            grpAgentControl.TabIndex = 5;
            grpAgentControl.TabStop = false;
            grpAgentControl.Text = "Agent control";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(172, 55);
            button1.Name = "button1";
            button1.Size = new Size(78, 47);
            button1.TabIndex = 8;
            button1.Text = "Analyze recording";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkSmartAgentEnabled
            // 
            chkSmartAgentEnabled.AutoSize = true;
            chkSmartAgentEnabled.Location = new Point(12, 29);
            chkSmartAgentEnabled.Name = "chkSmartAgentEnabled";
            chkSmartAgentEnabled.Size = new Size(135, 19);
            chkSmartAgentEnabled.TabIndex = 7;
            chkSmartAgentEnabled.Text = "Smart agent enabled";
            chkSmartAgentEnabled.UseVisualStyleBackColor = true;
            // 
            // btnSaveAgent
            // 
            btnSaveAgent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAgent.Location = new Point(6, 55);
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
            btnReset.Location = new Point(88, 55);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 47);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // grpPersonality
            // 
            grpPersonality.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonality.Controls.Add(txtAgentPersonality);
            grpPersonality.Location = new Point(6, 117);
            grpPersonality.Name = "grpPersonality";
            grpPersonality.Size = new Size(343, 103);
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
            txtAgentPersonality.ScrollBars = ScrollBars.Vertical;
            txtAgentPersonality.Size = new Size(337, 81);
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
            // tabDialogs
            // 
            tabDialogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDialogs.Controls.Add(tabPageText);
            tabDialogs.Controls.Add(tabPageCode);
            tabDialogs.Location = new Point(6, 3);
            tabDialogs.Name = "tabDialogs";
            tabDialogs.SelectedIndex = 0;
            tabDialogs.Size = new Size(659, 463);
            tabDialogs.TabIndex = 2;
            // 
            // tabPageText
            // 
            tabPageText.Controls.Add(agentConversation);
            tabPageText.Location = new Point(4, 24);
            tabPageText.Name = "tabPageText";
            tabPageText.Padding = new Padding(3);
            tabPageText.Size = new Size(651, 435);
            tabPageText.TabIndex = 0;
            tabPageText.Text = "Text";
            tabPageText.UseVisualStyleBackColor = true;
            // 
            // agentConversation
            // 
            agentConversation.Controls.Add(conversationContentPanel);
            agentConversation.Dock = DockStyle.Fill;
            agentConversation.Location = new Point(3, 3);
            agentConversation.Name = "agentConversation";
            agentConversation.Size = new Size(645, 429);
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
            conversationContentPanel.Size = new Size(639, 407);
            conversationContentPanel.TabIndex = 0;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.White;
            txtChat.BorderStyle = BorderStyle.None;
            txtChat.Dock = DockStyle.Fill;
            txtChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChat.Location = new Point(0, 0);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(639, 407);
            txtChat.TabIndex = 0;
            txtChat.Text = "";
            // 
            // tabPageCode
            // 
            tabPageCode.Controls.Add(groupBox4);
            tabPageCode.Location = new Point(4, 24);
            tabPageCode.Name = "tabPageCode";
            tabPageCode.Padding = new Padding(3);
            tabPageCode.Size = new Size(651, 435);
            tabPageCode.TabIndex = 1;
            tabPageCode.Text = "Code";
            tabPageCode.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(645, 429);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Code";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(txtCode);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 407);
            panel1.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.AllowSeveralTextStyleDrawing = true;
            txtCode.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            txtCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            txtCode.AutoScrollMinSize = new Size(2, 14);
            txtCode.BackBrush = null;
            txtCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            txtCode.CharHeight = 14;
            txtCode.CharWidth = 8;
            txtCode.DefaultMarkerSize = 8;
            txtCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            txtCode.Dock = DockStyle.Fill;
            txtCode.IsReplaceMode = false;
            txtCode.Language = FastColoredTextBoxNS.Language.CSharp;
            txtCode.LeftBracket = '(';
            txtCode.LeftBracket2 = '{';
            txtCode.Location = new Point(0, 0);
            txtCode.Name = "txtCode";
            txtCode.Paddings = new Padding(0);
            txtCode.RightBracket = ')';
            txtCode.RightBracket2 = '}';
            txtCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            txtCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtCode.ServiceColors");
            txtCode.Size = new Size(639, 407);
            txtCode.TabIndex = 0;
            txtCode.Zoom = 100;
            // 
            // grpUserInput
            // 
            grpUserInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpUserInput.Controls.Add(pnlInput);
            grpUserInput.Location = new Point(3, 472);
            grpUserInput.Name = "grpUserInput";
            grpUserInput.Size = new Size(668, 114);
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
            pnlInput.Size = new Size(662, 92);
            pnlInput.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(581, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(78, 86);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserInput.BackColor = Color.White;
            txtUserInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserInput.Location = new Point(3, 3);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.ScrollBars = ScrollBars.Vertical;
            txtUserInput.Size = new Size(572, 86);
            txtUserInput.TabIndex = 0;
            // 
            // agentStatus
            // 
            agentStatus.Items.AddRange(new ToolStripItem[] { agentStatusLabel, toolStripStatusLabel1, agentProgress });
            agentStatus.Location = new Point(0, 631);
            agentStatus.Name = "agentStatus";
            agentStatus.RenderMode = ToolStripRenderMode.Professional;
            agentStatus.Size = new Size(1036, 22);
            agentStatus.SizingGrip = false;
            agentStatus.TabIndex = 1;
            // 
            // agentStatusLabel
            // 
            agentStatusLabel.Name = "agentStatusLabel";
            agentStatusLabel.Size = new Size(39, 17);
            agentStatusLabel.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(982, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // agentProgress
            // 
            agentProgress.Name = "agentProgress";
            agentProgress.Size = new Size(100, 16);
            agentProgress.Style = ProgressBarStyle.Marquee;
            agentProgress.Visible = false;
            // 
            // agentTools
            // 
            agentTools.Items.AddRange(new ToolStripItem[] { btnTTS, toolStripButton1, ttsVoice });
            agentTools.Location = new Point(0, 0);
            agentTools.Name = "agentTools";
            agentTools.RenderMode = ToolStripRenderMode.Professional;
            agentTools.Size = new Size(1036, 25);
            agentTools.Stretch = true;
            agentTools.TabIndex = 2;
            agentTools.Text = "agentTools";
            // 
            // btnTTS
            // 
            btnTTS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTTS.Image = Properties.Resources.mute_sound_speaker_volume_icon;
            btnTTS.ImageTransparentColor = Color.Magenta;
            btnTTS.Name = "btnTTS";
            btnTTS.Size = new Size(23, 22);
            btnTTS.Text = "Text to speech";
            btnTTS.Click += btnTTS_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._9035019_mic_off_icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Mic";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // ttsVoice
            // 
            ttsVoice.DropDownWidth = 200;
            ttsVoice.Name = "ttsVoice";
            ttsVoice.Size = new Size(200, 25);
            ttsVoice.TextChanged += ttsVoice_TextChanged;
            // 
            // SmartAgent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1036, 653);
            Controls.Add(agentTools);
            Controls.Add(agentStatus);
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
            tabDialogs.ResumeLayout(false);
            tabPageText.ResumeLayout(false);
            agentConversation.ResumeLayout(false);
            conversationContentPanel.ResumeLayout(false);
            tabPageCode.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCode).EndInit();
            grpUserInput.ResumeLayout(false);
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            agentStatus.ResumeLayout(false);
            agentStatus.PerformLayout();
            agentTools.ResumeLayout(false);
            agentTools.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TabControl tabDialogs;
        private TabPage tabPageText;
        private TabPage tabPageCode;
        private GroupBox groupBox4;
        private Panel panel1;
        private FastColoredTextBoxNS.FastColoredTextBox txtCode;
        private Button button1;
        private StatusStrip agentStatus;
        private ToolStripStatusLabel agentStatusLabel;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar agentProgress;
        private ToolStrip agentTools;
        private ToolStripButton btnTTS;
        private ToolStripComboBox ttsVoice;
        private ToolStripButton toolStripButton1;
    }
}