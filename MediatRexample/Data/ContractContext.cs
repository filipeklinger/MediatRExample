using Microsoft.EntityFrameworkCore;

namespace MediatRexample.Data
{
    //Classe somente de Exemplo não é necessario para uso do MediatR
    public class ContractContext : DbContext
    {
        public ContractContext(DbContextOptions<ContractContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Contact>().HasData(
                new Contact { Id= 1, FirstName = "Steve", LastName = "Micheloti"},
                new Contact { Id = 2, FirstName = "Bill", LastName = "Gattes" },
                new Contact { Id = 3, FirstName = "Satina", LastName = "NaDela" }
                );
        }

        public class Contact
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}