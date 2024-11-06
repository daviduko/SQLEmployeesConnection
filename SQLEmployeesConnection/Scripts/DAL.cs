using System.Collections.Generic;

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
