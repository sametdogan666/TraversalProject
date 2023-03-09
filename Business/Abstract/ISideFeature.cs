using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISideFeature
    {
        void Add(SideFeature feature);
        void Update(SideFeature feature);
        void Delete(SideFeature feature);
        List<SideFeature> GetAll();
        SideFeature GetById(int id);
    }
}
