using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopControlClient;

namespace ShopControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        // -------------------- КЛІЄНТ КАТАЛОГ ----------------------- //
        List<ClientCatalog> IService.ClientCatalogList()
        {
            using (DataContext db = new DataContext())
            {
                return db.TClientCatalog.ToList();
            } 
        }

        void IService.AddNewClient(string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, DateTime BirthDateCl)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ClientCatalog newClient = new ClientCatalog
                    {
                        CreateDate = DateTime.Now,
                        Name = NameCl,
                        Descripton = DescriptionCl,
                        Discount = DiscountCl,
                        CardNumber = CardNumberCl,
                        PhoneNumber = PhoneNumberCl,
                        BirthDate = BirthDateCl
                    };
                    db.TClientCatalog.Add(newClient);
                    db.SaveChanges();
                } 
                catch
                {

                }

            }
        }

        void IService.UpdateClient(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, DateTime BirthDateCl)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ClientCatalog changedClient = db.TClientCatalog
                        .Where(c => c.ID == IdCl)
                        .FirstOrDefault();
                    changedClient.Name = NameCl;
                    changedClient.Descripton = DescriptionCl;
                    changedClient.Discount = DiscountCl;
                    changedClient.CardNumber = CardNumberCl;
                    changedClient.PhoneNumber = PhoneNumberCl;
                    changedClient.BirthDate = BirthDateCl;
                    db.SaveChanges();
                } 
                catch
                {

                }

            }
        }

        ClientCatalog IService.FindClientById(int _id)
        {
            using (DataContext db = new DataContext())
            {
                ClientCatalog findClient = db.TClientCatalog
                    .Where(c => c.ID == _id)
                    .FirstOrDefault();
                return findClient;
             }
        }

        void IService.DeleteClient(int _id)
        {
            using (DataContext db = new DataContext())
            {
                ClientCatalog findClient = db.TClientCatalog
                    .Where(c => c.ID == _id)
                    .FirstOrDefault();
                db.TClientCatalog.Remove(findClient);
                db.SaveChanges();
                
            }
        }
        // ----КІНЕЦЬ---------------- КЛІЄНТ КАТАЛОГ ----------------------- //

        // -------------------- ВИРОБНИКИ КАТАЛОГ ----------------------- //

        List<ManufacturerCatalog> IService.ManufacturerCatalogList()
        {
            using (DataContext db = new DataContext())
            {
                return db.TManufacturerCatalog.ToList();
            }
        }

        void IService.AddNewManufacturer(string NameMan, string PhoneMan, string EmailMan,
            string WebsiteMan, bool IsRealizMan, string INNMan, string EDRPOUMan, string MFOMan,
            string RRMan, string BankMan)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ManufacturerCatalog newManufacturer = new ManufacturerCatalog
                    {
                        Name = NameMan,
                        Phone = PhoneMan,
                        Email = EmailMan,
                        WebSite = WebsiteMan,
                        IsRealization = IsRealizMan,
                        INN = INNMan,
                        EDERPOU = EDRPOUMan,
                        MFO = MFOMan,
                        RR = RRMan,
                        Bank = BankMan
                    };
                    db.TManufacturerCatalog.Add(newManufacturer);
                    db.SaveChanges();
                } 
                catch
                {

                }

            }
        }

        void IService.UpdateManufacturer(int _id, string NameMan, string PhoneMan, string EmailMan,
            string WebsiteMan, bool IsRealizMan, string INNMan, string EDRPOUMan, string MFOMan,
            string RRMan, string BankMan)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ManufacturerCatalog changedManufacturer = db.TManufacturerCatalog
                    .Where(c => c.ID == _id)
                    .FirstOrDefault();
                    changedManufacturer.Name = NameMan;
                    changedManufacturer.Phone = PhoneMan;
                    changedManufacturer.Email = EmailMan;
                    changedManufacturer.WebSite = WebsiteMan;
                    changedManufacturer.IsRealization = IsRealizMan;
                    changedManufacturer.INN = INNMan;
                    changedManufacturer.EDERPOU = EDRPOUMan;
                    changedManufacturer.MFO = MFOMan;
                    changedManufacturer.RR = RRMan;
                    changedManufacturer.Bank = BankMan;
                    db.SaveChanges();
                } 
                catch
                {
                    
                }

            }
        }
        ManufacturerCatalog IService.FindManufacturerById(int _id)
        {
            using (DataContext db = new DataContext())
            {
                ManufacturerCatalog findManufacturer = db.TManufacturerCatalog
                    .Where(c => c.ID == _id)
                    .FirstOrDefault();
                return findManufacturer;
            }
        }
        void IService.DeleteManufacturer(int _id)
        {
            using (DataContext db = new DataContext())
            {
                ManufacturerCatalog findManufacturer = db.TManufacturerCatalog
                    .Where(c => c.ID == _id)
                    .FirstOrDefault();
                db.TManufacturerCatalog.Remove(findManufacturer);
                db.SaveChanges();
            }
        }


        // -----КІНЕЦЬ--------------- ВИРОБНИКИ КАТАЛОГ ----------------------- //

    }
    }
