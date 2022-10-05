using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace shoeStoree
{
    public partial class Form1 : Form
    {


        double jordan4Price = 397.21;
        double jordan1Price = 218;
        double jordan6Price = 192;

        //double taxAmmount = 1.13;
        //double total = 0;
        //double tendered = 0;
        //double change = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Jordan6Label_Click(object sender, EventArgs e)
        {

        }

        private void Jordan1Label_Click(object sender, EventArgs e)
        {

        }

        private void jordanLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {

            try
            {
                //SoundPlayer cash = new SoundPlayer(Properties.Resources.cash);
                //cash.Play();
                int jordan4 = Convert.ToInt32(jordan4Input.Text);
                int jordan1 = Convert.ToInt32(jordan1Input.Text);
                int jordan6 = Convert.ToInt32(Jordan6Input.Text);


                double totalJordan4 = jordan4 * jordan4Price;
                double totalJordan1 = jordan1 * jordan1Price;
                double totalJordan6 = jordan6 * jordan6Price;
                double subTotal = totalJordan4 + totalJordan1 + totalJordan6;
                double taxRate = 1.13;
                double total = subTotal * taxRate;
                double taxAmmount = total - subTotal;



                // doing calculations

                subtotalOutput.Text = $"Sub Total: {subTotal.ToString("0.00")}";
                TLabel.Text = $"Total: {total.ToString("0.00")}";
              taxOutput.Text = $" Tax: {taxAmmount.ToString("0.00")}";

                reciptLabel.Text = "SWEET!";


            }
            catch
            {
                reciptLabel.Text = "Please Enter Enough Money";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer cash = new SoundPlayer(Properties.Resources.cash);
            cash.Play();
            int jordan4 = Convert.ToInt32(jordan4Input.Text);
            int jordan1 = Convert.ToInt32(jordan1Input.Text);
            int jordan6 = Convert.ToInt32(Jordan6Input.Text);

            double totalJordan4 = jordan4 * jordan4Price;
            double totalJordan1 = jordan1 * jordan1Price;
            double totalJordan6 = jordan6 * jordan6Price;
            double subTotal = totalJordan4 + totalJordan1 + totalJordan6;
            double taxRate = 1.13;
            double total = subTotal * taxRate;
            double taxAmmount = total - subTotal;
            double tendered = Convert.ToDouble(tenderedInput.Text);
            double change = tendered - total;
            ChangeOutput.Text = $"Change: {change.ToString("0.00")}";
            reciptLabel.Text = $"Your change will be ${change.ToString("0.00")}";
            reciptLabel.Text += $"  Would you like a copy of the Receipt?";

        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            
            int jordan4 = Convert.ToInt32(jordan4Input.Text);
            int jordan1 = Convert.ToInt32(jordan1Input.Text);
            int jordan6 = Convert.ToInt32(Jordan6Input.Text);

            double totalJordan4 = jordan4 * jordan4Price;
            double totalJordan1 = jordan1 * jordan1Price;
            double totalJordan6 = jordan6 * jordan6Price;
            double subTotal = totalJordan4 + totalJordan1 + totalJordan6;
            double taxRate = 1.13;
            double total = subTotal * taxRate;
            double taxAmmount = total - subTotal;
            double tendered = Convert.ToDouble(tenderedInput.Text);
            double change = tendered - total;
            reciptLabel.BackColor = Color.Gray;
            reciptLabel.Text = $"          Simple Shoes\n\n order number 5760\n october 4, 2022\n\n Jordan 1's x{jordan1}            @{jordan1Price}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n Jordan 6's{jordan6}              @{jordan6Price}";
            reciptLabel.Text += $"\n Jordan 4's x{jordan4}           @{jordan4Price}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n\n Sub Total:                  {subTotal}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n Tax:                           {taxAmmount.ToString("0.00")}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n Total:                         {total}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n\n Tendered:                  {tendered.ToString("0.00")}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n Change:                     {change.ToString("0.00")}";
            Refresh();
            Thread.Sleep(15);
            reciptLabel.Text += $"\n\n Have A Great Day!\n Thank you for shopping.";

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            jordan1Input.Text = "";
            jordan4Input.Text = "";
            Jordan6Input.Text = "";
            reciptLabel.Text = "Welcome!";
            taxLabel.Text = "Tax:";
            totalLabel.Text = "Total:";
            subTotalLabel.Text = "Sub Total:";
            tenderedInput.Text = "";
            reciptLabel.Text = "";
            ChangeOutput.Text = "Change:";
            taxLabel.Text = "";
            TLabel.Text = "";
            subTotalLabel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reciptLabel.Text = $"you have canceled your order, have a great day";
            jordan1Input.Text = "";
            jordan4Input.Text = "";
            Jordan6Input.Text = "";
            reciptLabel.Text = "Welcome!";
            taxLabel.Text = "Tax:";
            totalLabel.Text = "Total:";
            subTotalLabel.Text = "Sub Total:";
            tenderedInput.Text = "";
            reciptLabel.Text = "";
            ChangeOutput.Text = "Change:";
            Application.Restart();
        }
    }
}
