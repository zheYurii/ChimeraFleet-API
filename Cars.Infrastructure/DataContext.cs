using Microsoft.EntityFrameworkCore;
using Cars.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Infrastructure;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Car> Cars => Set<Car>();
}
