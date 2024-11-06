using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLEmployeesConnection.Scripts
{
    internal abstract class DAL<T>
    {
        protected DBConnect dbConnect;

        protected DAL()
        {
            dbConnect = new DBConnect();
        }

        public abstract void Insert(T entity);
        public abstract void Update(T entity);
        public abstract List<T> GetListOf();
    }
}
