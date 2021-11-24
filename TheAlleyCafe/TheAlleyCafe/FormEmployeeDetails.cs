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
    public partial class FormEmployeeDetails : Form
    {
        private DataAccess DataAccess { set; get; }
        private DataTable Table { set; get; }
        public FormEmployeeDetails()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
            this.PopulateGridView();
        }


        public void PopulateGridView(string sql = "SELECT * FROM Users;")
        {
            var ds = this.DataAccess.ExecuteQuery(sql);
            this.Table = ds.Tables[0];
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.DataSource = this.Table;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployees.Columns["Delete"].Index)
            {
                var id = int.Parse(this.Table.Rows[e.RowIndex]["Id"].ToString());
                FormEmployeeDelete formEmployeeDelete = new FormEmployeeDelete(this,id);
                formEmployeeDelete.Visible = true;
            }
        }
    }
}
