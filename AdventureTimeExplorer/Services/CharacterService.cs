using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTimeExplorer.Services
{
    public class CharacterService : ICharactersService
    {
        private HttpClient httpClient;
        public CharacterService()
        {
            httpClient = new HttpClient();
        }

        private List<CharacterModel> Characters = new();
        public async Task<List<CharacterModel>> GetCharacters()
        {
            // request path to get the list of AT chracters
            var path = new Uri("https://adventure-time-api.herokuapp.com/api/v1/characters");

            var response = await httpClient.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                Characters = await response.Content.ReadFromJsonAsync<List<CharacterModel>>();
            }

            return Characters;
        }
    }
}
