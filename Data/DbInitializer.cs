using Lab3.Models;

namespace Lab3.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Rsvps
            if (context.Rsvps.Any())
            {
                return; // DB has been seeded
            }

            var rsvps = new Rsvp[]
            {
                new Rsvp {
                    FullName = "John Doe",
                    Email = "john@example.com",
                    Phone = "123-456-7890",
                    WorkshopTitle = "Routing Basics",
                    NeedsAccommodation = false
                },
                new Rsvp {
                    FullName = "Jane Smith",
                    Email = "jane@example.com",
                    Phone = "098-765-4321",
                    WorkshopTitle = "EF Core Intro",
                    NeedsAccommodation = true
                },
                new Rsvp {
                    FullName = "Bob Johnson",
                    Email = "bob@example.com",
                    Phone = "555-555-5555",
                    WorkshopTitle = "Razor Essentials",
                    NeedsAccommodation = false
                }
            };

            foreach (var rsvp in rsvps)
            {
                context.Rsvps.Add(rsvp); //adding to EF Core's "tracking list"
            }

            context.SaveChanges(); //database 
        }
    }
}