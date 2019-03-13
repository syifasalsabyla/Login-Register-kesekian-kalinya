using belajarLoginLagi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace belajarLoginLagi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for SendGrid
            if (context.SendGrid.Any())
            {
                return;   // DB has been seeded
            }

            //initialize with empty SendGridUser and SendGridKey
            SendGrid sendGrid = new SendGrid();
            context.SendGrid.Add(sendGrid);
            context.SaveChanges();

        }
    }
}
