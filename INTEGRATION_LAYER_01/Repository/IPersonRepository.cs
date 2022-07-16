using INTEGRATION_LAYER_01.Model;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

        bool Exists(long id);

    }
}
