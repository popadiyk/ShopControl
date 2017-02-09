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

        void IService.AddNewClient(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, DateTime BirthDateCl)
        {
            using (DataContext db = new DataContext())
            {
                ClientCatalog newClient = new ClientCatalog
                {
                    ID = IdCl,
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

    }
}
