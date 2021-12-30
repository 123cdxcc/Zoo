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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnimalManagement_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {

        }
    }
}
