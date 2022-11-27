using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace FeverluxApp.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }
    }
}
