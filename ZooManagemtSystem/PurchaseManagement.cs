using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ZooManagemtSystem
{
    public partial class PurchaseManagement : Form
    {
        private DBHelper db = new DBHelper();
        private static PurchaseManagement instance;
        public static PurchaseManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new PurchaseManagement();
            }
            return instance;
        }
        public PurchaseManagement()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("供应商编号", typeof(string));
            dt.Columns.Add("食物编号", typeof(string));
            dt.Columns.Add("职工编号", typeof(string));
            dt.Columns.Add("采购时间", typeof(string));
            dt.Columns.Add("花费金额", typeof(double));
            dt.Columns.Add("购买数量", typeof(double));
            var sql = "select sid , fid, wid, time ,cost ,number from  Purchase ";
            SqlDataReader dr = db.ExecuteReader(sql);
            for (var i = 0; dr.Read(); i++)
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = dr["sid"];
                dt.Rows[i][1] = dr["fid"];
                dt.Rows[i][2] = dr["wid"];
                dt.Rows[i][3] = dr["time"];
                dt.Rows[i][4] = dr["cost"];
                dt.Rows[i][5] = dr["number"];
              
            }
            dataGridView1.DataSource = dt;
        }

            private void PurchaseManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sid = te1.Text;
            var fid = te2.Text;
            var wid = te3.Text;
            var time = te4.Text;
            var cost = te5.Text;
            var number = te6.Text;
            if (string.IsNullOrEmpty(sid) ||
                string.IsNullOrEmpty(fid) ||
                string.IsNullOrEmpty(wid) ||
                string.IsNullOrEmpty(time) ||
                string.IsNullOrEmpty(cost) ||
                string.IsNullOrEmpty(number))
            {
                String sql = string.Format("insert into Staff(sid , fid, wid, time ,cost ,number) " +
 "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", sid, fid, wid, time, cost, number);
                bool flag = db.ExecuteNonQuery(sql);
                if (flag)
                {
                    LoadData();
                    MessageBox.Show("添加成功");
                }
                else
                    MessageBox.Show("添加失败");
            }
            else
                MessageBox.Show("不能输入null值");
        }
           
              
        

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
