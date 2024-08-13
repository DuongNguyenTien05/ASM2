using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ASM2
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public string Name { get; set; }
        public string LastMonthReading { get; set; }
        public string ThisMonthReading { get; set; }
        public string Consumption { get; set; }
        public string CustomerType { get; set; }
        public string BillAmount { get; set; }
        public string EnvironmentalFee { get; set; }
        public string VatTax { get; set; }
        public string TotalPayment { get; set; }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            lbCustomerName.Text = Name;

            lbLastMonthReading.Text = LastMonthReading;
            lbThisMonthReading.Text = ThisMonthReading;
            lbConsumption.Text = Consumption;
            lbCustomerType.Text = CustomerType;
            lbBillAmount.Text = BillAmount;
            lbEnvironmentalFee.Text = EnvironmentalFee;
            lbVatTax.Text = VatTax;
            lbTotalPayment.Text = TotalPayment;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
