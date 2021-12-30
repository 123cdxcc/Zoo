using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagemtSystem
{
    public partial class AnimalManagement : Form
    {
        private static AnimalManagement instance;
        public static AnimalManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalManagement();
            }
            return instance;
        }
        public AnimalManagement()
        {
            InitializeComponent();
        }

        private void AnimalManagement_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            //INSERT INTO Animal(name, species, birth, sex, [state]) values('王八苏', '乌龟', '2000-1-1', '雌', '健康')
            DataTable dt = new DataTable();
            dt.Columns.Add("编号", typeof(string));
            dt.Columns.Add("姓名", typeof(string));
            dt.Columns.Add("性别", typeof(string));
            dt.Columns.Add("职位", typeof(string));
            dt.Columns.Add("年龄", typeof(string));
            dt.Columns.Add("工资", typeof(string));
            dt.Columns.Add("密码", typeof(string));
            dt.Columns.Add("部门", typeof(string));
        }
    }
}
