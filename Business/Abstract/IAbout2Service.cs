using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAbout2Service
    {
        void Add(About2 about2);
        void Update(About2 about2);
        void Delete(About2 about2);
        List<About2> GetAll();
        About GetById(int id);
    }
}
