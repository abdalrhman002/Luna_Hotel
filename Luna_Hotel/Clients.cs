using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Hotel
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textname.Text.Length > 0 && textage.Text.Length > 0 && textroom.Text.Length > 0 && textin.Text.Length > 0 && textout.Text.Length > 0)
            {
                dataGridView1.Rows.Add(textname.Text,textage.Text,textroom.Text,textin.Text,textout.Text);
                textout.Clear();
                textin.Clear();
                textroom.Clear();
                textage.Clear();
                textname.Clear();

            }
            else
            {
                MessageBox.Show("fill all cells.            ");
            }
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textname.Text.Length > 0 && textage.Text.Length > 0 && textroom.Text.Length > 0 && textin.Text.Length > 0 && textout.Text.Length > 0)
            {
                dataGridView1.CurrentRow.Cells["name"].Value = textname.Text;
                dataGridView1.CurrentRow.Cells["age"].Value = textage.Text;
                dataGridView1.CurrentRow.Cells["room"].Value = textroom.Text;
                dataGridView1.CurrentRow.Cells["indate"].Value = textin.Text;
                dataGridView1.CurrentRow.Cells["outdate"].Value = textout.Text;
            }
            else
            {
                MessageBox.Show("fill all cells.            ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textname.Text = dataGridView1.CurrentRow.Cells["name"].ToString();
                textage.Text = dataGridView1.CurrentRow.Cells["age"].ToString();
                textroom.Text = dataGridView1.CurrentRow.Cells["room"].ToString();
                textin.Text = dataGridView1.CurrentRow.Cells["indate"].ToString();
                textout.Text = dataGridView1.CurrentRow.Cells["outdate"].ToString();
            }
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow !=null)
            {
                textname.Text = dataGridView1.CurrentRow.Cells["name"].ToString();
                textage.Text = dataGridView1.CurrentRow.Cells["age"].ToString();
                textroom.Text = dataGridView1.CurrentRow.Cells["room"].ToString();
                textin.Text = dataGridView1.CurrentRow.Cells["indate"].ToString();
                textout.Text = dataGridView1.CurrentRow.Cells["outdate"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            open op=new open();
            op.Show();
        }

        private void button1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_LocationChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textname.Text = dataGridView1.CurrentRow.Cells["name"].ToString();
                textage.Text = dataGridView1.CurrentRow.Cells["age"].ToString();
                textroom.Text = dataGridView1.CurrentRow.Cells["room"].ToString();
                textin.Text = dataGridView1.CurrentRow.Cells["indate"].ToString();
                textout.Text = dataGridView1.CurrentRow.Cells["outdate"].ToString();
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textname.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                textage.Text = dataGridView1.CurrentRow.Cells["age"].Value.ToString();
                textroom.Text = dataGridView1.CurrentRow.Cells["room"].Value.ToString();
                textin.Text = dataGridView1.CurrentRow.Cells["indate"].Value.ToString();
                textout.Text = dataGridView1.CurrentRow.Cells["outdate"].Value.ToString();
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            
        }
    }
}
