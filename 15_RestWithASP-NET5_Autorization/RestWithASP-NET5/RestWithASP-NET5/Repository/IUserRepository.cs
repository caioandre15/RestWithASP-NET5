﻿using RestWithASP_NET5.Data.VO;
using RestWithASP_NET5.Model;

namespace RestWithASP_NET5.Repository
{
    interface IUserRepository
    {
        User ValidateCredentials(UserVO user);


    }
}