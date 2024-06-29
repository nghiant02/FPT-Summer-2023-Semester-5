using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_SU22_TuilaTui
{
    public partial class ManagementForm : Form
    {
        public static User _User = Form1._USER;
        BankAccountRepository BankAccountRepo;
        AccountTypeRepository AccountTypeRepo;
        public ManagementForm()
        {
            InitializeComponent();

             BankAccountRepo = new BankAccountRepository();
            AccountTypeRepo = new AccountTypeRepository();



            var listCombo = AccountTypeRepo.GetAll().Select(p => new { p.TypeId, p.TypeName }).ToList();

            cbType.DisplayMember = "TypeName";
            cbType.ValueMember = "TypeId";

            cbType.DataSource = listCombo;


            var listAccountBank = BankAccountRepo.GetAll().Include(p=>p.Type).Select(p=>new {p.AccountId,p.AccountName,
                    p.OpenDate,p.BranchName,p.Type.TypeName}).ToList();
            dataGridView1.DataSource = listAccountBank.ToList();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var BranchName = txtSearch.Text.ToString();

            var AccountRepo = new RepositoryBase<BankAccount>();
            var ListAccount = AccountRepo.GetAll().Where(p => p.BranchName.Contains(BranchName)).ToList();

            dataGridView1.DataSource = ListAccount;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccountID.Enabled = false;

            var id = dataGridView1[0,e.RowIndex].Value;
            var bankAccount = BankAccountRepo.GetAll().Where(p => p.AccountId.Equals(id)).FirstOrDefault();
            if (bankAccount!=null)
            {
                txtAccountID.Text = bankAccount.AccountId;
                txtAccountName.Text = bankAccount.AccountName;
                txtBranchName.Text = bankAccount.BranchName;

                cbType.SelectedValue=bankAccount.TypeId;

                dtpOpenDate.Value = bankAccount.OpenDate.Value;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var bankAccount = BankAccountRepo.GetAll().Where(p => p.AccountId.Equals(txtAccountID.Text)).FirstOrDefault();

            bankAccount.AccountName = txtAccountName.Text;
            bankAccount.BranchName = txtBranchName.Text;
            bankAccount.OpenDate = dtpOpenDate.Value;

            bankAccount.TypeId = cbType.SelectedValue.ToString();

            BankAccountRepo.Update(bankAccount);


            var listAccountBank = BankAccountRepo.GetAll().Include(p => p.Type).Select(p => new {
                p.AccountId,
                p.AccountName,
                p.OpenDate,
                p.BranchName,
                p.Type.TypeName
            }).ToList();

            dataGridView1.DataSource = new BindingSource(){ DataSource=listAccountBank};
        }
    }
}
