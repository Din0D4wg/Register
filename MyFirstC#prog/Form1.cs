using System.Data.SqlClient;


namespace MyFirstC_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Empty = false;
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is TextBox)
                {
                    if (string.IsNullOrEmpty(cntrl.Text))
                    {
                        Empty = true;
                        break;
                    }
                }
                else if (cntrl is ComboBox)
                {
                    if (((ComboBox)cntrl).SelectedIndex == -1)
                    {
                        Empty = true;
                        break;
                    }
                }
                }
                if (Empty)
                {
                    MessageBox.Show("Please fill out all boxes");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-7F3G16L\\SQLEXPRESS;Initial Catalog=registrationform;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();
                    string insertQuery = "INSERT INTO register VALUES (@fname, @lname, @email, @age, @gender, @phone, @username, @password)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                    cmd.Parameters.AddWithValue("email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@age", txtage.Text);
                    cmd.Parameters.AddWithValue("@gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("register successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
    }

