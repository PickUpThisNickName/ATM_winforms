namespace ATM_winforms
{
    public partial class MainForm : Form
    {
        public bool CardIn = false;
        ATM atm = new(
                new Dictionary<int, int>()
                {
                    { 50, 10},
                    { 100, 10 },
                    { 200, 10 },
                    { 500, 10 },
                    { 1000, 10 },
                    { 2000, 10 },
                    { 5000, 10 }
                },
                100,
                1500
            );

        public MainForm()
        {
            InitializeComponent();
            btn_balance.Enabled = false;
            btn_get.Enabled = false;
            btn_set.Enabled = false;
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            if (!CardIn)
            {
                btn_card.Text = "Достать карточку";
                CardIn = true;
                btn_balance.Enabled = true;
                btn_get.Enabled = true;
                btn_set.Enabled = true;
            }
            else
            {
                btn_card.Text = "Вставить карточку";
                CardIn = false;
                btn_balance.Enabled = false;
                btn_get.Enabled = false;
                btn_set.Enabled = false;

            }
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш баланс составляет " + atm.GetBalance() + "р");
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            GetForm form = new GetForm(atm);
            form.ShowDialog();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (atm.Limit() == 0)
            {
                MessageBox.Show("В данный момент внести деньги в банкомат невозможно, приносим свои извинения.");
                return;
            }
            SetForm form = new SetForm(atm);
            form.ShowDialog();
            atm = form._atm;
            bool ok = form.Ok;
            if (ok)
                MessageBox.Show("Операция прошла успешно, деньги зачислены на счет");
        }
    }
}