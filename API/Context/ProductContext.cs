using System.Data.Entity;

public class ProductContext : DbContext
{
    public ProductContext(string connectionString) : base(connectionString)
    { }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<BidEntity> Bids { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
