using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.model
{
    public class FilmItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ReleaseDate { get; set; }

        public string PosterUrl { get; set; }
        public object Gender { get; set; }
        public object Character { get; set; }
        public object Gendre { get; set; }
    }
}
