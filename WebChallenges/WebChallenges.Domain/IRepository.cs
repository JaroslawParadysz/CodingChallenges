using System;
using System.Collections.Generic;

namespace WebChallenges.Domain
{
    public interface IRepository
    {
        decimal? GetTotal(int invoiceId);
        decimal GetTotalOfUnpaid();
        IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to);
    }
}
