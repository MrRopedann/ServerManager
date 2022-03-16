using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManagerPiratia
{
    public partial class ItemInfo : Form
    {
        public ItemInfo()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            //string fileText = System.IO.File.ReadAllText(filename);
            myTextBox1.Text = filename;

        }
    }
}
