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
    public partial class Rooms : Form
    {
        public List<room> Hotel_rooms { get; set; }
        public Rooms()
        {
            Hotel_rooms = GetHotel_rooms();
            InitializeComponent();
        }

        private List<room>? GetHotel_rooms()
        {
            var list=new List<room>();
            list.Add(new room() {number="200",phone="0882772",stat="booked",client="Ahmed Ali"});
            list.Add(new room() { number = "200", phone = "0882772", stat = "booked", client = "Abdulla Ali" });
            list.Add(new room() { number = "201", phone = "0832772", stat = "free", client = "none" });
            list.Add(new room() { number = "202", phone = "0835772", stat = "booked", client = "metwaly" });
            list.Add(new room() { number = "203", phone = "0882772", stat = "free", client = "none" });
            list.Add(new room() { number = "204", phone = "0882772", stat = "free", client = "none" });
            list.Add(new room() { number = "205", phone = "0880772", stat = "booked", client = "Mogahed" });
            list.Add(new room() { number = "206", phone = "0812772", stat = "free", client = "none" });
            list.Add(new room() { number = "207", phone = "0882372", stat = "booked", client = "Gamal" });

            return list;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            var roooms = this.Hotel_rooms;
            dataGridView1.DataSource = roooms;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["number"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["stat"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["client"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            open op = new open();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                dataGridView1.CurrentRow.Cells["number"].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells["phone"].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells["stat"].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells["client"].Value = textBox2.Text;
            }
            else
            {
                MessageBox.Show("fill all cells.            ");
            }
        }
    }
    
}
