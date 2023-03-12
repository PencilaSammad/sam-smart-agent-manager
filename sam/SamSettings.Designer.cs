namespace sam
{
    partial class SamSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamSettings));
            grpAPI = new GroupBox();
            txtApiKey = new TextBox();
            grpPersonality = new GroupBox();
            txtAgentPersonality = new TextBox();
            grpAgentControl = new GroupBox();
            btnDeleteRecordings = new Button();
            btnLoadDefault = new Button();
            btnSaveAgent = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            cmbVoiceRecLang = new ComboBox();
            label4 = new Label();
            cmbTTSVoice = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtTTSregion = new TextBox();
            label1 = new Label();
            txtAzureAPI = new TextBox();
            grpAPI.SuspendLayout();
            grpPersonality.SuspendLayout();
            grpAgentControl.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpAPI
            // 
            grpAPI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAPI.Controls.Add(txtApiKey);
            grpAPI.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpAPI.Location = new Point(12, 12);
            grpAPI.Name = "grpAPI";
            grpAPI.Size = new Size(391, 51);
            grpAPI.TabIndex = 1;
            grpAPI.TabStop = false;
            grpAPI.Text = "OpenAI API Key";
            // 
            // txtApiKey
            // 
            txtApiKey.Dock = DockStyle.Fill;
            txtApiKey.Location = new Point(3, 19);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '*';
            txtApiKey.Size = new Size(385, 23);
            txtApiKey.TabIndex = 1;
            // 
            // grpPersonality
            // 
            grpPersonality.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonality.Controls.Add(txtAgentPersonality);
            grpPersonality.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpPersonality.Location = new Point(9, 338);
            grpPersonality.Name = "grpPersonality";
            grpPersonality.Size = new Size(391, 85);
            grpPersonality.TabIndex = 3;
            grpPersonality.TabStop = false;
            grpPersonality.Text = "Default agent personality";
            // 
            // txtAgentPersonality
            // 
            txtAgentPersonality.Dock = DockStyle.Fill;
            txtAgentPersonality.Location = new Point(3, 19);
            txtAgentPersonality.Multiline = true;
            txtAgentPersonality.Name = "txtAgentPersonality";
            txtAgentPersonality.Size = new Size(385, 63);
            txtAgentPersonality.TabIndex = 1;
            // 
            // grpAgentControl
            // 
            grpAgentControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAgentControl.Controls.Add(btnDeleteRecordings);
            grpAgentControl.Controls.Add(btnLoadDefault);
            grpAgentControl.Controls.Add(btnSaveAgent);
            grpAgentControl.Controls.Add(btnReset);
            grpAgentControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpAgentControl.Location = new Point(12, 429);
            grpAgentControl.Name = "grpAgentControl";
            grpAgentControl.Size = new Size(388, 108);
            grpAgentControl.TabIndex = 6;
            grpAgentControl.TabStop = false;
            grpAgentControl.Text = "Settings control";
            // 
            // btnDeleteRecordings
            // 
            btnDeleteRecordings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteRecordings.Location = new Point(299, 22);
            btnDeleteRecordings.Name = "btnDeleteRecordings";
            btnDeleteRecordings.Size = new Size(78, 80);
            btnDeleteRecordings.TabIndex = 6;
            btnDeleteRecordings.Text = "Delete recordings";
            btnDeleteRecordings.UseVisualStyleBackColor = true;
            btnDeleteRecordings.Click += btnDeleteRecordings_Click;
            // 
            // btnLoadDefault
            // 
            btnLoadDefault.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadDefault.Location = new Point(174, 22);
            btnLoadDefault.Name = "btnLoadDefault";
            btnLoadDefault.Size = new Size(119, 80);
            btnLoadDefault.TabIndex = 5;
            btnLoadDefault.Text = "Load default agents";
            btnLoadDefault.UseVisualStyleBackColor = true;
            btnLoadDefault.Click += btnLoadDefault_Click;
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
            btnSaveAgent.Click += btnSaveAgent_Click;
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
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbVoiceRecLang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbTTSVoice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTTSregion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAzureAPI);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 244);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Azure settings";
            // 
            // cmbVoiceRecLang
            // 
            cmbVoiceRecLang.FormattingEnabled = true;
            cmbVoiceRecLang.Items.AddRange(new object[] { "fi-FI", "en-US" });
            cmbVoiceRecLang.Location = new Point(3, 208);
            cmbVoiceRecLang.Name = "cmbVoiceRecLang";
            cmbVoiceRecLang.Size = new Size(385, 23);
            cmbVoiceRecLang.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 190);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 8;
            label4.Text = "Voice recognition language";
            // 
            // cmbTTSVoice
            // 
            cmbTTSVoice.FormattingEnabled = true;
            cmbTTSVoice.Items.AddRange(new object[] { "fi-FI-HarriNeural", "fi-FI-NooraNeural", "fi-FI-SelmaNeural", "en-US-AIGenerate1Neural", "en-US-AIGenerate2Neural", "en-US-AmberNeural", "en-US-AnaNeural", "en-US-AriaNeural", "en-US-AshleyNeural", "en-US-BrandonNeural", "en-US-ChristopherNeural", "en-US-CoraNeural", "en-US-DavisNeural", "en-US-ElizabethNeural", "en-US-EricNeural", "en-US-GuyNeural", "en-US-JacobNeural", "en-US-JaneNeural", "en-US-JasonNeural", "en-US-JennyNeural", "en-US-MichelleNeural", "en-US-MonicaNeural", "en-US-NancyNeural", "en-US-RogerNeural", "en-US-SaraNeural", "en-US-SteffanNeural", "en-US-TonyNeural", "en-US-JennyMultilingualNeural", "fr-FR-AlainNeural", "fr-FR-BrigitteNeural", "fr-FR-CelesteNeural", "fr-FR-ClaudeNeural", "fr-FR-CoralieNeural", "fr-FR-DeniseNeural", "fr-FR-EloiseNeural", "fr-FR-HenriNeural", "fr-FR-JacquelineNeural", "fr-FR-JeromeNeural", "fr-FR-JosephineNeural", "fr-FR-MauriceNeural", "fr-FR-YvesNeural", "fr-FR-YvetteNeural" });
            cmbTTSVoice.Location = new Point(3, 164);
            cmbTTSVoice.Name = "cmbTTSVoice";
            cmbTTSVoice.Size = new Size(385, 23);
            cmbTTSVoice.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 6;
            label3.Text = "Text to speech voice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Text to speech region";
            // 
            // txtTTSregion
            // 
            txtTTSregion.Location = new Point(3, 106);
            txtTTSregion.Name = "txtTTSregion";
            txtTTSregion.Size = new Size(385, 23);
            txtTTSregion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Text to speech API key";
            // 
            // txtAzureAPI
            // 
            txtAzureAPI.Location = new Point(3, 47);
            txtAzureAPI.Name = "txtAzureAPI";
            txtAzureAPI.PasswordChar = '*';
            txtAzureAPI.Size = new Size(385, 23);
            txtAzureAPI.TabIndex = 1;
            // 
            // SamSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(415, 540);
            Controls.Add(groupBox1);
            Controls.Add(grpAgentControl);
            Controls.Add(grpPersonality);
            Controls.Add(grpAPI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SamSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAM Settings";
            TopMost = true;
            Load += SamSettings_Load;
            grpAPI.ResumeLayout(false);
            grpAPI.PerformLayout();
            grpPersonality.ResumeLayout(false);
            grpPersonality.PerformLayout();
            grpAgentControl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAPI;
        private TextBox txtApiKey;
        private GroupBox grpPersonality;
        private TextBox txtAgentPersonality;
        private GroupBox grpAgentControl;
        private Button btnSaveAgent;
        private Button btnReset;
        private Button btnLoadDefault;
        private Button btnDeleteRecordings;
        private GroupBox groupBox1;
        private TextBox txtAzureAPI;
        private Label label3;
        private Label label2;
        private TextBox txtTTSregion;
        private Label label1;
        private ComboBox cmbTTSVoice;
        private ComboBox cmbVoiceRecLang;
        private Label label4;
    }
}