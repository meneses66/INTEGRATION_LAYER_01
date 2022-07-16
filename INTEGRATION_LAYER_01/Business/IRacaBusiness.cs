using INTEGRATION_LAYER_01.Model;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Business
{
    public interface IRacaBusiness
    {
        Raca Create(Raca raca);

        Raca FindById(long id);

        List<Raca> FindAll();

        Raca Update(Raca raca);

        void Delete(long id);
    }
}
