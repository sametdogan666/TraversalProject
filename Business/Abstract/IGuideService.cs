using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGuideService
    {
        void Add(Guide guide);
        void Update(Guide guide);
        void Delete(Guide guide);
        List<Guide> GetAll();
        Guide GetById(int id);
    }
}
