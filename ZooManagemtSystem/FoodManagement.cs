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
    public partial class FoodManagement : Form
    {
        private DBHelper db = new DBHelper();
        private static FoodManagement instance;
        public static FoodManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new FoodManagement();
            }
            return instance;
        }
        public FoodManagement()
        {
            InitializeComponent();
        }

        private void FoodManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
        }
        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("食物编号", typeof(string));
            dt.Columns.Add("保质期", typeof(string));
            dt.Columns.Add("食物名称", typeof(string));
            dt.Columns.Add("生产日期", typeof(string));
            dt.Columns.Add("生产总量", typeof(string));



            var sql = "select id, name,(YEAR(GETDATE()) - YEAR(birth)) as total, birth, expirationDate from Food";
            SqlDataReader dr = db.ExecuteReader(sql);
            DateTime time = DateTime.Now;
            for (var i = 0; dr.Read(); i++)
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = dr["id"];
                dt.Rows[i][1] = dr["name"];
                dt.Rows[i][2] = dr["total"];
                dt.Rows[i][3] = dr["birth"];
                dt.Rows[i][4] = dr["expirationDate"];


            }

            dataGridView1.DataSource = dt;
        }

        private void Fd_add_Click(object sender, EventArgs e)
        {
            var id = Fid.Text;
            var name = Fdata.Text;
            var pwd = Fname.Text;
            var sex = Fbirth.Text;
            var birth = Ftotal.Text;
            var time = DateTime.Now;
            if (
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("内容不可以为空！");
                return;
            }
           
        }
    }
}
