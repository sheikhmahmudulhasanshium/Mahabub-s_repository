using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormReceipt : Form
    {
        private DataAccess DataAccess { set; get; }
        private DataTable OrdersTable { set; get; }
        private DataTable OrdersItemsTable { set; get; }
        private int OrderId { set; get; }
        private int EmployeeId { set; get; }
        public FormReceipt()
        {
            InitializeComponent();
        }
        public FormReceipt(int orderId)
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
            this.OrderId = orderId;

            this.OrdersTable =  this.PopulateGridView("SELECT * FROM OrdersView WHERE OrderId='" + orderId + "';");
            this.OrdersItemsTable =  this.PopulateGridView("SELECT * FROM OrdersItemsView WHERE OrderId=" + orderId + ";");
        }

        public DataTable PopulateGridView(string sql)
        {
            var ds = this.DataAccess.ExecuteQuery(sql);
            return ds.Tables[0];
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            this.lblOutOrderId.Text = this.OrdersTable.Rows[0]["OrderId"].ToString();
            this.lblOutPrice.Text = this.OrdersTable.Rows[0]["Price"].ToString();
            this.lblOutDate.Text = this.OrdersTable.Rows[0]["Date"].ToString();
            this.lblEmployeeName.Text = this.OrdersTable.Rows[0]["EmployeeName"].ToString();

            this.dgvReceipt.AutoGenerateColumns = false;
            this.dgvReceipt.DataSource = this.OrdersItemsTable;
        }
    }
}
