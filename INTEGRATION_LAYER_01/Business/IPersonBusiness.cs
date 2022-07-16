using INTEGRATION_LAYER_01.Model;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Business
{
    public interface IPersonBusiness
    {
         Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

    }
}
