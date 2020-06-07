namespace WebChallenges.Domain
{
    public interface IRepository
    {
        decimal? GetTotal(int invoiceId);
        decimal GetTotalOfUnpaid();
    }
}
