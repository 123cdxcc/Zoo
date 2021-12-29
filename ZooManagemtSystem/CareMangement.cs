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
    public partial class CareMangement : Form
    {
        private static CareMangement instance;
        public static CareMangement GetInstance()
        {
            if (instance == null)
            {
                instance = new CareMangement();
            }
            return instance;
        }
        public CareMangement()
        {
            InitializeComponent();
        }
    }
}
