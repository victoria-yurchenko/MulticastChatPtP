namespace MulticastChatPtP
{
    partial class ChatMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTbMessage = new System.Windows.Forms.TextBox();
            this.ucBtFile = new System.Windows.Forms.Button();
            this.ucTbDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ucTbMessage
            // 
            this.ucTbMessage.Location = new System.Drawing.Point(3, 0);
            this.ucTbMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucTbMessage.Multiline = true;
            this.ucTbMessage.Name = "ucTbMessage";
            this.ucTbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ucTbMessage.Size = new System.Drawing.Size(359, 61);
            this.ucTbMessage.TabIndex = 0;
            // 
            // ucBtFile
            // 
            this.ucBtFile.Location = new System.Drawing.Point(368, 4);
            this.ucBtFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucBtFile.Name = "ucBtFile";
            this.ucBtFile.Size = new System.Drawing.Size(86, 31);
            this.ucBtFile.TabIndex = 1;
            this.ucBtFile.Text = "Load";
            this.ucBtFile.UseVisualStyleBackColor = true;
            // 
            // ucTbDateTime
            // 
            this.ucTbDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ucTbDateTime.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucTbDateTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ucTbDateTime.Location = new System.Drawing.Point(368, 42);
            this.ucTbDateTime.Name = "ucTbDateTime";
            this.ucTbDateTime.ReadOnly = true;
            this.ucTbDateTime.Size = new System.Drawing.Size(86, 17);
            this.ucTbDateTime.TabIndex = 2;
            // 
            // ChatMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTbDateTime);
            this.Controls.Add(this.ucBtFile);
            this.Controls.Add(this.ucTbMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChatMessage";
            this.Size = new System.Drawing.Size(459, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ucTbMessage;
        private System.Windows.Forms.Button ucBtFile;
        private System.Windows.Forms.TextBox ucTbDateTime;
    }
}
