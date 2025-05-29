using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public Writer GetByUsernameAndPassword(string username, string password)
        {
            using (var context = new Context())
            {
                return context.Writers
                    .FirstOrDefault(x => x.WriterMail == username && x.WriterPassword == password);
            }
        }
    }
}
