
namespace TheAlleyCafe
{
    partial class UserControlDisplayDrinks
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
            this.dgvDisplayItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayItems
            // 
            this.dgvDisplayItems.AllowUserToAddRows = false;
            this.dgvDisplayItems.AllowUserToDeleteRows = false;
            this.dgvDisplayItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice});
            this.dgvDisplayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayItems.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplayItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDisplayItems.Name = "dgvDisplayItems";
            this.dgvDisplayItems.ReadOnly = true;
            this.dgvDisplayItems.RowHeadersWidth = 51;
            this.dgvDisplayItems.RowTemplate.Height = 29;
            this.dgvDisplayItems.Size = new System.Drawing.Size(774, 365);
            this.dgvDisplayItems.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemPrice.DataPropertyName = "Price";
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserContorlDisplayDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.dgvDisplayItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserContorlDisplayDrinks";
            this.Size = new System.Drawing.Size(774, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
    }
}
