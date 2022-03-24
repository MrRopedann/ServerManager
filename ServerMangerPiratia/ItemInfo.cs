using ServerManagerPiratia.Cunstruct;
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
            myTextBox1.Text = filename;
            string[] listItem = ReadFile.ReadTxtFile(filename);
            for (int i = 0; i < listItem.Length; i++)
            {
                string[] testitem = listItem[i].Split('\t');
                try
                {
                    dataGridView1.Rows.Add(testitem[0], testitem[1]);
                }
                catch { IndexOutOfRangeException ex; }
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(myTextBox2.Text))
                            {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
        }
    }
}
