using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Form1 : Form
    {
        List<string> nameArray = new List<string>();
        List<string> branchArray = new List<string>();
        List<string> TypeArray = new List<string>();
        List<double> CurrBalanceArray = new List<double>();


        public Form1()
        {
            InitializeComponent();
            int x = nameArray.Count;
            AccountNoLabel.Text = $ "Account No : {x+1}";
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextbox.Text;
            string branch = BranchTextbox.Text;
            string type = AccountTypeTextbox.Text;
            double inidep = Convert.ToDouble(InitialDepositTextbox.Text);

            nameArray.Add(name);
            branchArray.Add(branch);
            TypeArray.Add(type);
            CurrBalanceArray.Add(inidep);

            NameTextbox.Text.Clear();
            BranchTextbox.Text.Clear();
            AccountTypeTextbox.Text.Clear();
            InitialDepositTextbox.Text.Clear();
        }











    }

}
       