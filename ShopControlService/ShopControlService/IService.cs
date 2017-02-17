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
        // -------------------- КЛІЄНТИ КАТАЛОГ ----------------------- //

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
        // ----КІНЕЦЬ---------------- КЛІЄНТИ КАТАЛОГ ----------------------- //

        // -------------------- ВИРОБНИКИ КАТАЛОГ ----------------------- //
        [OperationContract]
        List<ManufacturerCatalog> ManufacturerCatalogList();
        [OperationContract]
        void AddNewManufacturer(string NameMan, string PhoneMan, string EmailMan,
            string WebsiteMan, bool IsRealizMan, string INNMan, string EDRPOUMan, string MFOMan,
            string RRMan, string BankMan);
        [OperationContract]
        void UpdateManufacturer(int _id, string NameMan, string PhoneMan, string EmailMan,
            string WebsiteMan, bool IsRealizMan, string INNMan, string EDRPOUMan, string MFOMan,
            string RRMan, string BankMan);
        [OperationContract]
        void DeleteManufacturer(int _id);
        [OperationContract]
        ManufacturerCatalog FindManufacturerById(int _id);


        // ----КІНЕЦЬ---------------- ВИРОБНИКИ КАТАЛОГ ----------------------- //
        
        // -------------------- ГРУПИ ТОВАРІВ КАТАЛОГ ----------------------- //

        [OperationContract]
        void AddNewGroup(string NameGroup, int idParent);
        [OperationContract]
        List<ProductGroup> ProductGroupList();
        [OperationContract]
        void DeleteGroup(int _id);


        // ----КІНЕЦЬ---------------- ГРУПИ ТОВАРІВ КАТАЛОГ ----------------------- //


    }
}
