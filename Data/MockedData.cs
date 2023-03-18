using Trips.Data.Models;

namespace Trips.Data{
    public static class MockedData{
        private static List<Trip> allTrips = new List<Trip>(){
            new Trip(){
                Id=1,
                Name="Ostern Ferien",
                Description="Wir gehen für 10 Tagen nach Serbien",
                DateStarted = new DateTime(2023,4,9)
            },
            new Trip(){
                Id=2,
                Name="Sommerferien",
                Description="Das ist noch nicht definiert",
                DateStarted = new DateTime(2023, 7, 10)
            }
        };

        public static List<Trip> GetAllTrips() { return allTrips;}
    }
}