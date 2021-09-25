using Microsoft.EntityFrameworkCore;
using MoTechFull.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.API
{
    public class SetupService
    {
        public void Init(MoTechContext context)
        {
            context.Database.Migrate();

            //Korisnici

            if (!context.KorisnickiNalogs.Any(x => x.KorisnickoIme == "admin"))
            {
                context.KorisnickiNalogs.Add(new KorisnickiNalog() { KorisnickoIme = "admin", Lozinka = "admin", Tip = 1 });
                context.KorisnickiNalogs.Add(new KorisnickiNalog() { KorisnickoIme = "prodavac", Lozinka = "prodavac", Tip = 2 });
                context.KorisnickiNalogs.Add(new KorisnickiNalog() { KorisnickoIme = "klijent", Lozinka = "klijent", Tip = 3 });
            }

            //Kategorije

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

            //Proizvodjaci

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
                context.Proizvodjacs.Add(new Proizvodjac() { Naziv = "GeniusGx" });


            }

            //Kantoni
            if (!context.Kantons.Any(x => x.Naziv == "Hercegovacko-Neretvanski Kanton"))
            {
                context.Kantons.Add(new Kanton() { Naziv = "Hercegovacko-Neretvanski Kanton", Oznaka = "HNK" });
                context.Kantons.Add(new Kanton() { Naziv = "Kanton Sarajevo", Oznaka = "KS" });
                context.Kantons.Add(new Kanton() { Naziv = "Tuzlanski Kanton", Oznaka = "TK" });
            }

            context.SaveChanges();

            //Gradovi
            if (!context.Grads.Any(x => x.Naziv == "Mostar"))
            {
                context.Grads.Add(new Grad() { Naziv = "Mostar", Kanton=context.Kantons.Where(x=>x.Oznaka=="HNK").FirstOrDefault(), KantonId = context.Kantons.Where(x => x.Oznaka == "HNK").Select(w=>w.KantonId).FirstOrDefault() });
                context.Grads.Add(new Grad() { Naziv = "Sarajevo", Kanton = context.Kantons.Where(x => x.Oznaka == "KS").FirstOrDefault(), KantonId = context.Kantons.Where(x => x.Oznaka == "KS").Select(w => w.KantonId).FirstOrDefault() });
                context.Grads.Add(new Grad() { Naziv = "Tuzla", Kanton = context.Kantons.Where(x => x.Oznaka == "TK").FirstOrDefault(), KantonId = context.Kantons.Where(x => x.Oznaka == "TK").Select(w => w.KantonId).FirstOrDefault() });
            }

            context.SaveChanges();

            //Artikli
            if (!context.Artikals.Any(x => x.Naziv == "MX518")) 
            {

                context.Artikals.Add(new Artikal()
                {
                    Naziv = "MX518",
                    Cijena = 75,
                    Opis = "Kvalitetan logitech mis",
                    Kategorija = context.Kategorijas.Where(x => x.Naziv == "Misevi").FirstOrDefault(),
                    KategorijaId = context.Kategorijas.Where(x => x.Naziv == "Misevi").Select(w => w.KategorijaId).FirstOrDefault(),
                    Proizvodjac = context.Proizvodjacs.Where(x => x.Naziv == "Logitech").FirstOrDefault(),
                    ProizvodjacId = context.Proizvodjacs.Where(x => x.Naziv == "Logitech").Select(w => w.ProizvodjacId).FirstOrDefault(),
                    Image=null
                }) ;

                context.Artikals.Add(new Artikal()
                {
                    Naziv = "i9 9700k Intel Processor",
                    Cijena = 1100,
                    Opis = "Intel procesor 9th generation",
                    Kategorija = context.Kategorijas.Where(x => x.Naziv == "Procesori").FirstOrDefault(),
                    KategorijaId = context.Kategorijas.Where(x => x.Naziv == "Procesori").Select(w => w.KategorijaId).FirstOrDefault(),
                    Proizvodjac = context.Proizvodjacs.Where(x => x.Naziv == "Intel").FirstOrDefault(),
                    ProizvodjacId = context.Proizvodjacs.Where(x => x.Naziv == "Intel").Select(w => w.ProizvodjacId).FirstOrDefault(),
                    Image = null
                });


                context.Artikals.Add(new Artikal()
                {
                    Naziv = "GeForce RTX 3080x",
                    Cijena = 1500,
                    Opis = "NVIDIA Grafička kartica ",
                    Kategorija = context.Kategorijas.Where(x => x.Naziv == "Graficke kartice").FirstOrDefault(),
                    KategorijaId = context.Kategorijas.Where(x => x.Naziv == "Graficke kartice").Select(w => w.KategorijaId).FirstOrDefault(),
                    Proizvodjac = context.Proizvodjacs.Where(x => x.Naziv == "Nvidia").FirstOrDefault(),
                    ProizvodjacId = context.Proizvodjacs.Where(x => x.Naziv == "Nvidia").Select(w => w.ProizvodjacId).FirstOrDefault(),
                    Image = null
                });

                context.Artikals.Add(new Artikal()
                {
                    Naziv = "Imperator",
                    Cijena = 50,
                    Opis = "Gaming Tastatura",
                    Kategorija = context.Kategorijas.Where(x => x.Naziv == "Tastature").FirstOrDefault(),
                    KategorijaId = context.Kategorijas.Where(x => x.Naziv == "Tastature").Select(w => w.KategorijaId).FirstOrDefault(),
                    Proizvodjac = context.Proizvodjacs.Where(x => x.Naziv == "GeniusGx").FirstOrDefault(),
                    ProizvodjacId = context.Proizvodjacs.Where(x => x.Naziv == "GeniusGx").Select(w => w.ProizvodjacId).FirstOrDefault(),
                    Image = null
                });
            }

            context.SaveChanges();

            //Racuni
            if (!context.Racuns.Any())
            {
                context.Racuns.Add(new Racun() 
                {
                    DatumIzdavanja=DateTime.Now, 
                    KorisnickiNalog=context.KorisnickiNalogs.Where(q=>q.KorisnickoIme=="klijent").FirstOrDefault(),
                    KorisnickiNalogId = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").Select(w=>w.KorisnickiNalogId).FirstOrDefault(),
                    Iznos=125
                });


                context.Racuns.Add(new Racun()
                {
                    DatumIzdavanja = DateTime.Now,
                    KorisnickiNalog = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").FirstOrDefault(),
                    KorisnickiNalogId = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").Select(w => w.KorisnickiNalogId).FirstOrDefault(),
                    Iznos = 175
                });

                context.Racuns.Add(new Racun()
                {
                    DatumIzdavanja = DateTime.Now,
                    KorisnickiNalog = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").FirstOrDefault(),
                    KorisnickiNalogId = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").Select(w => w.KorisnickiNalogId).FirstOrDefault(),
                    Iznos = 200
                });

                context.Racuns.Add(new Racun()
                {
                    DatumIzdavanja = DateTime.Now,
                    KorisnickiNalog = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").FirstOrDefault(),
                    KorisnickiNalogId = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").Select(w => w.KorisnickiNalogId).FirstOrDefault(),
                    Iznos = 225
                });

                context.Racuns.Add(new Racun()
                {
                    DatumIzdavanja = DateTime.Now,
                    KorisnickiNalog = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").FirstOrDefault(),
                    KorisnickiNalogId = context.KorisnickiNalogs.Where(q => q.KorisnickoIme == "klijent").Select(w => w.KorisnickiNalogId).FirstOrDefault(),
                    Iznos = 250
                });
            }

            context.SaveChanges();

            //KupciNarudze
            if (!context.KupacNarudzbes.Any()) 
            {
                context.KupacNarudzbes.Add(new KupacNarudzbe()
                {
                    AdresaDostave="Mostar bb",
                    Datum=DateTime.Now,
                    IsIsporucena=true,
                    Grad=context.Grads.Where(x=>x.Naziv=="Mostar").FirstOrDefault(),
                    GradId=context.Grads.Where(x=>x.Naziv=="Mostar").Select(w=>w.GradId).FirstOrDefault(),
                    KorisnickiNalog=context.KorisnickiNalogs.Where(x=>x.KorisnickoIme=="klijent").FirstOrDefault(),
                    KorisnickiNalogId = context.KorisnickiNalogs.Where(x => x.KorisnickoIme == "klijent").Select(w=>w.KorisnickiNalogId).FirstOrDefault()
                });
            }

            context.SaveChanges();

            //NarudzbaStavke

            if (!context.NarudzbaStavkes.Any()) 
            {
                //racun1
                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal=context.Artikals.Where(x=>x.Naziv=="MX518").FirstOrDefault(),
                    ArtikalId=context.Artikals.Where(x => x.Naziv == "MX518").Select(w=>w.ArtikalId).FirstOrDefault(),
                    Racun=context.Racuns.Where(x=>x.Iznos==125).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 125).Select(w=>w.RacunId).FirstOrDefault(),
                    Kolicina=1,
                    UnitCijena=75,
                    Popust=0,
                    KupacNarudzbe=context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId=context.KupacNarudzbes.Select(q=>q.KupacNarudzbeId).FirstOrDefault()
                });

                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "Imperator").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "Imperator").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 125).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 125).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 1,
                    UnitCijena = 50,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                //racun2
                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "MX518").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "MX518").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 175).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 175).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 1,
                    UnitCijena = 75,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "Imperator").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "Imperator").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 175).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 175).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 2,
                    UnitCijena = 50,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                //racun3
                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "MX518").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "MX518").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 200).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 200).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 2,
                    UnitCijena = 75,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "Imperator").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "Imperator").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 200).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 200).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 1,
                    UnitCijena = 50,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                //racun4
                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "MX518").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "MX518").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 225).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 225).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 1,
                    UnitCijena = 75,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "Imperator").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "Imperator").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 225).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 225).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 3,
                    UnitCijena = 50,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                //racun5
                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "MX518").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "MX518").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 250).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 250).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 2,
                    UnitCijena = 75,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });

                context.NarudzbaStavkes.Add(new NarudzbaStavke()
                {
                    Artikal = context.Artikals.Where(x => x.Naziv == "Imperator").FirstOrDefault(),
                    ArtikalId = context.Artikals.Where(x => x.Naziv == "Imperator").Select(w => w.ArtikalId).FirstOrDefault(),
                    Racun = context.Racuns.Where(x => x.Iznos == 250).FirstOrDefault(),
                    RacunId = context.Racuns.Where(x => x.Iznos == 250).Select(w => w.RacunId).FirstOrDefault(),
                    Kolicina = 2,
                    UnitCijena = 50,
                    Popust = 0,
                    KupacNarudzbe = context.KupacNarudzbes.FirstOrDefault(),
                    KupacNarudzbeId = context.KupacNarudzbes.Select(q => q.KupacNarudzbeId).FirstOrDefault()
                });
            }

            context.SaveChanges();

        }
    }
}
