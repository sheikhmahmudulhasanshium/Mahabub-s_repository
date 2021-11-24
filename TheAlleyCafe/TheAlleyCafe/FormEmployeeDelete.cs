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
    public partial class FormEmployeeDelete : Form
    {
        private DataAccess DataAccess { set; get; }

        private FormEmployeeDetails FormEmployeeDetails { set; get; }
        private int EmployeeId { set; get; }
        public FormEmployeeDelete()
        {
            InitializeComponent();
        }
        public FormEmployeeDelete(FormEmployeeDetails formEmployeeDetails ,int employeeId)
        {
            InitializeComponent();
            this.FormEmployeeDetails = formEmployeeDetails;
            this.EmployeeId = employeeId;
            this.DataAccess = new DataAccess();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var sql = "DELETE FROM Users WHERE Id = '"+ this.EmployeeId + "'";
            this.DataAccess.ExecuteQuery(sql);
            this.FormEmployeeDetails.PopulateGridView();
            this.Visible = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
