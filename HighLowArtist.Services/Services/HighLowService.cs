using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighLowArtist.Services.Interfaces;
using SpotifyAPI.Web;
using HighLowArtist.Data;

namespace HighLowArtist.Services.Services
{
    public class HighLowService : IHighLowService
    {
        public HighLowService()
        {
        }
        
        public async Task<List<FullArtist>> GetArtists(/*List<string> artistId*/)
        {
            var config = SpotifyClientConfig.CreateDefault();

            var request = new ClientCredentialsRequest(Secrets.ClientId, Secrets.ClientSecret);
            var response = await new OAuthClient(config).RequestToken(request);

            var spotify = new SpotifyClient(config.WithToken(response.AccessToken));
            
            var artists = new List<FullArtist>();
            
            //TODO make this randomly choose two artists
            artists.Add(spotify.Artists.Get(ArtistIds.Ids["Muse"]).Result);
            artists.Add(spotify.Artists.Get(ArtistIds.Ids["Red Hot Chilli Peppers"]).Result);
            
            return artists;
        }
    }
}