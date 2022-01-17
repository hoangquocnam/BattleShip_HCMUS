
namespace BattleshipServer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbxClients = new System.Windows.Forms.ListBox();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbxHeader = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lbllist = new System.Windows.Forms.Label();
            this.panelLogs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxClients
            // 
            this.lbxClients.FormattingEnabled = true;
            this.lbxClients.ItemHeight = 28;
            this.lbxClients.Location = new System.Drawing.Point(482, 87);
            this.lbxClients.Margin = new System.Windows.Forms.Padding(2);
            this.lbxClients.Name = "lbxClients";
            this.lbxClients.Size = new System.Drawing.Size(150, 368);
            this.lbxClients.TabIndex = 0;
            this.lbxClients.TabStop = false;
            // 
            // panelLogs
            // 
            this.panelLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogs.Controls.Add(this.txtLogs);
            this.panelLogs.Location = new System.Drawing.Point(14, 152);
            this.panelLogs.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(450, 300);
            this.panelLogs.TabIndex = 4;
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.White;
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.HideSelection = false;
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(448, 298);
            this.txtLogs.TabIndex = 3;
            this.txtLogs.TabStop = false;
            this.txtLogs.Text = "";
            this.txtLogs.WordWrap = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::BattleshipServer.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(275, 11);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::BattleshipServer.Properties.Resources.Start;
            this.btnStart.Location = new System.Drawing.Point(65, 11);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 78);
            this.panel1.TabIndex = 11;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panelHeader.Controls.Add(this.pbxHeader);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(648, 41);
            this.panelHeader.TabIndex = 12;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // pbxHeader
            // 
            this.pbxHeader.Image = global::BattleshipServer.Properties.Resources.Ship;
            this.pbxHeader.Location = new System.Drawing.Point(14, 8);
            this.pbxHeader.Name = "pbxHeader";
            this.pbxHeader.Size = new System.Drawing.Size(24, 24);
            this.pbxHeader.TabIndex = 9;
            this.pbxHeader.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHeader.Location = new System.Drawing.Point(41, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 28);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Battleship Server";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::BattleshipServer.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(608, 8);
            this.btnExit.Name = "btnExit";
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
            this.btnMinimize.Image = global::BattleshipServer.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(578, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllist.ForeColor = System.Drawing.Color.Green;
            this.lbllist.Location = new System.Drawing.Point(508, 62);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(131, 23);
            this.lbllist.TabIndex = 13;
            this.lbllist.Text = "Online list";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(648, 466);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogs);
            this.Controls.Add(this.lbxClients);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batteship Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.panelLogs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxClients;
        private System.Windows.Forms.Panel panelLogs;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbxHeader;
        private System.Windows.Forms.Label lbllist;
    }
}