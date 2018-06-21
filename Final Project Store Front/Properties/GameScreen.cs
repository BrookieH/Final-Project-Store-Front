using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Final_Project_Store_Front.Properties
{
    public partial class GameScreen : UserControl
    {
        List<Flower> Inventory = new List<Flower>();
        int rose = 10;
        int tulip = 15;
        int lily = 7;

        string flower0 = "Rose";
        string flower1 = "Tulip";
        string flower2 = "lily";

        int[] flowers = { 10, 15, 7 };


        //ints for all order amounts
        const double tax = 0.13;
        const double ROSE_COST = 5.00;
        int roseNumber = 0;
        const double LILIES_COST = 4.00;
        int lilyNumber = 0;
        const double TULIPS_COST = 3.00;
        int tulipNumber = 0;
        const double ROSE12_COST = 45.00;
        int rose12Number = 0;
        const double LILIES12_COST = 40.00;
        int lily12Number = 0;
        const double TULIP12_COST = 35.00;
        int tulip12Number = 0;
        const double BOUTONNIERE1_COST = 10.00;
        int boutonniere1 = 0;
        const double BOUTONNIERE2_COST = 28.00;
        int boutonniere2 = 0;
        const double CORSAGE1_COST = 12.00;
        int corsage1 = 0;
        const double CORSAGE2_COST = 31.00;
        int corsage2 = 0;
        const double BOUQUET1_COST = 22.00;
        int bouquet1 = 0;
        const double BOUQUET2_COST = 41.00;
        int bouquet2 = 0;
        const double BOUQUET3_COST = 82.00;
        int bouquet3 = 0;
        string discount = "";
        string promoCode = "Save10";
        int guessRose = 0;
        int guessLily = 0;
        int guessTulip = 0;

        //doubles for all prices
        double subTotal = 0;
        double taxTotal = 0;
        double total = 0;
        double totalwPromo = 0;

        public GameScreen()
        {
            InitializeComponent();
            Refresh();
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            #region designs
            //Brushes
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush greenBrush = new SolidBrush(Color.MintCream);
            SolidBrush purpleBrush = new SolidBrush(Color.Lavender);


            //Pens
            Pen GreenPen = new Pen(Color.GreenYellow, 3);

            //Rectangle
            e.Graphics.FillRectangle(blackBrush, 550, 0, 320, 270);
            e.Graphics.FillRectangle(whiteBrush, 550, 250, 320, 270);

            //Flower

            e.Graphics.FillEllipse(greenBrush, 350, 130, 34, 34);
            e.Graphics.FillEllipse(greenBrush, 395, 130, 34, 34);
            e.Graphics.FillEllipse(greenBrush, 373, 106, 34, 34);
            e.Graphics.FillEllipse(greenBrush, 373, 154, 34, 34);
            e.Graphics.FillEllipse(purpleBrush, 379, 135, 27, 27);
            #endregion Designs

            //putting list on screen


        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Open = new SoundPlayer(Properties.Resources.Checkout);
            Open.Play();
            //converting to integer
            roseNumber = Convert.ToInt16(roseBox.Text);
            lilyNumber = Convert.ToInt16(lilyBox.Text);
            tulipNumber = Convert.ToInt16(tulipBox.Text);
            rose12Number = Convert.ToInt16(rose12Box.Text);
            lily12Number = Convert.ToInt16(lily12Box.Text);
            tulip12Number = Convert.ToInt16(tulip12Box.Text);
            boutonniere1 = Convert.ToInt16(boutonniere1Box.Text);
            boutonniere2 = Convert.ToInt16(boutonniere2Box.Text);
            corsage1 = Convert.ToInt16(corsage1Box.Text);
            corsage2 = Convert.ToInt16(corsage2Box.Text);
            bouquet1 = Convert.ToInt16(bouquet1Box.Text);
            bouquet2 = Convert.ToUInt16(bouquet2Box.Text);
            bouquet3 = Convert.ToUInt16(bouquet3Box.Text);
            discount = (codeBox.Text);

            #region List 
            //Transer object to read list
            if (roseNumber > 0)
            {
                Flower f = new Flower("rose", roseNumber);
                Inventory.Add(f);
            }
            if (lilyNumber > 0)
            {
                Flower f = new Flower("lily", lilyNumber);
                Inventory.Add(f);
            }
            if (tulipNumber > 0)
            {
                Flower f = new Flower("tulip", tulipNumber);
                Inventory.Add(f);
            }
            if (rose12Number > 0)
            {
                Flower f = new Flower("12 roses", rose12Number);
                Inventory.Add(f);
            }
            if (lily12Number > 0)
            {
                Flower f = new Flower("12 lilies", lily12Number);
                Inventory.Add(f);
            }
            if (tulip12Number > 0)
            {
                Flower f = new Flower("12 tulips", tulip12Number);
                Inventory.Add(f);
            }
            if (boutonniere1 > 0)
            {
                Flower f = new Flower("boutonniere", boutonniere1);
                Inventory.Add(f);
            }
            if (boutonniere2 > 0)
            {
                Flower f = new Flower(" 3 flower boutonniere", boutonniere2);
                Inventory.Add(f);
            }
            if (corsage1 > 0)
            {
                Flower f = new Flower("corsage", corsage1);
                Inventory.Add(f);
            }
            if (corsage2 > 0)
            {
                Flower f = new Flower("3 flower corsage", corsage2);
                Inventory.Add(f);
            }
            if (bouquet1 > 0)
            {
                Flower f = new Flower("bouquet", bouquet1);
                Inventory.Add(f);
            }
            if (bouquet2 > 0)
            {
                Flower f = new Flower(" 12 flower bouquet", bouquet2);
                Inventory.Add(f);
            }
            if (bouquet3 > 0)
            {
                Flower f = new Flower(" 24 flower bouquet", bouquet3);
                Inventory.Add(f);
            }
            #endregion

            #region calculating
            //calculating
            subTotal = roseNumber * ROSE_COST + lilyNumber * LILIES_COST + tulipNumber * TULIPS_COST + rose12Number * ROSE12_COST + lily12Number * LILIES12_COST + tulip12Number * TULIP12_COST + boutonniere1 * BOUTONNIERE1_COST + boutonniere2 * BOUTONNIERE2_COST + corsage1 * CORSAGE1_COST + corsage2 * CORSAGE2_COST + bouquet1 * BOUQUET1_COST + bouquet2 * BOUQUET2_COST + bouquet3 * BOUQUET3_COST;
            taxTotal = subTotal * tax;
            total = subTotal + taxTotal;

            totalOutcomeLabel.Text = subTotal.ToString("C");
            totalWithTaxLabel.Text = taxTotal.ToString("C");
            veryTotalLabel.Text = total.ToString("C");

            if (promoCode == discount) //discount calculate
            {
                totalwPromo = subTotal * .9;
                totalDiscountLabel.Text = totalwPromo.ToString("C");
                taxTotal = totalwPromo * tax;
                totalWithTaxLabel.Text = taxTotal.ToString("C");
                total = totalwPromo + taxTotal;
                taxTotal = totalwPromo + tax;
                veryTotalLabel.Text = total.ToString("C");
                totalwPromoLabel.Text = "you got 10% off";
                discountLabel.Text = "Discount Total";
            }
            else //If discount code is wrong
            {
                totalwPromoLabel.Text = "Code not Vaild";
                totalDiscountLabel.Text = "";
                discountLabel.Text = "";
            }

            //list on screen
            listLabel.Text = "";
            foreach (Flower f in Inventory)
            {
                listLabel.Text += f.type + " " + f.amount + "\n";
            }

            #endregion        

            #region inventory hints
            //player input at checkout
            if (roseNumber > 10)
            {
                totalwPromoLabel.Text = "Don't have enough roses in inventory";
                veryTotalLabel.Text = "Error in order ";
            }

            if (tulipNumber > 15)
            {
                totalwPromoLabel.Text = "Don't have enough tulips in inventory";
                veryTotalLabel.Text = "Error in order ";
            }
            if (lilyNumber > 7)
            {
                totalwPromoLabel.Text = "Don't have enough lilies in inventory";
                veryTotalLabel.Text = "Error in order ";
            }
            if (rose12Number > 0)
            {
                totalwPromoLabel.Text = "Don't have enough roses in inventory";
                veryTotalLabel.Text = "Error in order ";
            }
            if (lily12Number > 0)
            {
                totalwPromoLabel.Text = "Don't have enough lilies in inventory";
                veryTotalLabel.Text = "Error in order ";
            }
            if (tulip12Number > 1)
            {
                totalwPromoLabel.Text = "Don't have enough tulips in inventory";
                veryTotalLabel.Text = "Error in order ";
            }
            #endregion
        }


        private void guessButton_Click(object sender, EventArgs e)
        {

            //Guess Game
            guessRose = Convert.ToInt16(totalRoseBox.Text);
            guessLily = Convert.ToInt16(totalLilyBox.Text);
            guessTulip = Convert.ToInt16(totalTulipBox.Text);

            //guessing game
            if (guessRose == 10 && guessLily == 7 && guessTulip == 15)
            {
                guessOutputLabel.Text = "correct guess, use code SAVE10";
            }
            else
            {
                guessOutputLabel.Text = "wrong guess, refresh and try again";
            }
        }

        private void refeshButton_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Open = new SoundPlayer(Properties.Resources.Refresh);
            Open.Play();
            //clearing text for new order
            veryTotalLabel.Text = "";
            totalwPromoLabel.Text = "";
            discountLabel.Text = "";
            totalWithTaxLabel.Text = "";
            totalDiscountLabel.Text = "";
            totalOutcomeLabel.Text = "";
            guessOutputLabel.Text = "";
            totalRoseBox.Text = "";
            totalLilyBox.Text = "";
            totalTulipBox.Text = "";
            listLabel.Text = "";
            codeBox.Text = "";
            roseBox.Text = "";
            lilyBox.Text = "";
            tulipBox.Text = "";
            rose12Box.Text = "";
            lily12Box.Text = "";
            tulip12Box.Text = "";
            boutonniere1Box.Text = "";
            boutonniere2Box.Text = "";
            corsage1Box.Text = "";
            corsage2Box.Text = "";
            bouquet1Box.Text = "";
            bouquet2Box.Text = "";
            bouquet3Box.Text = "";
            totalRoseBox.Text = "";
            totalLilyBox.Text = "";
            totalTulipBox.Text = "";

            //clearing variables for new order
            roseNumber = 0;
            lilyNumber = 0;
            tulipNumber = 0;
            rose12Number = 0;
            lily12Number = 0;
            tulip12Number = 0;
            boutonniere1 = 0;
            boutonniere2 = 0;
            corsage1 = 0;
            corsage2 = 0;
            bouquet1 = 0;
            bouquet2 = 0;
            bouquet3 = 0;
        }
    }
}
