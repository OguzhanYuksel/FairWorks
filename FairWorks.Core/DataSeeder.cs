using FairWorks.DAL;
using FairWorks.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FairWorks.Core
{
    public class DataSeeder
    {
        public static void SeedPersonelTypes(FairWorksDbContext context)
        {
            if (!context.PersonelTypes.Any())
            {
                var personelTypes = new List<PersonelType>
            {
                new PersonelType { Name = "Genel Müdür" },
                new PersonelType { Name = "Grup Satış Müdürü" },
                new PersonelType { Name = "Operasyon Müdürü" },
                new PersonelType { Name = "Muhasebe Müdürü" },
                new PersonelType { Name = "IT Müdürü" },
            };
                context.AddRange(personelTypes);
                context.SaveChanges();
            }
            if (!context.Sectors.Any())
            {
                var sectors = new List<Sector>
                {
                    new Sector {Name = "Elektrik ve Elektronik" },
                    new Sector {Name = "Bilişim Teknolojileri" },
                    new Sector {Name = "Enerji" },
                    new Sector {Name = "İnşaat" },
                };
                context.AddRange(sectors);
                context.SaveChanges();
            }
            if (!context.CompanyProfiles.Any())
            {
                var companyProfiles = new List<CompanyProfile>
                {
                    new CompanyProfile {Name = "Üretici" },
                    new CompanyProfile {Name = "İthalatçı" },
                    new CompanyProfile {Name = "İhracatçı" },
                };
                context.AddRange(companyProfiles);
                context.SaveChanges();
            }
            if (!context.Companies.Any())
            {
                var companies = new List<Company>
                {
                    new Company {Name = "Vestel" },
                    new Company {Name = "Arçelik" },
                };
                context.AddRange(companies);
                context.SaveChanges();
            }
            if (!context.SalesPersons.Any())
            {
                var salesPersons = new List<SalesPerson>
                {
                    new SalesPerson {Name = "TestName", Surname="TestSurname",Commission = 4, Email = "test@email.com",Phone = "1231231212", Title="testtitle"},
                };
                context.AddRange(salesPersons);
                context.SaveChanges();
            }
            if (!context.Fairs.Any())
            {
                var fairs = new List<Fair>
                {
                    new Fair {Name = "TestFair1",Country = "TR",City="Ankara",Active=true,StartDate = DateTime.Parse("05.07.2020"),EndDate = DateTime.Parse("15.07.2020"),
                        Salons =  new List<Salon>
                        {
                            new Salon {Name = "TestFair1Salon1",SalonNo = "1",Area = 100, SectorId = new Guid("B6C361AA-683A-499F-CE49-08D828C5E847")},
                            new Salon {Name = "TestFair1Salon2",SalonNo = "2",Area = 100, SectorId = new Guid("B3B20808-80BA-4736-CE4A-08D828C5E847")},
                            new Salon {Name = "TestFair1Salon3",SalonNo = "3",Area = 100, SectorId = new Guid("3570C809-5DF2-4A0C-CE4C-08D828C5E847")},
                        }
                    },
                    new Fair {Name = "TestFair2",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020"),
                        Salons =  new List<Salon>
                        {
                            new Salon {Name = "TestFair2Salon1",SalonNo = "1",Area = 100, SectorId = new Guid("B6C361AA-683A-499F-CE49-08D828C5E847")},
                            new Salon {Name = "TestFair2Salon2",SalonNo = "2",Area = 100, SectorId = new Guid("B3B20808-80BA-4736-CE4A-08D828C5E847")},
                            new Salon {Name = "TestFair2Salon3",SalonNo = "3",Area = 100, SectorId = new Guid("3570C809-5DF2-4A0C-CE4C-08D828C5E847")},
                        }
                    },
                    new Fair {Name = "TestFair3",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020"),
                        Salons =  new List<Salon>
                        {
                            new Salon {Name = "TestFair3Salon1",SalonNo = "1",Area = 100, SectorId = new Guid("B6C361AA-683A-499F-CE49-08D828C5E847")},
                            new Salon {Name = "TestFair3Salon2",SalonNo = "2",Area = 100, SectorId = new Guid("B3B20808-80BA-4736-CE4A-08D828C5E847")},
                            new Salon {Name = "TestFair3Salon3",SalonNo = "3",Area = 100, SectorId = new Guid("3570C809-5DF2-4A0C-CE4C-08D828C5E847")},
                        }
                    },
                    new Fair {Name = "TestFair4",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020"),
                        Salons =  new List<Salon>
                        {
                            new Salon {Name = "TestFair4Salon1",SalonNo = "1",Area = 100, SectorId = new Guid("B6C361AA-683A-499F-CE49-08D828C5E847")},
                            new Salon {Name = "TestFair4Salon2",SalonNo = "2",Area = 100, SectorId = new Guid("B3B20808-80BA-4736-CE4A-08D828C5E847")},
                            new Salon {Name = "TestFair4Salon3",SalonNo = "3",Area = 100, SectorId = new Guid("3570C809-5DF2-4A0C-CE4C-08D828C5E847")},
                        }
                    },
                    new Fair {Name = "TestFair5",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                    new Fair {Name = "TestFair6",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                    new Fair {Name = "TestFair7",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                    new Fair {Name = "TestFair8",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                    new Fair {Name = "TestFair9",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                    new Fair {Name = "TestFair10",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                    new Fair {Name = "TestFair11",Country = "TR",City="İzmir",Active=true,StartDate = DateTime.Parse("08.07.2020"),EndDate = DateTime.Parse("15.07.2020")},
                };

                foreach (var fair in fairs)
                {
                    context.AddAsync(fair);
                    if (fair.Salons != null)
                    {
                        foreach (var salon in fair.Salons)
                        {
                            salon.FairId = fair.Id;
                        }
                        context.AddRange(fair.Salons);
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
