using Microsoft.EntityFrameworkCore;

public class labo8_1_serveurContext(DbContextOptions<labo8_1_serveurContext> options) : DbContext(options)
{
    public DbSet<labo8._1_serveur.Model.Item> Item { get; set; } = default!;
}
