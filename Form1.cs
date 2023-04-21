namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        long money = 0;
        long hotel = 0;
        long house = 0;
        long corporation =0;
        long skyScraper = 0;
        long bank = 0;
        long income = 1;



        public Form1()
        {
             InitializeComponent();
            //timer1.Tick +=EventHandler;
        }
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            income= hotel * 50 + house * 1 + corporation * 1000 + skyScraper * 50000 + bank * 100000000;
            money = money + income;
            money++; 
            lblMoney.Text = money.ToString();  
        }

        private void btnBuyHotel_Click(object sender, EventArgs e)
        {
            if (money >= 50)
            {
                money = money - 50;

                hotel++;
                lblQuantityOfHotel.Text = hotel.ToString();
                lblMoney.Text = money.ToString();
            }
        }

        private void btnBuyHouse_Click(object sender, EventArgs e)
        {
            if (money >= 10)
            {
                money = money - 10;

                house++;
                lblQuantityOfHouse.Text = house.ToString();
                lblMoney.Text = money.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyCorporation_Click(object sender, EventArgs e)
        {
            if (money >= 1000)
            {
                money = money - 1000;

                corporation++;
                lblCorporation.Text = corporation.ToString();
                lblMoney.Text = money.ToString();
            }
        }

        private void btnSkyScraper_Click(object sender, EventArgs e)
        {
            if (money >= 50000)
            {
                money = money - 50000;

                skyScraper++;
                lblQuantityOfSkyScraper.Text = skyScraper.ToString();
                lblMoney.Text = money.ToString();
            }
        }

        private void btnBuyBank_Click(object sender, EventArgs e)
        {
            if (money >= 1000000)
            {
                money = money - 1000000;

                bank++;
                lblQuantityOfBank.Text = bank.ToString();
                lblMoney.Text = money.ToString();
            }
        }
    }
}
