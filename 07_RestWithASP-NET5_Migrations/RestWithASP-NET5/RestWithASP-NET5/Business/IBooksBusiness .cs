using RestWithASP_NET5.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books books);

        Books FindByID(long id);

        List<Books> FindAll();
        Books Update(Books books);

        void Delete(long Id);
    }
}
