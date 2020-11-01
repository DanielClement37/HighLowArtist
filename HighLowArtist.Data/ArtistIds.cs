using System.Collections.Generic;

namespace HighLowArtist.Data
{
    public class ArtistIds
    {
        //TODO fill this with a bunch of artist ids to select from since this wrapper doesn't allow random artist get request
        public static Dictionary<int, string> Ids = new Dictionary<int, string>
        {
            {(int) ArtistEnum.Muse, "12Chz98pHFMPJEknJQMWvI"},
            {(int) ArtistEnum.RedHotChillPeppers, "0L8ExT028jH3ddEcZwqJJ5"}
        };
    }
}