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
    public partial class Oturacaqlar : Form
    {
      
        public int yuxaridan_asagi = 4;
        public int soldan_saga = 11;
        public int top = 120;
        public int left = 180;
        public int oturacaq_sayi = 1;
        

        public int LeftPos = 0;
        public int TopPos = 0;
        public int SeatNumber = 1;
        public TextBox Result = new TextBox();
        public Button ReservBtn = new Button();
        public static List<Button> ReservedSeats = new List<Button>();




        public Oturacaqlar()
        {

            for (int row = 0; row < yuxaridan_asagi; row++)
            {
                for (int column = 0; column < soldan_saga; column++)
                {
                   
                        var seat = new Button();

                        seat.Width = 50;
                        seat.Height = 50;
                        seat.Left = LeftPos;
                        seat.Top = TopPos;
                        seat.Text = SeatNumber.ToString();
                        SeatNumber++;
                        Controls.Add(seat);
                        seat.Click += new EventHandler(SelectSeats);
                        LeftPos += 55;
                   
                }
                LeftPos = 0;
                TopPos +=50;

                var Sehne = new Button();

                Sehne.Width = 200;
                Sehne.Height = 30;
                Sehne.Top = 300;
                Sehne.Left = 200;
                Controls.Add(Sehne);


            }

            this.Width = yuxaridan_asagi * 150 + 17;
            this.Height = soldan_saga * 50 + 100;
            ReservBtn.Text = "Reserve";
            ReservBtn.AutoSize = true;
            ReservBtn.Click += new EventHandler(ReserveSeats);
            Controls.Add(ReservBtn);
            ReservBtn.Top = this.Height - ReservBtn.Height - 70;
            ReservBtn.Left = this.Width - ReservBtn.Width - 300;
            
            
         
        }
        public void SelectSeats(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Green;
            ReservedSeats.Add(btn);


        }

        public void ReserveSeats(object obj, EventArgs e)
        {
            foreach (Button item in ReservedSeats)
            {
                item.Enabled = false;
            }
            var Hesabati_Goster = new Hesabat();
            Hesabati_Goster.Show();


        }
    }
}
      