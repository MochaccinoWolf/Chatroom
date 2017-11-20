namespace Chatroom
{
    partial class Form1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbUserMessage = new System.Windows.Forms.RichTextBox();
            this.rtbMessageList = new System.Windows.Forms.RichTextBox();
            this.tbUserList = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(528, 321);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 26);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbUserMessage
            // 
            this.rtbUserMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbUserMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbUserMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUserMessage.Location = new System.Drawing.Point(44, 324);
            this.rtbUserMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbUserMessage.Name = "rtbUserMessage";
            this.rtbUserMessage.Size = new System.Drawing.Size(443, 26);
            this.rtbUserMessage.TabIndex = 2;
            this.rtbUserMessage.Text = "";
            this.rtbUserMessage.TextChanged += new System.EventHandler(this.rtbUserMessage_TextChanged);
            this.rtbUserMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbUserMessage_KeyPress);
            // 
            // rtbMessageList
            // 
            this.rtbMessageList.BackColor = System.Drawing.Color.Gainsboro;
            this.rtbMessageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessageList.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMessageList.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessageList.Location = new System.Drawing.Point(44, 59);
            this.rtbMessageList.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessageList.Name = "rtbMessageList";
            this.rtbMessageList.ReadOnly = true;
            this.rtbMessageList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbMessageList.Size = new System.Drawing.Size(311, 242);
            this.rtbMessageList.TabIndex = 0;
            this.rtbMessageList.TabStop = false;
            this.rtbMessageList.Text = "";
            this.rtbMessageList.TextChanged += new System.EventHandler(this.rtbMessageList_TextChanged);
            this.rtbMessageList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbMessageList_KeyPress);
            // 
            // tbUserList
            // 
            this.tbUserList.BackColor = System.Drawing.Color.Gray;
            this.tbUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUserList.ForeColor = System.Drawing.SystemColors.Window;
            this.tbUserList.Location = new System.Drawing.Point(363, 60);
            this.tbUserList.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserList.Multiline = true;
            this.tbUserList.Name = "tbUserList";
            this.tbUserList.ReadOnly = true;
            this.tbUserList.Size = new System.Drawing.Size(265, 242);
            this.tbUserList.TabIndex = 3;
            this.tbUserList.Text = "USERS:\r\n";
            this.tbUserList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserList.WordWrap = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(528, 364);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 32);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tbUserList);
            this.Controls.Add(this.rtbMessageList);
            this.Controls.Add(this.rtbUserMessage);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Message Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbUserMessage;
        private System.Windows.Forms.RichTextBox rtbMessageList;
        public System.Windows.Forms.TextBox tbUserList;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

