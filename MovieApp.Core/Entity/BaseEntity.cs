using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Entity
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }

        public bool  IsActive { get; set; }

    }
}
