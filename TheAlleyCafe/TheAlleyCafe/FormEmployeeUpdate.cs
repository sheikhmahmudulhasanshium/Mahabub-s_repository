using System;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormEmployeeUpdate : Form
    {
        private DataAccess DataAccess { set; get; }
        public FormEmployeeUpdate()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Users WHERE Id = '" + this.txtSearch.Text + "' ;";
            var ds = this.DataAccess.ExecuteQuery(sql);
            this.dgvSearched.AutoGenerateColumns = false;
            this.dgvSearched.DataSource = ds.Tables[0];
        }
        private void dgvSearched_DoubleClick(object sender, EventArgs e)
        {
            this.panelSearchEmployee.Controls.Clear();
            var columns = this.dgvSearched.CurrentRow.Cells;
            UserControlUpdateEmployees userControlUpdateEmployees = new UserControlUpdateEmployees(this,columns);
            this.panelSearchEmployee.Controls.Add(userControlUpdateEmployees);
            
        }
    }
}
