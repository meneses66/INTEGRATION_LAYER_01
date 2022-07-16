using INTEGRATION_LAYER_01.Model;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Repository
{
    public interface ISDevRepository
    {
         Sdev Create(Sdev sdev);

        Sdev FindById(long id);

        List<Sdev> FindAll();

        Sdev Update(Sdev sdev);

        void Delete(long id);

        bool Exists(long id);

    }
}
