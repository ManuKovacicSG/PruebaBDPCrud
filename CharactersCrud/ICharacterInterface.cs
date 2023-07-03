using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.model
{
    public interface ICharacterInterface
    {
        Task<List<CharacterItem>> GetCharacters();
    
    }
}
