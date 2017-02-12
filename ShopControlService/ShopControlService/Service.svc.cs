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
        public List<ClientCatalog> ClientCatalogList()
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
        }

        void IService.UpdateClient(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, DateTime BirthDateCl)
        {
            using (DataContext db = new DataContext())
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
        }

        public ClientCatalog FindClientById(int _id)
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

    }
}
