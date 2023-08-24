using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entities.Models

{

    public class Invoice
    {
        public string UUID { get; set; }
        public string TaxNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceProfile { get; set; }
        public string InvoiceStatusDescription { get; set; }
        public string InvoiceType { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string CurrencyCode { get; set; }
        public decimal PayableAmount { get; set; }
        public string Alias { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverTaxNumber { get; set; }
        public string ReceiverAlias { get; set; }
        public bool IsPrint { get; set; }
        public List<Invoice> Content { get; set; }
    }

}
