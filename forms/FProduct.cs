using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.manager;

namespace WindowsFormsApplication1.forms
{
    public partial class FProduct : Form
    {
        private ProductEntity pe = new ProductEntity();
        private Image photo;

        public FProduct()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                pe.Connect("studio.db");
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
                pe.CleanTable();
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.Message;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            byte[] imageData = ConvertImageToByte();

            if (imageData == null)
            {
                MessageBox.Show("No image");
                return;
            }

            try
            {
                pe.InsertValues(tbName.Text, tbCategory.Text,
                    Convert.ToInt32(nudSize.Value), tbColor.Text,
                    imageData, nudPrice.Value);
            }
            catch (Exception ex)
            {
                tbLog.Text = ex.StackTrace;
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                pe.CreateTable();
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
                DataTable data = pe.GetAllData();
                //dataGridView1.DataSource = data;
                
                //tbLog.Text = ((int)data.Rows[0][6]).ToString();
                pictureBox2.Image = ConvertByteToImage((byte[])data.Rows[0][5]);

            }
            catch (Exception ex)
            {
                tbLog.Text = ex.StackTrace;
            }
        }

        private byte[] ConvertImageToByte()
        {
            if (photo == null)
            {
                MessageBox.Show("No image");
                return null;
            }

            MemoryStream ms = new MemoryStream();
            photo.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        private Image ConvertByteToImage(byte[] image)
        {
            //ImageConverter converter = new ImageConverter();
            //byte[] data = converter.ConvertTo(image, typeof(byte[])) as byte[];
            Stream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG files (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = photo;
            }
        }
    }
}
