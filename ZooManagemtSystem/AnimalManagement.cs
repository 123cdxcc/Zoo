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
    }
}
