using System;
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
        
        public async Task<List<FullArtist>> GetArtists()
        {
            var config = SpotifyClientConfig.CreateDefault();

            var request = new ClientCredentialsRequest(Secrets.ClientId, Secrets.ClientSecret);
            var response = await new OAuthClient(config).RequestToken(request);

            var spotify = new SpotifyClient(config.WithToken(response.AccessToken));
            
            var artists = new List<FullArtist>();
            var rand = new Random();
            int artistId1, artistId2, numArtists = ArtistIds.Ids.Count;
            
            do
            {
                artistId1 = rand.Next(0, numArtists);
                artistId2 = rand.Next(0, numArtists);
            } while (artistId1 == artistId2);
            
            artists.Add(spotify.Artists.Get(ArtistIds.Ids[artistId1]).Result);
            artists.Add(spotify.Artists.Get(ArtistIds.Ids[artistId2]).Result);
            
            return artists;
        }
    }
}