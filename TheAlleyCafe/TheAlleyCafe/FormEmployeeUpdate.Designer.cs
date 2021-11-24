
namespace TheAlleyCafe
{
    partial class FormEmployeeUpdate
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelSearchEmployee = new System.Windows.Forms.Panel();
            this.lblClickForUpdate = new System.Windows.Forms.Label();
            this.dgvSearched = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSearchEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearched)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(702, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(890, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelSearchEmployee
            // 
            this.panelSearchEmployee.Controls.Add(this.lblClickForUpdate);
            this.panelSearchEmployee.Controls.Add(this.dgvSearched);
            this.panelSearchEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSearchEmployee.Location = new System.Drawing.Point(0, 152);
            this.panelSearchEmployee.Name = "panelSearchEmployee";
            this.panelSearchEmployee.Size = new System.Drawing.Size(976, 453);
            this.panelSearchEmployee.TabIndex = 2;
            // 
            // lblClickForUpdate
            // 
            this.lblClickForUpdate.AutoSize = true;
            this.lblClickForUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblClickForUpdate.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblClickForUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblClickForUpdate.Location = new System.Drawing.Point(408, 302);
            this.lblClickForUpdate.Name = "lblClickForUpdate";
            this.lblClickForUpdate.Size = new System.Drawing.Size(143, 17);
            this.lblClickForUpdate.TabIndex = 4;
            this.lblClickForUpdate.Text = "Double Click to Update";
            // 
            // dgvSearched
            // 
            this.dgvSearched.AllowUserToAddRows = false;
            this.dgvSearched.AllowUserToDeleteRows = false;
            this.dgvSearched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeName,
            this.Gender,
            this.Email,
            this.Password,
            this.Role,
            this.ContactNo,
            this.Address,
            this.JoiningDate});
            this.dgvSearched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearched.Location = new System.Drawing.Point(0, 0);
            this.dgvSearched.Name = "dgvSearched";
            this.dgvSearched.ReadOnly = true;
            this.dgvSearched.RowTemplate.Height = 25;
            this.dgvSearched.Size = new System.Drawing.Size(976, 453);
            this.dgvSearched.TabIndex = 0;
            this.dgvSearched.DoubleClick += new System.EventHandler(this.dgvSearched_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactNo.DataPropertyName = "ContactNo";
            this.ContactNo.HeaderText = "Contact No";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            this.ContactNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContactNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // JoiningDate
            // 
            this.JoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            this.JoiningDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.JoiningDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchById.Location = new System.Drawing.Point(581, 114);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(104, 36);
            this.lblSearchById.TabIndex = 3;
            this.lblSearchById.Text = "Search By Id";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(314, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 85);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Central Perk";
            // 
            // FormEmployeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 605);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearchById);
            this.Controls.Add(this.panelSearchEmployee);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployeeUpdate";
            this.Text = "Search for Employee";
            this.panelSearchEmployee.ResumeLayout(false);
            this.panelSearchEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSearchEmployee;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearched;
        private System.Windows.Forms.Label lblClickForUpdate;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.Label lblTitle;
    }
}