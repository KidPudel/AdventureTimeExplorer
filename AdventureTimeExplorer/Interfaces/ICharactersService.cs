using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTimeExplorer.Interfaces
{
    /// <summary>
    /// Class that calls to adventure time api (thank u sally https://github.com/sally)
    /// </summary>
    /// <returns></returns>
    public interface ICharactersService
    {

        /// <summary>
        /// Method that gets all characters
        /// </summary>
        /// <returns></returns>
        Task<List<CharacterModel>> GetCharacters();
    }
}
