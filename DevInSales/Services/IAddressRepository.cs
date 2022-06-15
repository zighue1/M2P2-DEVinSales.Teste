using DevInSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevInSales.api.Services
{
    public interface IAddressRepository
    {
        public List<Address> getAddress();

        public Address getAddress(int id);
        public void PostAddress(Address address);
    }
}
