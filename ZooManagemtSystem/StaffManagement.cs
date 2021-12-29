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
    public partial class StaffManagement : Form
    {
        private DBHelper db  =new DBHelper();
        private static StaffManagement instance;
        public static StaffManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new StaffManagement();
            }
            return instance;
        }
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            LoadData(null);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
        }

        // 加载数据
        private void LoadData(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("编号", typeof(string));
            dt.Columns.Add("姓名", typeof(string));
            dt.Columns.Add("性别", typeof(string));
            dt.Columns.Add("职位", typeof(string));
            dt.Columns.Add("年龄", typeof(string));
            dt.Columns.Add("工资", typeof(string));
            dt.Columns.Add("密码", typeof(string));
            dt.Columns.Add("部门", typeof(string));

            var sql = "select [Worker].[id], [Worker].[name], [sex], [position], (YEAR(GETDATE()) - YEAR(birth)) as age, [wage], password, Department.name as dName from Worker join Department on did=Department.id";
            if(!string.IsNullOrEmpty(name))
            {
                sql = "select [Worker].[id], [Worker].[name], [sex], [position], (YEAR(GETDATE()) - YEAR(birth)) as age, [wage], password, Department.name as dName from Worker join Department on did=Department.id WHERE Worker.name={0}";
                sql = String.Format(sql, name);
            }
            SqlDataReader dr = db.ExecuteReader(sql);
            for (var i = 0; dr.Read(); i++)
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = dr["id"];
                dt.Rows[i][1] = dr["name"];
                dt.Rows[i][2] = dr["sex"];
                dt.Rows[i][3] = dr["position"];
                dt.Rows[i][4] = dr["age"];
                dt.Rows[i][5] = dr["wage"];
                dt.Rows[i][6] = dr["password"];
                dt.Rows[i][7] = dr["dName"];
            }

            dataGridView1.DataSource = dt;
        }

        //增加
        private void Bt_add_Click(object sender, EventArgs e)
        {
            var id = tb_id.Text;
            var name = tb_name.Text;
            var pwd = tb_pwd.Text;
            var sex = tb_sex.Text;
            var birth = dtp_birth.Value;
            var time = DateTime.Now;
            if (
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("内容不可以为空！");
                return;
            }
            else if ((time.Year - birth.Year) < 18)
            {
                MessageBox.Show("年龄小于18岁！");
                return;
            }

            if (string.IsNullOrWhiteSpace(id))
            {
                var sql = string.Format("insert into Staff(name, sex, birth, pwd, entry, position, salary) " +
                        "values('{0}', '{1}', '{2}', '{3}', GETDATE(), '员工', 3000)", name, sex, birth, pwd);
                bool flag = db.ExecuteNonQuery(sql);
                if (flag)
                {
                    LoadData(null);
                    MessageBox.Show("添加成功");
                }
                else
                    MessageBox.Show("添加失败");
            }
            else
            {
                var sql = string.Format("update Staff set name='{0}', pwd='{1}',sex='{2}', birth='{3}' where id={4}", name, pwd, sex, birth, id);
                bool flag = db.ExecuteNonQuery(sql);
                if (flag)
                {
                    LoadData(null);
                    MessageBox.Show("更新成功");
                }
                else
                    MessageBox.Show("更新失败");
            }
        }

        //修改
        private void Bt_up_Click(object sender, EventArgs e)
        {

        }

        //查询
        private void Bt_sel_Click(object sender, EventArgs e)
        {

        }

        //删除
        private void Bt_del_Click(object sender, EventArgs e)
        {

        }
    }
}
