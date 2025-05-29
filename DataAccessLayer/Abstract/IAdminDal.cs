﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAdminDal : IRepository<Admin>
    {
        Admin GetByUsernameAndPassword(string username, string password);
    }
}
