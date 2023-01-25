using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Entity
{
    public class Film :BaseEntity
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public string FilmImageUrl { get; set; }

    }
}
