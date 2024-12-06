using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iam.Models;

namespace Iam.Data;

public class IamContext(DbContextOptions<IamContext> options) : DbContext(options)
{
    public DbSet<Iam.Models.Movie> Movie { get; set; } = default!;
}
