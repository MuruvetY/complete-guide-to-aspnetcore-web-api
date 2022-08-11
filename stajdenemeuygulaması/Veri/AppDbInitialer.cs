using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using stajdenemeuygulaması.Veri.Modell;
using System.Linq;

namespace stajdenemeuygulaması.Veri
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Sinif.Any()) 
                {
                    context.Sinif.AddRange(new Sinif()
                    {
                        Id = 1,
                        name = "Leanne Graham",
                        username = "Bret",
                        email = "Sincere@april.biz",
                        adress =
                        {
                            street =  "Kulas Light",
                            suite = "Apt. 556",
                            city = "Gwenborough",
                            zipcode =  "92998-3874",

                          geo =
                            {
                                lat = "-37.3159",
                                lng = "81.1496"

                            }
                        },
                        phone = 1 - 770 - 736 - 8031 x56442,
                        website = "hildegard.org",
                        company =
                        {
                            name = "Romeguera-Crona",
                            catchPhrase = "Multi-layered client-server neural-net",
                            bs = "harness real-time e-markets"
                        }



                    });

                    
                }
            }
        }
    }
}
