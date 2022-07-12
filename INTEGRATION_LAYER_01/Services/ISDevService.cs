using INTEGRATION_LAYER_01.Model;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Services
{
    public interface ISDevService
    {
         Sdev Create(Sdev sdev);

        Sdev FindById(long id);

        List<Sdev> FindAll();

        Sdev Update(Sdev sdev);

        void Delete(long id);

    }
}
