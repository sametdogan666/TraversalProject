using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAbout2Dal : GenericRepository<About2, Context>, IAbout2Dal
    {
    }
}
