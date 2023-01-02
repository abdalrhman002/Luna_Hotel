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
    public partial class open : Form
    {
        public open()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients= new Clients();
            clients.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms n=new Rooms();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log= new login();
            log.Show();
        }
    }
}
