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
    public partial class Filmler : Form
    {
        public static IEnumerable<Button> ReservedSeats { get; internal set; }

        public Filmler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Filmler_Load(object sender, EventArgs e)
        {

        }

        private void biletqiymeti_Click(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void filmsec_Click(object sender, EventArgs e)
        {
            Oturacaqlar biletqiymeti = new Oturacaqlar();
            biletqiymeti.Show();
        }
    }
}
