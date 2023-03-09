using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDestinationService
    {
        void Add(Destination destination);
        void Update(Destination destination);
        void Delete(Destination destination);
        List<Destination> GetAll();
        Destination GetById(int id);
    }
}
