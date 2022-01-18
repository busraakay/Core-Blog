using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> GetAllList();

        T GetByID(int id);
    }
}
