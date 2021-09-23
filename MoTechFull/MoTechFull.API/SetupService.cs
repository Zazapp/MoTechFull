using Microsoft.EntityFrameworkCore;
using MoTechFull.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.API
{
    public class SetupService
    {
        public void Init(MoTechContext context)
        {
            context.Database.Migrate();

            if (!context.KorisnickiNalogs.Any(x => x.KorisnickoIme == "admin"))
            {
                context.KorisnickiNalogs.Add(new KorisnickiNalog() { KorisnickoIme = "admin", Lozinka = "admin", Tip = 1 });
                context.KorisnickiNalogs.Add(new KorisnickiNalog() { KorisnickoIme = "prodavac", Lozinka = "prodavac", Tip = 2 });
                context.KorisnickiNalogs.Add(new KorisnickiNalog() { KorisnickoIme = "klijent", Lozinka = "klijent", Tip = 3 });
            }

            if (!context.Kategorijas.Any(x => x.Naziv == "Procesori"))
            {
                context.Kategorijas.Add(new Kategorija() { Naziv = "Procesori" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Graficke kartice" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "RAM" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Memorija" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Misevi" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Kucista" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Tastature" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Kamere" });
                context.Kategorijas.Add(new Kategorija() { Naziv = "Mikrofoni" });



            }

            if (!context.Proizvodjacs.Any(x => x.Naziv == "Intel"))
            {
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "Intel" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "AMD" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "G.SKILL" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "Nvidia" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "Logitech" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "Corsair" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "Samson" });
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "BENQ" });



            }

            if (!context.Kantons.Any(x => x.Naziv == "Hercegovacko-Neretvanski Kanton"))
            {
                context.Kantons.Add(new Kanton() { Naziv = "Hercegovacko-Neretvanski Kanton", Oznaka = "HNK" });
                context.Kantons.Add(new Kanton() { Naziv = "Kanton Sarajevo", Oznaka = "KS" });
                context.Kantons.Add(new Kanton() { Naziv = "Tuzlanski Kanton", Oznaka = "TK" });
            }

            context.SaveChanges();
        }
    }
}
