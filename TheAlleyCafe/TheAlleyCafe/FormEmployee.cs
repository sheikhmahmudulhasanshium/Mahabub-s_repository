using System;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormEmployee : Form
    {
        private FormHome FormHome { set; get; }
        public FormEmployee()
        {
            InitializeComponent();
        }
        public FormEmployee(FormHome formHome)
        {
            InitializeComponent();
            this.FormHome = formHome;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployeeAdd formEmployeeAdd = new FormEmployeeAdd();
            formEmployeeAdd.Show();
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployeeUpdate formEmployeeUpdate = new FormEmployeeUpdate();
            formEmployeeUpdate.Show();
        }
        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            FormEmployeeDetails formEmployeeDetails = new FormEmployeeDetails();
            formEmployeeDetails.Visible = true;
        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormHome.Visible = true;
            this.Visible = false;
        }
    }
}
