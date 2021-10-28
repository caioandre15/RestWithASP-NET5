using RestWithASP_NET5.Data.Converter.Contract;
using RestWithASP_NET5.Data.VO;
using RestWithASP_NET5.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5.Data.Converter.Implementations
{
    public class BooksConverter : IParser<BooksVO, Books>, IParser<Books, BooksVO>
    {
        public Books Parse(BooksVO origin)
        {
            if (origin == null) return null;
            return new Books
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                title = origin.title
            };
        }
        public BooksVO Parse(Books origin)
        {
            if (origin == null) return null;
            return new BooksVO
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                title = origin.title
            };
        }

        public List<Books> Parse(List<BooksVO> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
        public List<BooksVO> Parse(List<Books> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
