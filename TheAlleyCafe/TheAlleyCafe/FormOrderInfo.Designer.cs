
namespace TheAlleyCafe
{
    partial class FormOrderInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderInformation));
            this.panelOrder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.MintCream;
            this.panelOrder.Controls.Add(this.label1);
            this.panelOrder.Controls.Add(this.btnDetails);
            this.panelOrder.Controls.Add(this.btnTakeOrder);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(970, 448);
            this.panelOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 85);
            this.label1.TabIndex = 8;
            this.label1.Text = "Central Perk";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetails.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetails.ForeColor = System.Drawing.Color.MintCream;
            this.btnDetails.Location = new System.Drawing.Point(532, 196);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(322, 109);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Order details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeOrder.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeOrder.ForeColor = System.Drawing.Color.MintCream;
            this.btnTakeOrder.Location = new System.Drawing.Point(127, 196);
            this.btnTakeOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(322, 109);
            this.btnTakeOrder.TabIndex = 0;
            this.btnTakeOrder.Text = "Take order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // FormOrderInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 448);
            this.Controls.Add(this.panelOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrderInformation";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderInformation_FormClosing);
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Label label1;
    }
}