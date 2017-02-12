using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void AddNewClient(string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, DateTime BirthDateCl);
        [OperationContract]
        List<ClientCatalog> ClientCatalogList();
        [OperationContract]
        void UpdateClient(int IdCl, string NameCl, string DescriptionCl, int DiscountCl, int CardNumberCl, string PhoneNumberCl, DateTime BirthDateCl);
        [OperationContract]
        ClientCatalog FindClientById(int _id);
        [OperationContract]
        void DeleteClient(int _id);
    }
}
