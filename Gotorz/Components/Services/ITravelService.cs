using Gotorz.Components.Models;

namespace Gotorz.Components.Services
{
    public interface ITravelService
    {
        Task<List<TravelPackage>> SearchTravelPackagesAsync(string from, string to, DateTime departureDate, DateTime returnDate);
    }
}
