using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.model
{
    public interface IFilmsInterface
    {
        Task<List<FilmItem>> GetFilms();
        //Task<FilmItem> GetFilmDetails(int id);

        //Task<FilmItem> GetCharacters();
    }
}
