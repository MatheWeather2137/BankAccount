namespace BankAccount
{
    public partial class Form1 : Form
    {
        private BankAccount account;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.account = new BankAccount(Convert.ToInt32(nmrBalance.Value));
            lstOperations.Items.Clear();
            groupBox2.Enabled = true;
            UpdateBalanse();
            lstOperations.Items.Add($"Utworzono konto z warto�ci� pocz�tkow� {lblBalance.Text}");
            groupBox1.Enabled = false;
        }
        private void UpdateBalanse()
        {
            if (account != null)
            {
                lblBalance.Text = account.GetBalance().ToString("0");
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            OperationResultDto result = account.Deposit(Convert.ToInt32(nmrDonate.Value));
            UpdateBalanse();
            lstOperations.Items.Add(result.Message);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            OperationResultDto result = account.Withdraw(Convert.ToInt32(nmrWithdraw.Value));
            UpdateBalanse();
            lstOperations.Items.Add(result.Message);
            if(Convert.ToInt32(lblBalance.Text) <= Convert.ToInt32(nmrWithdraw.Value))
            {
                MessageBox.Show("Brak �rodk�w", "tytul okna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
