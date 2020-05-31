using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreAuditExample.Domain
{
    public class Transaction
    {
        public string FromIban { get; set; }
        public string ToIban { get; set; }
        public decimal Amount { get; set; }
    }
}
