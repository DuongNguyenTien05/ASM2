using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Customer
    {
        public string Name { get; set; }
        public double LastMonthReading { get; set; }
        public double ThisMonthReading { get; set; }
        public double Consumption {  get; set; }
        public string CustomerType { get; set; }
        
        public WaterBill GenerateWaterBill()
        {
            double billAmount = 0;
            const double PRICE_LEVEL_1 = 5.973;
            const double PRICE_LEVEL_2 = 7.052;
            const double PRICE_LEVEL_3 = 8.699;
            const double PRICE_LEVEL_4 = 15.929;
            const double PRICE_FOR_AGENCIES = 9.955;
            const double PRICE_FOR_PRODUCTION = 11.615;
            const double PRICE_FOR_BUSINESS = 22.068;

            switch (CustomerType)
            {
                case "Household":
                    if (Consumption <= 10)
                        billAmount = Consumption * PRICE_LEVEL_1;
                    else if (Consumption <= 20)
                        billAmount = (10 * PRICE_LEVEL_1) + ((Consumption - 10) * PRICE_LEVEL_2);
                    else if (Consumption <= 30)
                        billAmount = (10 * PRICE_LEVEL_1) + (10 * PRICE_LEVEL_2) + 
                            ((Consumption - 20) * PRICE_LEVEL_3);
                    else
                        billAmount = (10 * PRICE_LEVEL_1) + (10 * PRICE_LEVEL_2) + 
                            (10 * PRICE_LEVEL_3) + ((Consumption - 30) * PRICE_LEVEL_4);
                    break;
                case "Administrative agency, public services":
                    billAmount = PRICE_FOR_AGENCIES * Consumption;
                    break;
                case "Production units":
                    billAmount = PRICE_FOR_PRODUCTION * Consumption;
                    break;
                case "Business services":
                    billAmount = PRICE_FOR_BUSINESS * Consumption;
                    break;
            }

            return new WaterBill
            {
                BillAmount = Math.Round(billAmount, 3),
                EnvironmentalFee = Math.Round(billAmount * 0.1, 3),
                VatTax = Math.Round((billAmount + (billAmount * 0.1)) * 0.1, 3),
            };
        }
        
    }
    public class WaterBill
    {
        public double BillAmount { get; set; }
        public double EnvironmentalFee { get; set; }
        public double VatTax { get; set; }
        public double TotalPayment => Math.Round(BillAmount + EnvironmentalFee + VatTax, 3);
    }

    //static void Main()
    //{
    //    Application.EnableVisualStyles();
    //    Application.SetCompatibleTextRenderingDefault(false);
    //    Application.Run(new LoginForm());
    //}
}

