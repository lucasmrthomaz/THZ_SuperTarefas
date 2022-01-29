#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using THZ_SuperTarefas.Models;

namespace THZ_SuperTarefas.Data
{
    public class THZ_SuperTarefasContext : DbContext
    {
        public THZ_SuperTarefasContext (DbContextOptions<THZ_SuperTarefasContext> options)
            : base(options)
        {
        }

        public DbSet<THZ_SuperTarefas.Models.Tarefa> Tarefa { get; set; }
    }
}
