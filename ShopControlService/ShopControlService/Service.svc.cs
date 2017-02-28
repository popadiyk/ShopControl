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

        // -------------------- ГРУПИ ТОВАРІВ КАТАЛОГ ----------------------- //

        void IService.AddNewGroup(string NameGroup, int idParent)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ProductGroup newGroup = new ProductGroup();
                    newGroup.Name = NameGroup;
                    if (idParent == 0)
                    {
                        newGroup.Parent = null;
                    }
                    else
                    {
                        ProductGroup ParentNewGroup = db.TProductGroup.
                            Where(x => x.ID == idParent)
                            .FirstOrDefault();
                        newGroup.Parent = ParentNewGroup;
                    }
                    db.TProductGroup.Add(newGroup);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        void IService.UpdateGroup(int _id, string NameGroup, int idParent)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ProductGroup changedGroup = db.TProductGroup.
                        Where(x => x.ID == _id)
                        .FirstOrDefault();
                    if (idParent == 0)
                    {
                        changedGroup.Name = NameGroup;
                        db.Entry(changedGroup).Reference(x => x.Parent).CurrentValue = null;
                        //Тадам)))
                        db.SaveChanges();
                    }
                    else
                    {
                        ProductGroup ParentChangedGroup = db.TProductGroup.
                            Where(x => x.ID == idParent)
                            .FirstOrDefault();
                        changedGroup.Name = NameGroup;
                        changedGroup.Parent = ParentChangedGroup;
                        db.SaveChanges();
                    }


                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
            }
        }

        public List<ProductGroup> ProductGroupList()
        {
            using (DataContext db = new DataContext())
            {
                return db.TProductGroup.ToList();
            }
        }

        public int DeleteGroup(int _id)
        {
            using (DataContext db = new DataContext())
            {
                ProductGroup removeGroup = new ProductGroup();
                if (_id == 0)
                {
                    removeGroup = null;
                }
                else
                {
                        removeGroup = db.TProductGroup.
                            Where(x => x.ID == _id)
                            .FirstOrDefault();
                }
                try
                {
                    db.TProductGroup.Remove(removeGroup);
                    db.SaveChanges();
                }
                catch
                {
                    return -2;
                }

            }
            return 0;

        }

        // ------КІНЕЦЬ-------------- ГРУПИ ТОВАРІВ КАТАЛОГ ----------------------- //

        // -------------------------- КАТАЛОГ ТОВАРІВ ----------------------------- //

        public List<ProductsCatalog> ProductCatalogList()
        {
            using (DataContext db = new DataContext())
            {
                return db.TProductsCatalog
                    .Include("Group")
                    .Include("Manufacturer")
                    .ToList();
            }
        }

        public void AddNewProduct(string NameProduct, int idGroup, int idManufacturer,
            string MarkingProduct, float PurchPriceProduct, float PriceProduct, string DescriptionProduct)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    ProductsCatalog newProduct = new ProductsCatalog();
                    newProduct.Name = NameProduct;
                    newProduct.Group = db.TProductGroup
                        .Where(x => x.ID == idGroup)
                        .FirstOrDefault();
                    newProduct.Manufacturer = db.TManufacturerCatalog
                        .Where(x => x.ID == idManufacturer)
                        .FirstOrDefault();
                    newProduct.Marking = MarkingProduct;
                    newProduct.PurchasePrice = PurchPriceProduct;
                    newProduct.Price = PriceProduct;
                    newProduct.Description = DescriptionProduct;

                    db.TProductsCatalog.Add(newProduct);
                    db.SaveChanges();
                }
                catch
                {

                }
            }
        }

        // ------КІНЕЦЬ-------------- КАТАЛОГ ТОВАРІВ ----------------------------- //

        // ---------------------------- ПОШУК ТОВАРІВ ----------------------------- //
        public List<ProductsCatalog> SearchByGroup(string Group)
        {
            using (DataContext db = new DataContext())
            {
                return db.TProductsCatalog
                    .Include("Group")
                    .Include("Manufacturer")
                    .Where(x => x.Group.Name == Group)
                    .ToList();
            }
        }
        // ------КІНЕЦЬ---------------- ПОШУК ТОВАРІВ ----------------------------- //


    }
}
