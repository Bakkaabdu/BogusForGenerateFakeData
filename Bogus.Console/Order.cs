using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogus.Console
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; } = string.Empty;
        public BillingDetails Detail { get; set; } = new();
    }

    public class BillingDetails
    {
        public string CostumerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
