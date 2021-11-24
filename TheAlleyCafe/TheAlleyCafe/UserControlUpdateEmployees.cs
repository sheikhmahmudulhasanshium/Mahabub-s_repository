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
    public partial class UserControlUpdateEmployees : UserControl
    {
        private DataGridViewCellCollection Columns { set; get; }
        private DataAccess DataAccess { set; get; }
        private FormEmployeeUpdate FormEmployeeUpdate { set; get; }
        private FormEmployee FormEmployee { set; get; }
        public UserControlUpdateEmployees()
        {
            InitializeComponent();
        }
        public UserControlUpdateEmployees(FormEmployeeUpdate formEmployeeUpdate, DataGridViewCellCollection columns)
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
            this.FormEmployeeUpdate = formEmployeeUpdate;
            this.Columns = columns;
        }
        private void UserControlUpdateEmployees_Load(object sender, EventArgs e)
        {
            this.txtName.Text = this.Columns["EmployeeName"].Value.ToString();
            this.txtGender.Text = this.Columns["Gender"].Value.ToString();
            this.txtEmail.Text = this.Columns["Email"].Value.ToString();
            this.txtPassword.Text = this.Columns["Password"].Value.ToString();
            this.txtRole.Text = this.Columns["Role"].Value.ToString();
            this.txtContact.Text = this.Columns["ContactNo"].Value.ToString();
            this.rchAddress.Text = this.Columns["Address"].Value.ToString();
            this.dtpDate.Value = Convert.ToDateTime(this.Columns["JoiningDate"].Value.ToString());
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "" || this.txtGender.Text == "" || this.txtEmail.Text == "" || this.txtRole.Text == "" || this.txtContact.Text == "" || this.rchAddress.Text == "")
            {
                MessageBox.Show("Please enter all information!");
                this.Hide();
                FormEmployee formEmployee = new FormEmployee();
                formEmployee.Show();
            }
            else
            {
                try
                {
                    var sql = "UPDATE Users SET Name='" + this.txtName.Text + "', Gender='" + this.txtGender.Text + "'," +
                        " Email='" + this.txtEmail.Text + "', Password='" + this.txtPassword.Text + "', " +
                        "Role='" + this.txtRole.Text + "', ContactNo='" + this.txtContact.Text + "'," +
                        " Address='" + this.rchAddress.Text + "', JoiningDate='" + dtpDate.Value.ToString() + "'WHERE Id = '" + this.Columns["Id"].Value.ToString() + "';"; ;

                    this.DataAccess.ExecuteUpdateQuery(sql);

                    MessageBox.Show("Employee updated successfully");

                    FormEmployee formEmployee = new FormEmployee();
                    formEmployee.Show();
                    this.FormEmployeeUpdate.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.Show();
            this.FormEmployeeUpdate.Close();
        }
    }
}
