﻿#nullable disable

namespace Repository.Models
{
    public partial class BankAccount
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? OpenDate { get; set; }
        public string BranchName { get; set; }
        public string TypeId { get; set; }

        public virtual AccountType Type { get; set; }
    }
}
