﻿using RestWithASP_NET5.Model;
using RestWithASP_NET5.Repository;
using System.Collections.Generic;

namespace RestWithASP_NET5.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;

        public BooksBusinessImplementation(IBooksRepository repository)
        {
            _repository = repository;
        }

        // Method responsible for returning all people
        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one person by ID
        public Books FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to create one new person
        public Books Create(Books books)
        {
            return _repository.Create(books);
        }

        // Method responsible for updating one person
        public Books Update(Books books)
        {
            return _repository.Update(books);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
