using System.Collections.Generic;

namespace HighLowArtist.Data
{
    public static class ArtistIds
    {
        //TODO fill this with a bunch of artist ids to select from since this wrapper doesn't allow random artist get request
        public static readonly Dictionary<int, string> Ids = new Dictionary<int, string>
        {
            {(int) ArtistEnum.Muse, "12Chz98pHFMPJEknJQMWvI"},
            {(int) ArtistEnum.RedHotChillPeppers, "0L8ExT028jH3ddEcZwqJJ5"},
            {(int) ArtistEnum.ImagineDragons, "53XhwfbYqKCa1cC15pYq2q"},
            {(int) ArtistEnum.LinkinPark, "6XyY86QOPPrYVGvF9ch6wz"},
            {(int) ArtistEnum.PanicAtTheDisco, "20JZFwl6HVl6yg8a4H3ZqK"},
            {(int) ArtistEnum.EdSheeran, "6eUKZXaKkcviH0Ku9w2n3V"},
            {(int) ArtistEnum.Joji, "3MZsBdqDrRTJihTHQrO6Dq"},
            {(int) ArtistEnum.BringMeTheHorizon, "1Ffb6ejR6Fe5IamqA5oRUF"},
            {(int) ArtistEnum.TwentyOnePilots, "3YQKmKGau1PzlVlkL1iodx"},
            {(int)ArtistEnum.TheMaine, "4o0pNHbyj36LPvukNqEug0"}
        };
    }
}