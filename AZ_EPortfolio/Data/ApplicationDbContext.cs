﻿using AZ_EPortfolio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AZ_EPortfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Template> Templates { get; set; }

        public DbSet<AZ_EPortfolio.Models.AzUser> AzUser { get; set; }
    }
}
