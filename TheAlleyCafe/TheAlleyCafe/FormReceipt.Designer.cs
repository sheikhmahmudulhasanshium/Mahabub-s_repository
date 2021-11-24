
namespace TheAlleyCafe
{
    partial class FormReceipt
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblGeneratedBy = new System.Windows.Forms.Label();
            this.lblOutPrice = new System.Windows.Forms.Label();
            this.lblOutDate = new System.Windows.Forms.Label();
            this.lblOutOrderId = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderId.Location = new System.Drawing.Point(17, 12);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(66, 20);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Order Id";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(637, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // panelReceipt
            // 
            this.panelReceipt.Controls.Add(this.lblEmployeeName);
            this.panelReceipt.Controls.Add(this.lblGeneratedBy);
            this.panelReceipt.Controls.Add(this.lblOutPrice);
            this.panelReceipt.Controls.Add(this.lblOutDate);
            this.panelReceipt.Controls.Add(this.lblOutOrderId);
            this.panelReceipt.Controls.Add(this.lblTotalPrice);
            this.panelReceipt.Controls.Add(this.dgvReceipt);
            this.panelReceipt.Controls.Add(this.lblDate);
            this.panelReceipt.Controls.Add(this.lblOrderId);
            this.panelReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelReceipt.Location = new System.Drawing.Point(0, 0);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(850, 310);
            this.panelReceipt.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(126, 42);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(117, 20);
            this.lblEmployeeName.TabIndex = 16;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblGeneratedBy
            // 
            this.lblGeneratedBy.AutoSize = true;
            this.lblGeneratedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeneratedBy.Location = new System.Drawing.Point(17, 42);
            this.lblGeneratedBy.Name = "lblGeneratedBy";
            this.lblGeneratedBy.Size = new System.Drawing.Size(101, 20);
            this.lblGeneratedBy.TabIndex = 15;
            this.lblGeneratedBy.Text = "Generated By";
            // 
            // lblOutPrice
            // 
            this.lblOutPrice.AutoSize = true;
            this.lblOutPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutPrice.Location = new System.Drawing.Point(99, 70);
            this.lblOutPrice.Name = "lblOutPrice";
            this.lblOutPrice.Size = new System.Drawing.Size(80, 20);
            this.lblOutPrice.TabIndex = 14;
            this.lblOutPrice.Text = "Total price";
            // 
            // lblOutDate
            // 
            this.lblOutDate.AutoSize = true;
            this.lblOutDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutDate.Location = new System.Drawing.Point(698, 14);
            this.lblOutDate.Name = "lblOutDate";
            this.lblOutDate.Size = new System.Drawing.Size(41, 20);
            this.lblOutDate.TabIndex = 13;
            this.lblOutDate.Text = "Date";
            // 
            // lblOutOrderId
            // 
            this.lblOutOrderId.AutoSize = true;
            this.lblOutOrderId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutOrderId.Location = new System.Drawing.Point(83, 12);
            this.lblOutOrderId.Name = "lblOutOrderId";
            this.lblOutOrderId.Size = new System.Drawing.Size(66, 20);
            this.lblOutOrderId.TabIndex = 11;
            this.lblOutOrderId.Text = "Order Id";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 70);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(80, 20);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Total price";
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Item,
            this.Quantity,
            this.Price});
            this.dgvReceipt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReceipt.Location = new System.Drawing.Point(0, 103);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowTemplate.Height = 25;
            this.dgvReceipt.Size = new System.Drawing.Size(850, 207);
            this.dgvReceipt.TabIndex = 6;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(850, 310);
            this.Controls.Add(this.panelReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReceipt";
            this.Text = "Order Receipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblOutPrice;
        private System.Windows.Forms.Label lblOutDate;
        private System.Windows.Forms.Label lblOutOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblGeneratedBy;
    }
}