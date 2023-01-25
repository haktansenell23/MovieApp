using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Core.Entity
{
    public class CategoryImage : BaseEntity
    {
        public Category Category { get; set; }
        public string CategoryId { get; set; }

        public string  FileName { get; set; }

    }
}
