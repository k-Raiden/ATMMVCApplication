﻿using ATMDataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDataAccess.Context
{
    public  class ATMDBContext : DbContext
    {
        public ATMDBContext(DbContextOptions options) : base(options)
        {

        }

        protected ATMDBContext()
        {

        }
        public DbSet<AccountModel> Account { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountModel>(
                entity =>
                {
                    entity.HasKey(e => e.AccountID);
                    entity.Property(e => e.AccountID);
                    entity.Property(e => e.PinNumber);
                    entity.Property(e => e.FullName);
                    entity.Property(e => e.CardNumber);
                    entity.Property(e => e.DepositAmount);
                    entity.Property(e => e.AccountNumber);
                    entity.Property(e => e.WithdrawAmount);
                    entity.Property(e => e.NewBalance);
                    entity.Property(e => e.TransactionDate);
                    entity.Property(e => e.PreviousBalance);
                }
                );

        }

    }
}
