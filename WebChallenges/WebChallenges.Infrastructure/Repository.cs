using WebChallenges.Domain;
using System.Linq;
using System.Collections.Generic;

namespace WebChallenges.Infrastructure
{
    public class Repository : IRepository
    {
        private readonly WebChallengesContext _webChallengesContext;

        public Repository(WebChallengesContext webChallengesContext)
        {
            _webChallengesContext = webChallengesContext;
        }

        public decimal? GetTotal(int invoiceId)
        {
            return _webChallengesContext.InvoiceItems
                .Where(x => x.InvoiceId == invoiceId)
                .Sum(x => x.Price * x.Count);
        }

        public decimal GetTotalOfUnpaid()
        {
            decimal result = _webChallengesContext.Invoices.Where(x => x.AcceptanceDate == null)
                .SelectMany(x => x.InvoiceItems.Select(x => x.Count * x.Price)).Sum();
            return result;
        }
    }
}
