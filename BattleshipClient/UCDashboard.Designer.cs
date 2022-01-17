
namespace BattleshipClient
{
    partial class UCDashboard
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
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbxClients = new System.Windows.Forms.ListBox();
            this.btnInvite = new System.Windows.Forms.Button();
            this.lblListUser = new System.Windows.Forms.Label();
            this.lblChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.White;
            this.txtLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(36, 55);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(597, 404);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "";
            this.txtLogs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(36, 469);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(479, 22);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(521, 465);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbxClients
            // 
            this.lbxClients.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxClients.FormattingEnabled = true;
            this.lbxClients.ItemHeight = 19;
            this.lbxClients.Location = new System.Drawing.Point(667, 55);
            this.lbxClients.Name = "lbxClients";
            this.lbxClients.ScrollAlwaysVisible = true;
            this.lbxClients.Size = new System.Drawing.Size(152, 403);
            this.lbxClients.TabIndex = 3;
            this.lbxClients.SelectedIndexChanged += new System.EventHandler(this.lbxClients_SelectedIndexChanged);
            // 
            // btnInvite
            // 
            this.btnInvite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvite.Location = new System.Drawing.Point(667, 465);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(152, 31);
            this.btnInvite.TabIndex = 4;
            this.btnInvite.Text = "Invite";
            this.btnInvite.UseVisualStyleBackColor = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // lblListUser
            // 
            this.lblListUser.AutoSize = true;
            this.lblListUser.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListUser.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblListUser.Location = new System.Drawing.Point(688, 16);
            this.lblListUser.Name = "lblListUser";
            this.lblListUser.Size = new System.Drawing.Size(105, 32);
            this.lblListUser.TabIndex = 5;
            this.lblListUser.Text = "Online";
            this.lblListUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.ForeColor = System.Drawing.Color.Orange;
            this.lblChat.Location = new System.Drawing.Point(28, 16);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(75, 32);
            this.lblChat.TabIndex = 6;
            this.lblChat.Text = "Chat";
            this.lblChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblListUser);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.lbxClients);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLogs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(850, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lbxClients;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.Label lblListUser;
        private System.Windows.Forms.Label lblChat;
    }
}
