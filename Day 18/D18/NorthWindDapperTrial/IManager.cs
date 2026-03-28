using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindDapperTrial
{
    public interface IManager<T>
    {
        bool Add(T item);
        bool Delete(long ID);
        bool Update(T item);
        List<T> GetALL();
        T GetByID (long ID);    
    }
}
