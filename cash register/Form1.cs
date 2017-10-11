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

        //global variables
        int numBurgers = 0;
        int numFries = 0;
        int numDrinks = 0;

        double subTotal, taxAmount, totalWithTax;

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
            numDrinks = Convert.ToInt16(drinksImput.Text);
       
            //do calculations

            //output to labels

        }
    }
}
