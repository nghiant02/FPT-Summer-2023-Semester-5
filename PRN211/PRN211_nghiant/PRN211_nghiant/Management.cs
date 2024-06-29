using Repository.Models;
using Repository.Services;

namespace PRN211_nghiant
{
    public partial class Management : Form
    {
        List<Student> liststudent = new List<Student>();
        BankAccountServices _bankAccountServices = new BankAccountServices();
        UserServices _userServices = new UserServices();
        BankAccountTypeContext _bankAccountTypeContext = new BankAccountTypeContext();


        public Management()
        {
            InitializeComponent();
            var listBankAccount = _bankAccountServices.GetAll();
            BankAccountServices bankAccountRepo = new BankAccountServices();
            AccountTypeServices accountTypeRepo = new AccountTypeServices();
            var listCombo = accountTypeRepo.GetAll().Select(p => new { p.TypeId, p.TypeName }).ToList();
            cbBox.DisplayMember = "TypeName";
            cbBox.ValueMember = "TypeID";
            cbBox.DataSource = listCombo;

            dgvListStudent.DataSource = new BindingSource { DataSource = listBankAccount};
        }

        private void dgvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccountID.Enabled = false;

            var id = dgvListStudent[0, e.RowIndex].Value;
            var bankAccount = _bankAccountServices.GetAll().Where(p => p.AccountId.Equals(id)).FirstOrDefault();
            if (bankAccount != null)
            {
                txtAccountID.Text = bankAccount.AccountId;
                txtAccountName.Text = bankAccount.AccountName;
                txtBranchName.Text = bankAccount.BranchName;
                cbType.SelectedValue = bankAccount.TypeId;
                //dtpOpenDate.Value = bankAccount.OpenDate.Value;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}



