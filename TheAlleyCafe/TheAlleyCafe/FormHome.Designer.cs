
namespace TheAlleyCafe
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelHome = new System.Windows.Forms.Panel();
            this.linkLblLogout = new System.Windows.Forms.LinkLabel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.MintCream;
            this.panelHome.Controls.Add(this.linkLblLogout);
            this.panelHome.Controls.Add(this.btnEmployee);
            this.panelHome.Controls.Add(this.btnOrders);
            this.panelHome.Controls.Add(this.btnItems);
            this.panelHome.Controls.Add(this.lblTitle);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(799, 423);
            this.panelHome.TabIndex = 0;
            // 
            // linkLblLogout
            // 
            this.linkLblLogout.AutoSize = true;
            this.linkLblLogout.LinkColor = System.Drawing.Color.White;
            this.linkLblLogout.Location = new System.Drawing.Point(745, 9);
            this.linkLblLogout.Name = "linkLblLogout";
            this.linkLblLogout.Size = new System.Drawing.Size(42, 15);
            this.linkLblLogout.TabIndex = 4;
            this.linkLblLogout.TabStop = true;
            this.linkLblLogout.Text = "logout";
            this.linkLblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogout_LinkClicked);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Teal;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployee.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployee.Location = new System.Drawing.Point(282, 267);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(225, 129);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Teal;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrders.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrders.Location = new System.Drawing.Point(485, 123);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(225, 129);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "ORDERS";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Teal;
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItems.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItems.Location = new System.Drawing.Point(81, 123);
            this.btnItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(225, 129);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "ITEMS";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(212, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Central Perk";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.LinkLabel linkLblLogout;
    }
}