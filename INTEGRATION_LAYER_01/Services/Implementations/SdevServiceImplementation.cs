using INTEGRATION_LAYER_01.Model;
using INTEGRATION_LAYER_01.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEGRATION_LAYER_01.Services.Implementations
{
    public class SdevServiceImplementation : ISDevService
    {

        private MySQLContext _context;
        public SdevServiceImplementation(MySQLContext context)
        {
            _context = context;
        }
        public Sdev Create(Sdev sdev)
        {
            try
            {
                _context.Add(sdev);
                _context.SaveChanges();
            }
            catch ( Exception )
            {
                throw;
            }
            return sdev;
        }

        public void Delete(long id)
        {
            var result = _context.SDevs.SingleOrDefault(p => p.id.Equals(id));

            if(result != null)
            {
                try
                {
                    _context.SDevs.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Sdev> FindAll()
        {
            return _context.SDevs.ToList();
        }

        public Sdev FindById(long id)
        {
            return _context.SDevs.SingleOrDefault(p => p.id.Equals(id));
        }

        public Sdev Update(Sdev sdev)
        {
            if (!Exists(sdev.id)) return new Sdev();
            
            var result = _context.SDevs.SingleOrDefault(p => p.id.Equals(sdev.id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(sdev);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return sdev;
        }

        private bool Exists(long id)
        {
            return _context.SDevs.Any(p => p.id.Equals(id));
        }
    }
}
