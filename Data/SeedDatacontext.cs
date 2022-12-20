using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OpdrachtFrameworks.Data
{
    public class SeedDatacontext
    {
            
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService

            <DbContextOptions<ApplicationDbContext>>()))
            {
                context.Database.EnsureCreated();    // Zorg dat de databank bestaat



                if (!context.Immo.Any())
                {
                    context.Immo.AddRange(

                        new Models.Immo
                        {
                            naam = "x",
                            straat = "dd",
                            description = "fdsfsd",
                            huisnummer = 8,
                            gemeente = 12458,
                            prijs = 1,
                            bouwjaar = 1909,
                            kamers = 4,
                            grootte = 90,
                            tuin = "zz",
                            type = "kdjf"
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Klant.Any())
                {
                    context.Klant.AddRange(

                        new Models.Klant
                        {
                            naam = "x",
                            straat = "dd",
                            huisnummer = 8,
                            email = "souf"

                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Facture.Any())
                {
                    context.Facture.AddRange(

                        new Models.Facture
                        {
                            naam = "x",
                            prijs = 50

                        }
                    );
                    context.SaveChanges();
                }






            }
        }
    }
}
