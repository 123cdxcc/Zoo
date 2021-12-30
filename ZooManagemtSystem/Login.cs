using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZooManagemtSystem
{
    public partial class Login : Form
    {
        private static Login instance;
        public static Login GetInstance()
        {
            if (instance == null)
            {
                instance = new Login();
            }
            return instance;
        }
        private DBHelper db;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            db = new DBHelper();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Home.GetInstance().Show();
            string usernmae = tb_username.Text;
            string password = tb_password.Text;
            SqlDataReader dr = null;

            string sql = "select name from Worker where id={0} and password='{1}'";
            sql = String.Format(sql, usernmae, password);

            dr = db.ExecuteReader(sql);

            if (dr.Read())
            {
                var name = dr["name"].ToString().Trim();
                if (!String.IsNullOrEmpty(name))
                {
                    Hide();
                    Home.GetInstance().Show();
                }
                else
                {
                    MessageBox.Show("账号或密码错误!");
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误!");
            }
            dr.Close();
        }

    }
}
