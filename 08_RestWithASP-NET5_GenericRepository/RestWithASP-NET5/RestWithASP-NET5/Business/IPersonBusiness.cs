﻿using RestWithASP_NET5.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> FindAll();
        Person Update(Person person);

        void Delete(long Id);
    }
}
