using RestWithASP_NET5.Data.VO;
using System.Collections.Generic;

namespace RestWithASP_NET5.Business
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO books);

        BooksVO FindByID(long id);

        List<BooksVO> FindAll();
        BooksVO Update(BooksVO books);

        void Delete(long Id);
    }
}
