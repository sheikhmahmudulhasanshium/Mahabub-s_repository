
namespace TheAlleyCafe
{
    partial class UserControlDisplaySandwiches
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
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDisplaySandwiches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaySandwiches)).BeginInit();
            this.SuspendLayout();
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
            // dgvDisplaySandwiches
            // 
            this.dgvDisplaySandwiches.AllowUserToAddRows = false;
            this.dgvDisplaySandwiches.AllowUserToDeleteRows = false;
            this.dgvDisplaySandwiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplaySandwiches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice});
            this.dgvDisplaySandwiches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplaySandwiches.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplaySandwiches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDisplaySandwiches.Name = "dgvDisplaySandwiches";
            this.dgvDisplaySandwiches.ReadOnly = true;
            this.dgvDisplaySandwiches.RowHeadersWidth = 51;
            this.dgvDisplaySandwiches.RowTemplate.Height = 29;
            this.dgvDisplaySandwiches.Size = new System.Drawing.Size(774, 365);
            this.dgvDisplaySandwiches.TabIndex = 0;
            // 
            // UserContorlDisplaySandwiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDisplaySandwiches);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserContorlDisplaySandwiches";
            this.Size = new System.Drawing.Size(774, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaySandwiches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridView dgvDisplaySandwiches;
    }
}
