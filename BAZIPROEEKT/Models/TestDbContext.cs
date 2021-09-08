using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BAZIPROEEKT.Models
{
    public class TestDbContext:DbContext
    {
        DbSet<Aviokompanija> aviokompanii { get; set; }

        DbSet<Let> letovi { get; set; }
        DbSet<Karta> karti { get; set; }
        DbSet<Rezervacija> rezervacii { get; set; }
        DbSet<Klient> klienti { get; set; }
    }
}