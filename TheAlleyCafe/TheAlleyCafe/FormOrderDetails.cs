
using System.Data;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormOrderDetails : Form
    {
        private DataAccess DataAccess { set; get; }
        private DataTable Table { set; get; }
        public FormOrderDetails()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
            this.PopulateGridView();
        }

        public void PopulateGridView(string sql = "SELECT * FROM OrdersView;")
        {
            var ds = this.DataAccess.ExecuteQuery(sql);
            this.Table = ds.Tables[0];
            this.dgvOrderDetails.AutoGenerateColumns = false;
            this.dgvOrderDetails.DataSource = this.Table;
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrderDetails.Columns["Details"].Index)
            {
                var orderId = int.Parse(this.Table.Rows[e.RowIndex]["OrderId"].ToString());

                FormReceipt formReceipt = new FormReceipt(orderId);
                formReceipt.Visible = true;
            }
        }
    }
}
