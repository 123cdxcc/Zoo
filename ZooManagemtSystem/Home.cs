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
    public partial class Home : Form
    {
        private static Home instance;
        public static Home GetInstance()
        {
            if (instance == null)
            {
                instance = new Home();
            }
            return instance;
        }
        public Home()
        {
            InitializeComponent();
        }

       

        private void Staff_Click(object sender, EventArgs e)
        {
            StaffManagement.GetInstance().Show();
        }

        private void Animal_Click(object sender, EventArgs e)
        {
            AnimalManagement.GetInstance().Show();
        }

        private void Food_Click(object sender, EventArgs e)
        {
            FoodManagement.GetInstance().Show();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            FeedManagement.GetInstance().Show();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            PurchaseManagement.GetInstance().Show();
        }

        private void Care_Click(object sender, EventArgs e)
        {
            CareMangement.GetInstance().Show();
        }
    }
}
