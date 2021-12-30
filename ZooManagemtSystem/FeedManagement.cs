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
    public partial class FeedManagement : Form
    {
        private DBHelper db = new DBHelper();
        private static FeedManagement instance;
        public static FeedManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new FeedManagement();
            }
            return instance;
        }
        public FeedManagement()
        {
            InitializeComponent();
        }

        private void FeedManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
        }
        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("动物编号", typeof(string));
            dt.Columns.Add("食物编号", typeof(string));
            dt.Columns.Add("职工编号", typeof(string));
            dt.Columns.Add("投喂时间", typeof(string));
            dt.Columns.Add("投食量", typeof(string));



            var sql = "select aid, wid,fid, time, total from Feed";
            SqlDataReader dr = db.ExecuteReader(sql);
            DateTime time = DateTime.Now;
            for (var i = 0; dr.Read(); i++)
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = dr["aid"];
                dt.Rows[i][1] = dr["wid"];
                dt.Rows[i][2] = dr["fid"];
                dt.Rows[i][3] = dr["time"];
                dt.Rows[i][4] = dr["total"];


            }

            dataGridView1.DataSource = dt;
        }

        private void Fe_sel_Click(object sender, EventArgs e)
        {
            var id = Aid.Text;
            var name = Wid.Text;
            var pwd = Fid.Text;
            var sex = Time.Text;
            var birth = Total.Text;
            
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
