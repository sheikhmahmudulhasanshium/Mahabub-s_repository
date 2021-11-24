using System;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormEmployeeAdd : Form
    {
        private DataAccess DataAccess { set; get; }
        //private FormEmployee FormEmployee { set; get; }
        public FormEmployeeAdd()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();

        }
        private void btnAdd_Click(object sender, EventArgs e)
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
                    var sql = "INSERT INTO Users VALUES('" + this.txtName.Text + "', " +
                        "'" + this.txtGender.Text + "', '" + this.txtEmail.Text + "', '" + this.txtPassword.Text + "', '" + this.txtRole.Text + "', '" + this.txtContact.Text + "', " +
                        "'" + this.rchAddress.Text + "', '" + this.dtpDate.Value.ToString("yyyy-MM-dd") + "');";

                    int count = this.DataAccess.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Employee Added!");
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed!");
                    }
                    this.Hide();
                    FormEmployee formEmployee = new FormEmployee();
                    formEmployee.Show();
                }
                catch (Exception error){}
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            this.Hide();
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.Show();
        }
    }
}
