namespace MulticastChatPtP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Chat = new System.Windows.Forms.TabPage();
            this.pnlChatMessage = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Chat.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Chat);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // Chat
            // 
            this.Chat.Controls.Add(this.pnlChatMessage);
            this.Chat.Controls.Add(this.btnSend);
            this.Chat.Controls.Add(this.btnCamera);
            this.Chat.Controls.Add(this.btnFile);
            this.Chat.Controls.Add(this.tbMessage);
            this.Chat.Location = new System.Drawing.Point(4, 29);
            this.Chat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chat.Name = "Chat";
            this.Chat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chat.Size = new System.Drawing.Size(395, 392);
            this.Chat.TabIndex = 0;
            this.Chat.Text = "Chat";
            this.Chat.UseVisualStyleBackColor = true;
            // 
            // pnlChatMessage
            // 
            this.pnlChatMessage.BackColor = System.Drawing.Color.MistyRose;
            this.pnlChatMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChatMessage.Location = new System.Drawing.Point(3, 109);
            this.pnlChatMessage.Name = "pnlChatMessage";
            this.pnlChatMessage.Size = new System.Drawing.Size(389, 279);
            this.pnlChatMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(301, 61);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 31);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(158, 61);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(86, 31);
            this.btnCamera.TabIndex = 3;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(8, 61);
            this.btnFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(86, 31);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(6, 7);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(383, 51);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.tbName);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.btStop);
            this.Settings.Controls.Add(this.btStart);
            this.Settings.Controls.Add(this.tbRemotePort);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.tbLocalPort);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.tbAddress);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Location = new System.Drawing.Point(4, 29);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings.Size = new System.Drawing.Size(395, 392);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.Color.DarkRed;
            this.tbName.Location = new System.Drawing.Point(121, 137);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Your name here";
            this.tbName.Size = new System.Drawing.Size(155, 27);
            this.tbName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Name:";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(104, 240);
            this.btStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(86, 31);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(104, 201);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(86, 31);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbRemotePort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRemotePort.ForeColor = System.Drawing.Color.DarkRed;
            this.tbRemotePort.Location = new System.Drawing.Point(121, 99);
            this.tbRemotePort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(155, 27);
            this.tbRemotePort.TabIndex = 5;
            this.tbRemotePort.Text = "8888";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remote Port:";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbLocalPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbLocalPort.ForeColor = System.Drawing.Color.DarkRed;
            this.tbLocalPort.Location = new System.Drawing.Point(121, 60);
            this.tbLocalPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(155, 27);
            this.tbLocalPort.TabIndex = 3;
            this.tbLocalPort.Text = "8888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local Port:";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAddress.ForeColor = System.Drawing.Color.DarkRed;
            this.tbAddress.Location = new System.Drawing.Point(121, 21);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(155, 27);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "239.0.0.100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 425);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Chat.ResumeLayout(false);
            this.Chat.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Chat;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Panel pnlChatMessage;
    }
}
