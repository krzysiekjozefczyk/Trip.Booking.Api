using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Trips.Booking.Core.Entities;
using Trips.Booking.Infrastructure.Data;

namespace Trips.Booking.Infrastructure.Helpers
{
    public class SeedData
    {
        public static async Task SeedAsync(TripContext tripContext,ILoggerFactory loggerFactory)
        {
            try
            {
                if (!tripContext.Trips.Any() && !tripContext.Customers.Any())
                {
                    var trips = SeedTripData();
                    var customers = SeedCustomerData();

                    tripContext.Trips.AddRange(trips);
                    tripContext.Customers.AddRange(customers);

                    await tripContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            { 
                var logger = loggerFactory.CreateLogger<SeedData>();
                logger.LogError(ex.Message);
            }
        }

        private static List<Trip> SeedTripData()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = "Json";
            string fileName = "trips.json";
            string fullPath = Path.Combine(currentDirectory, path, fileName);

            var trips = new List<Trip>();
            using (StreamReader reader = new StreamReader(fullPath))
            {
                string json = reader.ReadToEnd();
                trips = JsonConvert.DeserializeObject<List<Trip>>(json);
            }

            return trips;
        }

        private static List<Customer> SeedCustomerData()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = "Json";
            string fileName = "customers.json";
            string fullPath = Path.Combine(currentDirectory, path, fileName);

            var customers = new List<Customer>();
            using (StreamReader reader = new StreamReader(fullPath))
            {
                string json = reader.ReadToEnd();
                customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            }

            return customers;
        }
    }
}
