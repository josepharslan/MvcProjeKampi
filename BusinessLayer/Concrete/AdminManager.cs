using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;

        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public void AdminAdd(Admin admin)
        {
            _admindal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _admindal.Update(admin);
        }

        public Admin GetAdmin(string username, string password)
        {
            return _admindal.Get(x => x.AdminUsername == username && x.AdminPassword == password);
        }

        public Admin GetById(int id)
        {
            return _admindal.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _admindal.List();
        }
    }
}
