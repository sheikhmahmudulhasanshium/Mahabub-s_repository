
namespace TheAlleyCafe
{
    partial class FormTakeOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVat = new System.Windows.Forms.Label();
            this.chkVat = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dvgDisplayOrder = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelOrderInfo = new System.Windows.Forms.Panel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbFoods = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblIteams = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayOrder)).BeginInit();
            this.panelOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVat);
            this.panel1.Controls.Add(this.chkVat);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.dvgDisplayOrder);
            this.panel1.Controls.Add(this.panelOrderInfo);
            this.panel1.Controls.Add(this.cmbFoods);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.lblIteams);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVat.Location = new System.Drawing.Point(14, 153);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(97, 25);
            this.lblVat.TabIndex = 17;
            this.lblVat.Text = "VAT (15%)";
            // 
            // chkVat
            // 
            this.chkVat.AutoSize = true;
            this.chkVat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkVat.Location = new System.Drawing.Point(126, 162);
            this.chkVat.Name = "chkVat";
            this.chkVat.Size = new System.Drawing.Size(15, 14);
            this.chkVat.TabIndex = 16;
            this.chkVat.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(14, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 43);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(126, 116);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(155, 23);
            this.dtpDate.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(694, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 37);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dvgDisplayOrder
            // 
            this.dvgDisplayOrder.AllowUserToAddRows = false;
            this.dvgDisplayOrder.AllowUserToDeleteRows = false;
            this.dvgDisplayOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDisplayOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Food,
            this.Quantity,
            this.Price,
            this.Delete});
            this.dvgDisplayOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgDisplayOrder.Location = new System.Drawing.Point(0, 214);
            this.dvgDisplayOrder.Name = "dvgDisplayOrder";
            this.dvgDisplayOrder.ReadOnly = true;
            this.dvgDisplayOrder.RowTemplate.Height = 25;
            this.dvgDisplayOrder.Size = new System.Drawing.Size(800, 236);
            this.dvgDisplayOrder.TabIndex = 12;
            this.dvgDisplayOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDisplayOrder_CellContentClick);
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "CategoryId";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Food
            // 
            this.Food.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Food.DataPropertyName = "Name";
            this.Food.HeaderText = "Food";
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            // 
            // panelOrderInfo
            // 
            this.panelOrderInfo.Controls.Add(this.btnAddOrder);
            this.panelOrderInfo.Controls.Add(this.numQuantity);
            this.panelOrderInfo.Controls.Add(this.lblQuantity);
            this.panelOrderInfo.Location = new System.Drawing.Point(354, 56);
            this.panelOrderInfo.Name = "panelOrderInfo";
            this.panelOrderInfo.Size = new System.Drawing.Size(434, 57);
            this.panelOrderInfo.TabIndex = 11;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddOrder.Location = new System.Drawing.Point(326, 9);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(88, 37);
            this.btnAddOrder.TabIndex = 12;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(103, 19);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(54, 23);
            this.numQuantity.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(6, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuantity.Size = new System.Drawing.Size(91, 43);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbFoods
            // 
            this.cmbFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoods.FormattingEnabled = true;
            this.cmbFoods.Location = new System.Drawing.Point(126, 77);
            this.cmbFoods.Name = "cmbFoods";
            this.cmbFoods.Size = new System.Drawing.Size(155, 23);
            this.cmbFoods.TabIndex = 3;
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(126, 35);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(155, 23);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // lblIteams
            // 
            this.lblIteams.AutoSize = true;
            this.lblIteams.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIteams.Location = new System.Drawing.Point(14, 68);
            this.lblIteams.Name = "lblIteams";
            this.lblIteams.Size = new System.Drawing.Size(69, 43);
            this.lblIteams.TabIndex = 1;
            this.lblIteams.Text = "Foods";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(14, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 43);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // FormTakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTakeOrder";
            this.Text = "Take Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTakeOrder_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayOrder)).EndInit();
            this.panelOrderInfo.ResumeLayout(false);
            this.panelOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIteams;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbFoods;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Panel panelOrderInfo;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dvgDisplayOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkVat;
        private System.Windows.Forms.Label lblVat;
    }
}