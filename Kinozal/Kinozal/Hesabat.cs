using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinozal
{
    public partial class Hesabat : Form
    {
      
        public Hesabat()
        {
            InitializeComponent();
            foreach (Button item in Oturacaqlar.ReservedSeats)
            {
                Yersecimi.Text += item.Text + " ,";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void NeticeBtn_Click(object sender, EventArgs e)
        {
            var result = "Salam, " + NameBox.Text + " " + SurnameBox.Text + ". Siz " + Yersecimi.Text +"\r\n" + " yerleri reserv etmisiniz ve odeyeceyiniz mebleg " + "\r\n" + Oturacaqlar.ReservedSeats.Count * 5 + " AZN-dir.Enjoy your life (bacarirsansa)";
            netice.Text += result;
        }
    }
}
