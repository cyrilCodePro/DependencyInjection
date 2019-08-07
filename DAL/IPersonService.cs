using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public interface IPersonService
    {
        Task AddPerson(Person model);
        Task<IEnumerable<Person>> GetPeopleAsync();
    }
}