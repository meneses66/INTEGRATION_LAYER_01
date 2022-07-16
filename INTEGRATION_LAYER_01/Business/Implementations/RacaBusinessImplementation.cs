using INTEGRATION_LAYER_01.Model;
using INTEGRATION_LAYER_01.Repository.Generic;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Business.Implementations
{
    public class RacaBusinessImplementation : IRacaBusiness
    {

        private readonly IRepository<Raca> _repository;

        public RacaBusinessImplementation(IRepository<Raca> reopsitory)
        {
            _repository = reopsitory;
        }

        public Raca Create(Raca raca)
        {
            return _repository.Create(raca);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Raca> FindAll()
        {
            return _repository.FindAll();
        }

        public Raca FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Raca Update(Raca raca)
        {
            return _repository.Update(raca);
        }
    }
}
