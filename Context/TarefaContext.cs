using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using trilha_net_api_2.Model;


namespace trilha_net_api_2.Context
{
  public class TarefaContext : DbContext
  {

    public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
    {

    }


    public DbSet<Tarefa> Tarefas { get; set; }
  }
}