using Microsoft.EntityFrameworkCore;
using System;
using WebChallenges.Domain.Models;

namespace WebChallenges.Infrastructure
{
    public class WebChallengesContext : DbContext
    {
        public WebChallengesContext(DbContextOptions<WebChallengesContext> options) : base(options)
        {
        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }
}
