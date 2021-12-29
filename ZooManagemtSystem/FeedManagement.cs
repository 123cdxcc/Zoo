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
    public partial class FeedManagement : Form
    {
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
    }
}
