using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class PersonService : Repository, IPersonService
    {
        public async Task AddPerson(Person model) => await AddAsync(model);
        public async Task<IEnumerable<Person>> GetPeopleAsync() => await ToListAsync<Person>();
        public PersonService(PersonContext context) : base(context)
        {

        }
    }
}
