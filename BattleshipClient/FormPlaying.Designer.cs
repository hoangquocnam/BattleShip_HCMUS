
namespace BattleshipClient
{
    partial class FormPlaying
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaying));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSurrend = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttUpload = new System.Windows.Forms.ToolTip(this.components);
            this.ttRemove = new System.Windows.Forms.ToolTip(this.components);
            this.ttSurrend = new System.Windows.Forms.ToolTip(this.components);
            this.ttRivalmap = new System.Windows.Forms.ToolTip(this.components);
            this.ttYourmap = new System.Windows.Forms.ToolTip(this.components);
            this.ttTime = new System.Windows.Forms.ToolTip(this.components);
            this.ttYou = new System.Windows.Forms.ToolTip(this.components);
            this.ttRival = new System.Windows.Forms.ToolTip(this.components);
            this.ttPlay = new System.Windows.Forms.ToolTip(this.components);
            this.ttRoomID = new System.Windows.Forms.ToolTip(this.components);
            this.pcReady2 = new System.Windows.Forms.PictureBox();
            this.pcReady1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcReady2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcReady1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblRoomID);
            this.panelHeader.Controls.Add(this.lblRoom);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 41);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(161, 6);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BattleshipClient.Properties.Resources.icons8_battleship_32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 52);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblRoomID
            // 
            this.lblRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.lblRoomID.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.ForeColor = System.Drawing.Color.Gold;
            this.lblRoomID.Location = new System.Drawing.Point(522, 6);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(56, 33);
            this.lblRoomID.TabIndex = 34;
            this.lblRoomID.Text = "0";
            this.lblRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttRoomID.SetToolTip(this.lblRoomID, "Room ID");
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.Gold;
            this.lblRoom.Location = new System.Drawing.Point(459, 6);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(100, 41);
            this.lblRoom.TabIndex = 35;
            this.lblRoom.Text = "Room";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Orange;
            this.lblHeader.Location = new System.Drawing.Point(51, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(163, 28);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Battleship";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::BattleshipClient.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(964, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::BattleshipClient.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(934, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(13, 66);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(396, 392);
            this.pnlMain.TabIndex = 15;
            this.ttRivalmap.SetToolTip(this.pnlMain, "Rival\'s map");
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.Crimson;
            this.pnlSub.Enabled = false;
            this.pnlSub.Location = new System.Drawing.Point(591, 66);
            this.pnlSub.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(396, 392);
            this.pnlSub.TabIndex = 16;
            this.ttYourmap.SetToolTip(this.pnlSub, "Your map");
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnSurrend);
            this.panelControl.Controls.Add(this.btnPlay);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Controls.Add(this.btnUploadFile);
            this.panelControl.Location = new System.Drawing.Point(560, 470);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(428, 108);
            this.panelControl.TabIndex = 15;
            // 
            // btnSurrend
            // 
            this.btnSurrend.BackColor = System.Drawing.Color.Black;
            this.btnSurrend.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnSurrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurrend.Image = global::BattleshipClient.Properties.Resources.White_flag;
            this.btnSurrend.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSurrend.Location = new System.Drawing.Point(348, 33);
            this.btnSurrend.Name = "btnSurrend";
            this.btnSurrend.Size = new System.Drawing.Size(45, 45);
            this.btnSurrend.TabIndex = 4;
            this.ttSurrend.SetToolTip(this.btnSurrend, "Warning: Surrender and lose this game.");
            this.btnSurrend.UseVisualStyleBackColor = false;
            this.btnSurrend.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::BattleshipClient.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(43, 33);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 45);
            this.btnPlay.TabIndex = 3;
            this.ttPlay.SetToolTip(this.btnPlay, "Ready and wait for the rival.\r\n(Warning: Cannot choose your map again.)");
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::BattleshipClient.Properties.Resources.Remove;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(258, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 2;
            this.ttRemove.SetToolTip(this.btnClear, "Remove your map");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.Image = global::BattleshipClient.Properties.Resources.Upload;
            this.btnUploadFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUploadFile.Location = new System.Drawing.Point(168, 33);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(45, 45);
            this.btnUploadFile.TabIndex = 0;
            this.ttUpload.SetToolTip(this.btnUploadFile, "Upload your map from your computer.\r\n");
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::BattleshipClient.Properties.Resources.Player2;
            this.pic2.Location = new System.Drawing.Point(423, 292);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(31, 33);
            this.pic2.TabIndex = 18;
            this.pic2.TabStop = false;
            this.ttRival.SetToolTip(this.pic2, "Rival");
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(269, 561);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 27);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(39, 561);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(224, 33);
            this.txtMessage.TabIndex = 20;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogs.Location = new System.Drawing.Point(39, 461);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(315, 92);
            this.txtLogs.TabIndex = 19;
            this.txtLogs.Text = "";
            this.txtLogs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Enabled = false;
            this.txtPlayer1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.Location = new System.Drawing.Point(464, 244);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.ReadOnly = true;
            this.txtPlayer1.Size = new System.Drawing.Size(90, 30);
            this.txtPlayer1.TabIndex = 22;
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Enabled = false;
            this.txtPlayer2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.Location = new System.Drawing.Point(464, 295);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ReadOnly = true;
            this.txtPlayer2.Size = new System.Drawing.Size(90, 30);
            this.txtPlayer2.TabIndex = 23;
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic1
            // 
            this.pic1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic1.Image = global::BattleshipClient.Properties.Resources.Player1;
            this.pic1.Location = new System.Drawing.Point(423, 241);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(32, 33);
            this.pic1.TabIndex = 17;
            this.pic1.TabStop = false;
            this.ttYou.SetToolTip(this.pic1, "You");
            // 
            // lblCountDown
            // 
            this.lblCountDown.BackColor = System.Drawing.Color.HotPink;
            this.lblCountDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountDown.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Image = global::BattleshipClient.Properties.Resources.Clock;
            this.lblCountDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountDown.Location = new System.Drawing.Point(458, 136);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(84, 62);
            this.lblCountDown.TabIndex = 32;
            this.lblCountDown.Text = "10";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttTime.SetToolTip(this.lblCountDown, "Countdown form 10 to 0");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "-----------------------------";
            // 
            // pcReady2
            // 
            this.pcReady2.Image = global::BattleshipClient.Properties.Resources.icons8_ok_16;
            this.pcReady2.Location = new System.Drawing.Point(560, 296);
            this.pcReady2.Name = "pcReady2";
            this.pcReady2.Size = new System.Drawing.Size(18, 22);
            this.pcReady2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcReady2.TabIndex = 37;
            this.pcReady2.TabStop = false;
            this.pcReady2.Visible = false;
            // 
            // pcReady1
            // 
            this.pcReady1.Image = global::BattleshipClient.Properties.Resources.icons8_ok_16;
            this.pcReady1.Location = new System.Drawing.Point(560, 244);
            this.pcReady1.Name = "pcReady1";
            this.pcReady1.Size = new System.Drawing.Size(18, 22);
            this.pcReady1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcReady1.TabIndex = 38;
            this.pcReady1.TabStop = false;
            this.pcReady1.Visible = false;
            // 
            // FormPlaying
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pcReady1);
            this.Controls.Add(this.pcReady2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlaying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcReady2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcReady1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSurrend;
        private System.Windows.Forms.ToolTip ttUpload;
        private System.Windows.Forms.ToolTip ttRivalmap;
        private System.Windows.Forms.ToolTip ttYourmap;
        private System.Windows.Forms.ToolTip ttSurrend;
        private System.Windows.Forms.ToolTip ttRemove;
        private System.Windows.Forms.ToolTip ttRival;
        private System.Windows.Forms.ToolTip ttYou;
        private System.Windows.Forms.ToolTip ttTime;
        private System.Windows.Forms.ToolTip ttPlay;
        private System.Windows.Forms.ToolTip ttRoomID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcReady2;
        private System.Windows.Forms.PictureBox pcReady1;
    }
}

