﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    interface IRepository<T>
    {
        List<T> Reader();
    }
}
