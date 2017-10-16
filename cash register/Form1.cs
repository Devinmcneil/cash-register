using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_register
{
    public partial class Form1 : Form
    {
        //global constants
        const double HST = 0.13;
        const double BURGER_PRICE = 2.49;
        const double FRIES_PRICE = 1.89;
        const double DRINK_PRICE = 0.99;
        const double MEMES_PRICE = 2.00;
        //global variables
        int numBurgers = 0;
        int numFries = 0;
        int numDrinks = 0;
        int numMemes = 0;

        double tenderedAmount = 0;
        double subTotal, taxAmount, totalWithTax, change;

        private void tenderButton_Click(object sender, EventArgs e)
        {
            tenderedAmount = Convert.ToInt16(tenderedInput.Text);
            change = tenderedAmount - totalWithTax;
            changeTotal.Text = change.ToString("C");

        }

        public Form1()
        {
            InitializeComponent();

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Graphics fg = this.CreateGraphics();



           

            
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            numBurgers = Convert.ToInt16(burgerInput.Text);
            numFries = Convert.ToInt16(friesInput.Text);
            numDrinks = Convert.ToInt16(drinksInput.Text);
            numMemes = Convert.ToInt16(memeInput.Text);
  
            //do calculations
            subTotal = (numBurgers * BURGER_PRICE) * (numFries * FRIES_PRICE) * (numDrinks * DRINK_PRICE) * (numMemes * MEMES_PRICE);
            taxAmount = subTotal * HST;
            totalWithTax = subTotal + taxAmount;
            //output to labels 

            subTotalLabel.Text = subTotal.ToString("C");
            taxTotal.Text = taxAmount.ToString("C");
            totalLabel.Text = totalWithTax.ToString("C");
        }
    }
}
