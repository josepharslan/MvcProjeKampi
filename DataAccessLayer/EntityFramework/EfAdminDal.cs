using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        public Admin GetByUsernameAndPassword(string username, string password)
        {
            using (var context = new Context())
            {
                return context.Admins
                    .FirstOrDefault(x => x.AdminUsername == username && x.AdminPassword == password);
            }
        }
    }
}
