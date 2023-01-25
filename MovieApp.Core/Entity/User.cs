using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool isAdmin { get; set; } = false;



    }
}
