using System;
using System.Windows.Forms;

namespace TheAlleyCafe
{
    public partial class FormLogin : Form
    {
        private DataAccess DataAccess { set; get; }
        private FormHome FormHome { set; get; }
        public FormLogin()
        {
            InitializeComponent();
            this.DataAccess = new DataAccess();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Users WHERE Email = '" + this.txtUsername.Text + "' AND Password = '" + this.txtPassword.Text + "';";

                var ds = this.DataAccess.ExecuteQuery(sql);

                if (this.txtUsername.Text == "" || this.txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter all infromation!");
                }

                else if (ds.Tables[0].Rows.Count == 1)
                {
                    this.FormHome= new FormHome(this, ds.Tables[0].Rows[0]);
                    this.Visible = false;
                    this.FormHome.Visible = true;

                    this.txtUsername.Clear();
                    this.txtPassword.Clear();
                }
                else 
                {
                    MessageBox.Show("Invalid credentials");
                    this.txtPassword.Clear();
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Invalid credentials");

                this.txtUsername.Clear();
                this.txtPassword.Clear();
            }
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
