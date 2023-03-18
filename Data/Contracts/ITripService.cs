using Trips.Data.Models;

namespace Trips.Data.Contracts{
    public interface ITripService{
        List<Trip> GetAllTrips();
        Trip GetTripById(int id);
        void CreateTrip(Trip trip);
        void DeleteTrip(int id);
        void UpdateTrip(int id, Trip trip);
    }
}