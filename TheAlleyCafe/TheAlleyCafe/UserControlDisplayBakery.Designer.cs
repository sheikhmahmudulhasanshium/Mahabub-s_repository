
namespace TheAlleyCafe
{
    partial class UserControlDisplayBakery
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
            this.dgvDisplayBakery = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayBakery)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayBakery
            // 
            this.dgvDisplayBakery.AllowUserToAddRows = false;
            this.dgvDisplayBakery.AllowUserToDeleteRows = false;
            this.dgvDisplayBakery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayBakery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice});
            this.dgvDisplayBakery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayBakery.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplayBakery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDisplayBakery.Name = "dgvDisplayBakery";
            this.dgvDisplayBakery.ReadOnly = true;
            this.dgvDisplayBakery.RowHeadersWidth = 51;
            this.dgvDisplayBakery.RowTemplate.Height = 29;
            this.dgvDisplayBakery.Size = new System.Drawing.Size(774, 365);
            this.dgvDisplayBakery.TabIndex = 0;
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
            // UserContorlDisplayBakery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDisplayBakery);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserContorlDisplayBakery";
            this.Size = new System.Drawing.Size(774, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayBakery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayBakery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
    }
}
