using INTEGRATION_LAYER_01.Model;
using INTEGRATION_LAYER_01.Repository;
using System.Collections.Generic;

namespace INTEGRATION_LAYER_01.Business.Implementations
{
    public class SdevBusinessImplementation : ISDevBusiness
    {

        //private MySQLrepository _repository;

        private readonly ISDevRepository _repository;

        public SdevBusinessImplementation(ISDevRepository repository)
        {
            _repository = repository;
        }
        public Sdev Create(Sdev sdev)
        {
            return _repository.Create( sdev );
        }

        public void Delete(long id)
        {
            _repository.Delete( id );
        }

        public List<Sdev> FindAll()
        {
            return _repository.FindAll();
        }

        public Sdev FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Sdev Update(Sdev sdev)
        {
            return _repository.Update( sdev );
        }

    }
}
