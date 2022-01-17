
namespace BattleshipClient
{
    partial class UCProfile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxEncrypt = new System.Windows.Forms.CheckBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnChangeSave2 = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnChangeSave1 = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxEncrypt);
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.btnChangeSave2);
            this.panel2.Controls.Add(this.txtNewPassword);
            this.panel2.Controls.Add(this.lblNewPassword);
            this.panel2.Controls.Add(this.txtCurrentPassword);
            this.panel2.Controls.Add(this.lblConfirmNewPassword);
            this.panel2.Controls.Add(this.lblCurrentPassword);
            this.panel2.Controls.Add(this.txtConfirmNewPassword);
            this.panel2.Location = new System.Drawing.Point(450, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 284);
            this.panel2.TabIndex = 62;
            // 
            // cbxEncrypt
            // 
            this.cbxEncrypt.AutoSize = true;
            this.cbxEncrypt.Checked = true;
            this.cbxEncrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEncrypt.Location = new System.Drawing.Point(65, 181);
            this.cbxEncrypt.Name = "cbxEncrypt";
            this.cbxEncrypt.Size = new System.Drawing.Size(104, 29);
            this.cbxEncrypt.TabIndex = 58;
            this.cbxEncrypt.Text = "Encrypt";
            this.cbxEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.Gray;
            this.btnCancel2.Enabled = false;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Location = new System.Drawing.Point(205, 217);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(80, 30);
            this.btnCancel2.TabIndex = 57;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnChangeSave2
            // 
            this.btnChangeSave2.BackColor = System.Drawing.Color.Beige;
            this.btnChangeSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSave2.Location = new System.Drawing.Point(115, 217);
            this.btnChangeSave2.Name = "btnChangeSave2";
            this.btnChangeSave2.Size = new System.Drawing.Size(80, 30);
            this.btnChangeSave2.TabIndex = 56;
            this.btnChangeSave2.Text = "Change";
            this.btnChangeSave2.UseVisualStyleBackColor = false;
            this.btnChangeSave2.Click += new System.EventHandler(this.btnChangeSave2_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Location = new System.Drawing.Point(65, 100);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(220, 30);
            this.txtNewPassword.TabIndex = 51;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(62, 84);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(124, 23);
            this.lblNewPassword.TabIndex = 50;
            this.lblNewPassword.Text = "New password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Enabled = false;
            this.txtCurrentPassword.Location = new System.Drawing.Point(65, 50);
            this.txtCurrentPassword.MaxLength = 20;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(220, 30);
            this.txtCurrentPassword.TabIndex = 55;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(62, 134);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(185, 23);
            this.lblConfirmNewPassword.TabIndex = 52;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(62, 34);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(147, 23);
            this.lblCurrentPassword.TabIndex = 54;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Enabled = false;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(65, 150);
            this.txtConfirmNewPassword.MaxLength = 20;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(220, 30);
            this.txtConfirmNewPassword.TabIndex = 53;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Controls.Add(this.btnChangeSave1);
            this.panel1.Controls.Add(this.lblPoint);
            this.panel1.Controls.Add(this.txtPoint);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.lblDateOfBirth);
            this.panel1.Controls.Add(this.lblNote);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Location = new System.Drawing.Point(50, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 450);
            this.panel1.TabIndex = 61;
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.Gray;
            this.btnCancel1.Enabled = false;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Location = new System.Drawing.Point(205, 321);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(80, 30);
            this.btnCancel1.TabIndex = 54;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnChangeSave1
            // 
            this.btnChangeSave1.BackColor = System.Drawing.Color.Beige;
            this.btnChangeSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSave1.Location = new System.Drawing.Point(115, 321);
            this.btnChangeSave1.Name = "btnChangeSave1";
            this.btnChangeSave1.Size = new System.Drawing.Size(80, 30);
            this.btnChangeSave1.TabIndex = 53;
            this.btnChangeSave1.Text = "Change";
            this.btnChangeSave1.UseVisualStyleBackColor = false;
            this.btnChangeSave1.Click += new System.EventHandler(this.btnChangeSave1_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(62, 184);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(53, 23);
            this.lblPoint.TabIndex = 50;
            this.lblPoint.Text = "Point:";
            // 
            // txtPoint
            // 
            this.txtPoint.Enabled = false;
            this.txtPoint.Location = new System.Drawing.Point(65, 200);
            this.txtPoint.MaxLength = 30;
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(220, 30);
            this.txtPoint.TabIndex = 51;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(65, 50);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 30);
            this.txtUsername.TabIndex = 43;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(61, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 23);
            this.lblUsername.TabIndex = 42;
            this.lblUsername.Text = "Username:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(62, 84);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 23);
            this.lblFullName.TabIndex = 44;
            this.lblFullName.Text = "Full Name:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(65, 150);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(220, 30);
            this.dtpDOB.TabIndex = 49;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(65, 100);
            this.txtFullName.MaxLength = 30;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(220, 30);
            this.txtFullName.TabIndex = 45;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(62, 134);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(114, 23);
            this.lblDateOfBirth.TabIndex = 46;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(62, 234);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 23);
            this.lblNote.TabIndex = 47;
            this.lblNote.Text = "Note:";
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(65, 250);
            this.txtNote.MaxLength = 100;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(220, 60);
            this.txtNote.TabIndex = 48;
            // 
            // UCProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProfile";
            this.Size = new System.Drawing.Size(850, 540);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnChangeSave1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnChangeSave2;
        private System.Windows.Forms.CheckBox cbxEncrypt;
    }
}
