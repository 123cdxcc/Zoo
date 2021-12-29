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
    public partial class PurchaseManagement : Form
    {
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
    }
}
