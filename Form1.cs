namespace ASM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out Customer customer)) return;

            var waterBill = customer.GenerateWaterBill();
            ListViewItem item = new ListViewItem
            {
                Text = customer.Name,
            };
            item.SubItems.Add(customer.LastMonthReading.ToString());
            item.SubItems.Add(customer.ThisMonthReading.ToString());
            item.SubItems.Add(customer.Consumption.ToString());
            item.SubItems.Add(customer.CustomerType);
            item.SubItems.Add(waterBill.BillAmount.ToString());
            item.SubItems.Add(waterBill.EnvironmentalFee.ToString());
            item.SubItems.Add(waterBill.VatTax.ToString());
            item.SubItems.Add(waterBill.TotalPayment.ToString());
            lsvWaterBill.Items.Add(item);
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvWaterBill.View = View.Details;
            lsvWaterBill.GridLines = true;
            lsvWaterBill.FullRowSelect = true;

            lsvWaterBill.Columns.Add("Customer Name", 200);
            lsvWaterBill.Columns.Add("Last month’s water meter readings", 200);
            lsvWaterBill.Columns.Add("This month’s water meter readings", 200);
            lsvWaterBill.Columns.Add("Amount of consumption", 200);
            lsvWaterBill.Columns.Add("Type of customer", 100);
            lsvWaterBill.Columns.Add("Water bill excluding tax (VND)", 100);
            lsvWaterBill.Columns.Add("Environmental protection fees 10% (VND)", 100);
            lsvWaterBill.Columns.Add("VAT tax 10% (VND)", 100);
            lsvWaterBill.Columns.Add("Total payment (VND)", 100);

        }


        private bool ValidateInput(out Customer customer)
        {
            customer = null;
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter your name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(tbLast.Text) || !double.TryParse(tbLast.Text, out double lastReading))
            {
                MessageBox.Show("Please enter Last month’s water meter readings", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(tbThis.Text) || !double.TryParse(tbThis.Text, out double thisReading))
            {
                MessageBox.Show("Please enter This month’s water meter readings", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (lastReading > thisReading)
            {
                MessageBox.Show("This month’s reading must be greater than last month’s reading.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string customerType = GetCustomerType();
            if (customerType == null)
            {
                MessageBox.Show("Please select a customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            customer = new Customer
            {
                Name = tbName.Text,
                LastMonthReading = lastReading,
                ThisMonthReading = thisReading,
                CustomerType = customerType,
                Consumption = thisReading - lastReading,
            };
            return true;
        }
        private string GetCustomerType()
        {
            if (rbHousehold.Checked)
                return "Household";
            else if (rbAdm.Checked)
                return "Administrative agency, public services";
            else if (rbPro.Checked)
                return "Production units";
            else if (rbBusiness.Checked)
                return "Business services";

            return null;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to edit?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                if (lsvWaterBill.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ListViewItem item = lsvWaterBill.SelectedItems[0];

                if (!ValidateInput(out Customer customer)) return;

                var waterBill = customer.GenerateWaterBill();

                lsvWaterBill.SelectedItems[0].Text = customer.Name;
                item.SubItems[1].Text = customer.LastMonthReading.ToString();
                item.SubItems[2].Text = customer.ThisMonthReading.ToString();
                item.SubItems[3].Text = customer.Consumption.ToString();
                item.SubItems[4].Text = customer.CustomerType;
                item.SubItems[5].Text = waterBill.BillAmount.ToString();
                item.SubItems[6].Text = waterBill.EnvironmentalFee.ToString();
                item.SubItems[7].Text = waterBill.VatTax.ToString();
                item.SubItems[8].Text = waterBill.TotalPayment.ToString();
                Text = customer.Name;
                ResetForm();
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                ResetForm();
                if (lsvWaterBill.SelectedItems.Count > 0)
                {
                    lsvWaterBill.Items.Remove(lsvWaterBill.SelectedItems[0]);
                }
            }

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to reset?", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                ResetForm();
                lsvWaterBill.Items.Clear();
            }
        }

        private void ResetForm()
        {
            tbName.Clear();
            tbLast.Clear();
            tbThis.Clear();

            rbHousehold.Checked = false;
            rbAdm.Checked = false;
            rbPro.Checked = false;
            rbBusiness.Checked = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = tbSearch.Text.ToLower();
            foreach (ListViewItem item in lsvWaterBill.Items)
            {
                bool match = item.SubItems.Cast<ListViewItem.ListViewSubItem>()
                                          .Any(subItem => subItem.Text.ToLower().Contains(searchQuery));
                item.BackColor = match ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                this.Close();
            }
        }
        
        private void btPrintBill_Click_1(object sender, EventArgs e)
        {
            if (lsvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvWaterBill.SelectedItems[0];
                FormPrint printbill = new FormPrint();
                printbill.Name = item.Text;
                printbill.LastMonthReading = item.SubItems[1].Text;
                printbill.ThisMonthReading = item.SubItems[2].Text;
                printbill.Consumption = item.SubItems[3].Text;
                printbill.CustomerType = item.SubItems[4].Text;
                printbill.BillAmount = item.SubItems[5].Text;
                printbill.EnvironmentalFee = item.SubItems[6].Text;
                printbill.VatTax = item.SubItems[7].Text;
                printbill.TotalPayment = item.SubItems[8].Text;
                printbill.Show();
            }
            else
            {
                MessageBox.Show("Please select a record to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvWaterBill.SelectedItems[0];
                tbName.Text = selectedItem.SubItems[0].Text;
                tbLast.Text = selectedItem.SubItems[1].Text;
                tbThis.Text = selectedItem.SubItems[2].Text;

                string type = selectedItem.SubItems[4].Text;
                if (type == "Household")
                    rbHousehold.Checked = true;
                else if (type == "Administrative agency, public services")
                    rbAdm.Checked = true;
                else if (type == "Production units")
                    rbPro.Checked = true;
                else if (type == "Business services")
                    rbBusiness.Checked = true;
            }
        }

        //private void btExit_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}

        private void tbThis_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btPrintBill_Click(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
