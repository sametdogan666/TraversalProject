using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsletterService
    {
        void Add(Newsletter newsletter);
        void Update(Newsletter newsletter);
        void Delete(Newsletter newsletter);
        List<Newsletter> GetAll();
        Newsletter GetById(int id);
    }
}
