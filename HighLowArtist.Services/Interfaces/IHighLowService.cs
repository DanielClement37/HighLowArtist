using System.Collections.Generic;
using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace HighLowArtist.Services.Interfaces
{
    public interface IHighLowService
    { 
        Task<List<FullArtist>> GetArtists();
    }
}