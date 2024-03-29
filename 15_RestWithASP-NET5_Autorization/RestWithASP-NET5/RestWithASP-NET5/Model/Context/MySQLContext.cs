﻿using Microsoft.EntityFrameworkCore;

namespace RestWithASP_NET5.Model.Context
{
    public class MySQLContext : DbContext
    {
        public  MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
