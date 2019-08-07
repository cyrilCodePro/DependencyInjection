using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PersonContext:DbContext
    {
      public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {

        }
    }
}
