using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.manager;

namespace WindowsFormsApplication1.forms
{
    public partial class FStorage : Form
    {
        private StorageEntity se = new StorageEntity();

        public FStorage()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                se.Connect("studio.db");
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.Message;
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                se.CreateTable();
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.Message;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            try
            {
                se.CleanTable();
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.Message;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(tbDateReceipt.Text.Equals(""))
            {
                MessageBox.Show("Date field is empty");
                return;
            }


            try
            {
                se.InsertValues(tbDateReceipt.Text, Convert.ToInt32(nudQuantity.Value));
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.Message;
            }
        }

        private void btnAllData_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = se.GetAllData();
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.Message;
            }
        }
    }
}
