using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        IAdressDal _adressDal;

        public AddressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public void Delete(Address t)
        {
            throw new NotImplementedException();
        }

        public Address GetByID(int id)
        {
            return _adressDal.GetByID(id);
        }

        public List<Address> GetListAll()
        {
            return _adressDal.GetListAll();
        }

        public void Insert(Address t)
        {
            throw new NotImplementedException();
        }

        public void Update(Address t)
        {
            _adressDal.Update(t);
        }
    }
}
