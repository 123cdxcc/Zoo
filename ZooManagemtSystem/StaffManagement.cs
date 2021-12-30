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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadData(null);
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

            var sql = "select [Worker].[id], [Worker].[name], [sex], [position], birth as age, [wage], password, Department.name as dName from Worker join Department on did=Department.id";
            if(!string.IsNullOrEmpty(name))
            {
                sql = "select [Worker].[id], [Worker].[name], [sex], [position], birth as age, [wage], password, Department.name as dName from Worker join Department on did=Department.id WHERE Worker.name={0}";
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
                var age = DateTime.Now.Year - DateTime.Parse(dr["age"].ToString()).Year;
                dt.Rows[i][4] = age;
                dt.Rows[i][5] = dr["wage"];
                dt.Rows[i][6] = dr["password"];
                dt.Rows[i][7] = dr["dName"];
            }

            dataGridView1.DataSource = dt;
        }

        //增加
        private void Bt_add_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_name.Text))
            {
                MessageBox.Show("名字不可以为空");
            }
            else
            {
                SqlDataReader dr = null;
                var findIdByDepartment = "select id from department where name='{0}'";
                findIdByDepartment = string.Format(findIdByDepartment, tb_department.Text);
                dr = db.ExecuteReader(findIdByDepartment);
                if (dr.Read())
                { 
                    var sql = "INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('{0}', '{1}', '{2}', '{3}', {4}, '{5}', {6})";
                    sql = string.Format(sql, tb_name.Text, tb_sex.Text, tb_pos.Text, dtp_birth.Value.ToString(), tb_wage.Text, tb_pwd.Text, dr["id"]);
                    if (db.ExecuteNonQuery(sql))
                    {
                        MessageBox.Show("添加成功");
                        LoadData(null);
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                else
                {
                    MessageBox.Show("添加失败,请检查部门是否正确");
                }
                
            }
        }

        //修改
        private void Bt_up_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("职工编号不可以为空");
            }
            else
            {
                SqlDataReader dr = null;
                var findIdByDepartment = "select id from department where name='{0}'";
                findIdByDepartment = string.Format(findIdByDepartment, tb_department.Text);
                dr = db.ExecuteReader(findIdByDepartment);
                if (dr.Read())
                {
                    var sql = "update Worker set name='{0}',sex='{1}',position='{2}',birth='{3}',wage='{4}',[password]='{5}',did='{6}' where id={7}";
                    sql = string.Format(sql, tb_name.Text, tb_sex.Text, tb_pos.Text, dtp_birth.Value.ToString(), tb_wage.Text, tb_pwd.Text, dr["id"], tb_id.Text);
                    if (db.ExecuteNonQuery(sql))
                    {
                        LoadData(null);
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    MessageBox.Show("修改失败，请检查部门");
                }
            }
        }

        //查询
        private void Bt_sel_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("员工编号不可以为空");
            }
            else
            {
                var sql = "select [Worker].[id], [Worker].[name], [sex], [position], birth as age, [wage], password, Department.name as dName from Worker join Department on did=Department.id where Worker.id={0}";
                sql = string.Format(sql, tb_id.Text);
                SqlDataReader dr = db.ExecuteReader(sql);
                if(dr.Read())
                {
                    tb_name.Text = dr["name"].ToString();
                    tb_sex.Text = dr["sex"].ToString();
                    tb_pos.Text = dr["position"].ToString();
                    var age = DateTime.Parse(dr["age"].ToString());
                    dtp_birth.Value = age;
                    tb_wage.Text = dr["wage"].ToString();
                    tb_pwd.Text = dr["password"].ToString();
                    tb_department.Text = dr["dName"].ToString();
                }
            }
            
        }

        //删除
        private void Bt_del_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("员工编号不可以为空");
            }
            else
            {
                var sql = "delete Worker where id={0}";
                sql = string.Format(sql, tb_id.Text);
                if (db.ExecuteNonQuery(sql))
                {
                    LoadData(null);
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            var id = row.Cells["编号"].Value.ToString();
            var name = row.Cells["姓名"].Value.ToString();
            var sex = row.Cells["性别"].Value.ToString();
            var position = row.Cells["职位"].Value.ToString();
            var birth = row.Cells["年龄"].Value.ToString();
            var wage = row.Cells["工资"].Value.ToString();
            var password = row.Cells["密码"].Value.ToString();
            var department = row.Cells["部门"].Value.ToString();

            tb_id.Text = id;
            tb_name.Text = name;
            tb_sex.Text = sex;
            tb_pos.Text = position;

            var sql = "select birth from Worker where id=" + tb_id.Text;
            SqlDataReader dr = db.ExecuteReader(sql);
            if(dr.Read()) dtp_birth.Value = DateTime.Parse(dr["birth"].ToString());

            tb_wage.Text = wage;
            tb_pwd.Text = password;
            tb_department.Text = department;

        }
    }
}
