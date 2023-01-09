using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_winforms
{
    public partial class GetCash : Form
    {
        public ATM _atm;
        private readonly int _amount;
        public bool ok = false;
        public bool getcash = false;
        Dictionary<int, int> toIssue = new Dictionary<int, int>();

        public GetCash(ATM atm, int amount, bool orderAscending)
        {
            InitializeComponent();
            _atm = atm;
            _amount = amount;

            getcash = _atm.GetCash(ref toIssue, amount, orderAscending);
            if (getcash)
            {
                foreach (var nominal in toIssue.Keys)
                {
                    if (toIssue[nominal] != 0)
                    {
                        ListViewItem item = new ListViewItem(new string[] { nominal.ToString(), toIssue[nominal].ToString() });
                        listView1.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Невозможно выдать введенную сумму!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _atm.DecrementATM(ref toIssue);
            ok = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
