namespace BattleshipClient
{
    partial class DemoGame
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
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(645, 39);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.ReadOnly = true;
            this.txtPlayer1.Size = new System.Drawing.Size(100, 26);
            this.txtPlayer1.TabIndex = 0;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayer1.Location = new System.Drawing.Point(574, 42);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player1:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2.Location = new System.Drawing.Point(574, 277);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(69, 20);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(645, 274);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ReadOnly = true;
            this.txtPlayer2.Size = new System.Drawing.Size(100, 26);
            this.txtPlayer2.TabIndex = 2;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer1);
            this.Name = "game";
            this.ShowInTaskbar = false;
            this.Text = "game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
    }
}