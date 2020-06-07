using System;
using System.Collections.Generic;
using System.Text;

namespace WebChallenges.Domain.Models
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        // A name of an item e.g. eggs.
        public string Name { get; set; }
        // A number of bought items e.g. 10.
        public uint Count { get; set; }
        // A price of an item e.g. 20.5.
        public decimal Price { get; set; }
    }
}
