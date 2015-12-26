using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeSocieta { get; set; }
        public string Paese { get; set; }
        public List<Ordine> Ordini { get; set; }
    }

    public class Ordine
    {
        public int OrdineId { get; set; }
        public DateTime DataOrdine { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }

    public class Magazzino : DbContext
    {
        public DbSet<Ordine> Ordini { get; set; }
        public DbSet<Cliente> Clienti { get; set; }
    }

}
