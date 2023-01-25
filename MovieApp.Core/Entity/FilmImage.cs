using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Core.Entity
{
    public class FilmImage : BaseEntity
    {

        public string ImageUrl { get; set; }

        public Film Film { get; set; }

        public string FilmId { get; set; }

        public DateTime UploadedDate { get; set; }  = DateTime.Now;

        public string FileName { get; set; }


    }
}
