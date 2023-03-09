using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMainFeatureService
    {
        void Add(MainFeature mainFeature);
        void Update(MainFeature mainFeature);
        void Delete(MainFeature mainFeature);
        List<MainFeature> GetAll();
        MainFeature GetById(int id);
    }
}
