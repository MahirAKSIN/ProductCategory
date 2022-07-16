﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public  interface IRepository<T>
    {
        List<T> GetAllList();
        T GetById(int id);
        T GetSingle(T t);
    }
}
