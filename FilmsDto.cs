using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.model
{

    public class FilmsDto
    {
        public Films[]? data { get; set; }
    }

    public class Films
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? releaseDate { get; set; }
        public string? poster { get; set; }
        public Gendre? gendre { get; set; }
        public Character[] characters { get; set; }
    }

    public class Gendre
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public Actor actor { get; set; }
    }

    public class Actor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string birthDate { get; set; }
        public string foto { get; set; }
    }

}
