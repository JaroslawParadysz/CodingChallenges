using WebChallenges.Domain;
using System.Linq;
using System.Collections.Generic;
using System;

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

        public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
        {
            var result = _webChallengesContext.Invoices
                .Where(x => (from == null || x.CreationDate >= from) && (to == null || x.CreationDate <= to))
                .Select(x => new { Numer = x.Number, Count = x.InvoiceItems.Sum(x => x.Count) })
                .AsEnumerable()
                .GroupBy(x => x.Numer, x => x.Count)
                .ToDictionary(x => x.Key, y => y.Sum());

            return result;
        }

    }
}
