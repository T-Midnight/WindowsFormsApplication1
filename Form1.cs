using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using WindowsFormsApplication1.forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnOpenFStorage_Click(object sender, EventArgs e)
        {
            FStorage fStorage = new FStorage();
            fStorage.ShowDialog();
        }

        private void btnOpenFProduct_Click(object sender, EventArgs e)
        {
            FProduct fProduct = new FProduct();
            fProduct.ShowDialog();
        }
    }
}
