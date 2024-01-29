using Microsoft.EntityFrameworkCore;
using SpinningWheel.Models;
using System;

namespace SpinningWheel.Data;

public class SpinWheelDbContext : DbContext
{
    public SpinWheelDbContext(DbContextOptions<SpinWheelDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> User { get; set; } = default!;
}

