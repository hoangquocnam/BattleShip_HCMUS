namespace BattleshipClient
{
    partial class FormWinLose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWinLose));
            this.pc = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            this.SuspendLayout();
            // 
            // pc
            // 
            resources.ApplyResources(this.pc, "pc");
            this.pc.Name = "pc";
            this.pc.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.Name = "btnYes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btnNo, "btnNo");
            this.btnNo.Name = "btnNo";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblRes
            // 
            resources.ApplyResources(this.lblRes, "lblRes");
            this.lblRes.Name = "lblRes";
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRole.Name = "lblRole";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // lblCountDown
            // 
            resources.ApplyResources(this.lblCountDown, "lblCountDown");
            this.lblCountDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCountDown.Name = "lblCountDown";
            // 
            // FormWinLose
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ControlBox = false;
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.pc);
            this.Name = "FormWinLose";
            ((System.ComponentModel.ISupportInitialize)(this.pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pc;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountDown;
    }
}