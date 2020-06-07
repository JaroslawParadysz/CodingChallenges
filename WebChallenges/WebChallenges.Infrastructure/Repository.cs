using WebChallenges.Domain;
using System.Linq;

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
    }
}
