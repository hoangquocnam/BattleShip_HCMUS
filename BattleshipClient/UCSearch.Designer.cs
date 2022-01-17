
namespace BattleshipClient
{
    partial class UCSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.cbxSearchField = new System.Windows.Forms.ComboBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(203, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 26);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(65, 346);
            this.txtNote.MaxLength = 100;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(220, 60);
            this.txtNote.TabIndex = 27;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(62, 330);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 23);
            this.lblNote.TabIndex = 26;
            this.lblNote.Text = "Note:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(65, 246);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(220, 33);
            this.txtDOB.TabIndex = 25;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(62, 230);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(114, 23);
            this.lblDateOfBirth.TabIndex = 24;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(65, 146);
            this.txtFullName.MaxLength = 30;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(220, 33);
            this.txtFullName.TabIndex = 23;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(62, 130);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 23);
            this.lblFullName.TabIndex = 22;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(65, 48);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 33);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(61, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 23);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(65, 196);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(220, 33);
            this.txtStatus.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(62, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 23);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status:";
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.cbxSearchField);
            this.panelContainer.Controls.Add(this.txtPoint);
            this.panelContainer.Controls.Add(this.lblPoint);
            this.panelContainer.Controls.Add(this.txtUsername);
            this.panelContainer.Controls.Add(this.txtStatus);
            this.panelContainer.Controls.Add(this.lblStatus);
            this.panelContainer.Controls.Add(this.btnSearch);
            this.panelContainer.Controls.Add(this.txtNote);
            this.panelContainer.Controls.Add(this.lblUsername);
            this.panelContainer.Controls.Add(this.lblNote);
            this.panelContainer.Controls.Add(this.lblFullName);
            this.panelContainer.Controls.Add(this.txtDOB);
            this.panelContainer.Controls.Add(this.txtFullName);
            this.panelContainer.Controls.Add(this.lblDateOfBirth);
            this.panelContainer.Location = new System.Drawing.Point(250, 45);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(350, 450);
            this.panelContainer.TabIndex = 30;
            // 
            // cbxSearchField
            // 
            this.cbxSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchField.FormattingEnabled = true;
            this.cbxSearchField.Items.AddRange(new object[] {
            "All",
            "Full Name",
            "Status",
            "Date Of Birth",
            "Point",
            "Note"});
            this.cbxSearchField.Location = new System.Drawing.Point(64, 80);
            this.cbxSearchField.Name = "cbxSearchField";
            this.cbxSearchField.Size = new System.Drawing.Size(133, 36);
            this.cbxSearchField.TabIndex = 32;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(65, 296);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.Size = new System.Drawing.Size(220, 33);
            this.txtPoint.TabIndex = 31;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(62, 280);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(53, 23);
            this.lblPoint.TabIndex = 30;
            this.lblPoint.Text = "Point:";
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(850, 540);
            this.Load += new System.EventHandler(this.UCSearch_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.ComboBox cbxSearchField;
    }
}
