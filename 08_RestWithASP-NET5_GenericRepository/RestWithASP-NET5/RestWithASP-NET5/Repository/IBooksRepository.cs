using RestWithASP_NET5.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5.Repository
{
    public interface IBooksRepository    {
        Books Create(Books books);

        Books FindByID(long id);

        List<Books> FindAll();
        Books Update(Books books);

        void Delete(long Id);

        bool Exists(long id);
    }
}
