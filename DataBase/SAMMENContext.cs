﻿using Microsoft.EntityFrameworkCore;
using SAMMEN.DataBase.Models;

namespace DataBase
{
    public class SAMMENContext : DbContext
    {
        public SAMMENContext(DbContextOptions<SAMMENContext> options) : base(options) {}
        DbSet<User> Users { get; set; }
    }
}