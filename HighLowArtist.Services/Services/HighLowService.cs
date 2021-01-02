using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HighLowArtist.Services.Interfaces;
using SpotifyAPI.Web;
using HighLowArtist.Data;

namespace HighLowArtist.Services.Services
{
    public class HighLowService : IHighLowService
    {
        public async Task<List<FullArtist>> GetArtists()
        {
            //TODO: Apply SOLID to this function

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
            } while (ArtistValidation(spotify, artistId1, artistId2) == false);

            artists.Add(spotify.Artists.Get(ArtistIds.Ids[artistId1]).Result);
            artists.Add(spotify.Artists.Get(ArtistIds.Ids[artistId2]).Result);

            return artists;
        }

        private bool ArtistValidation(SpotifyClient spotify, int artistId1, int artistId2)
        {
            if (artistId1 == artistId2 && spotify.Artists.Get(ArtistIds.Ids[artistId1]).Result.Popularity ==
                spotify.Artists.Get(ArtistIds.Ids[artistId2]).Result.Popularity)
            {
                return false;
            }else
            {
                return true;
            }
        }
    }
}