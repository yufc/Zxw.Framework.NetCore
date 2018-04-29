﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Zxw.Framework.NetCore.Options;

namespace Zxw.Framework.NetCore.DbContextCore
{
    public class InMemoryDbContext:BaseDbContext
    {
        public InMemoryDbContext(IOptions<DbContextOption> option) : base(option)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(_option.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}