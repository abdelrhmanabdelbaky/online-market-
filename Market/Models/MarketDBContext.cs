﻿using Microsoft.EntityFrameworkCore;

namespace Market.Models
{
    public class MarketDBContext : DbContext
    {
        public MarketDBContext(DbContextOptions<MarketDBContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> admins { get; set; }
        public DbSet<User> users{ get; set; }
        public DbSet<Feedback> feedbacks { get; set; }
    }
}
