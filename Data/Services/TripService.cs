using Trips.Data.Contracts;
using Trips.Data.Models;

namespace Trips.Data.Services{
    public class TripService : ITripService
    {
        public void CreateTrip(Trip trip)
        {
            int nextId = MockedData.GetAllTrips().Max(p=> p.Id) + 1;
            trip.Id = nextId;
            MockedData.GetAllTrips().Add(trip);
        }

        public void DeleteTrip(int id)
        {
            Trip trip = GetTripById(id);
            if (trip != null){
                MockedData.GetAllTrips().Remove(trip);
            }
        }

        public List<Trip> GetAllTrips()
        {
            return MockedData.GetAllTrips();
        }

        public Trip GetTripById(int id)
        {
            return MockedData.GetAllTrips().FirstOrDefault(p=> p.Id == id);
        }

        public void UpdateTrip(int id, Trip trip)
        {
            Trip oldTrip = GetTripById(id);
            if(oldTrip!=null){
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = trip.DateStarted;
                oldTrip.DateCompleted = trip.DateCompleted;
            }
        }
    }
}