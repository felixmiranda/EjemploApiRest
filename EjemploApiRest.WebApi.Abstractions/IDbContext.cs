using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploApiRest.Abstractions
{
    public interface IDbContext<T>: ICrud<T>
    {
    }
}
