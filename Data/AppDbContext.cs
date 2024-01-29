﻿using Microsoft.EntityFrameworkCore;
using PrimeiroApp.Models;

namespace PrimeiroApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {    
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
