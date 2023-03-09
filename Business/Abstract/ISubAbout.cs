using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubAbout
    {
        void Add(SubAbout subAbout);
        void Update(SubAbout subAbout);
        void Delete(SubAbout subAbout);
        List<SubAbout> GetAll();    
        SubAbout GetById(int id);
    }
}
