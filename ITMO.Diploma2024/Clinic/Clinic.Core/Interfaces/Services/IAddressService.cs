using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IAddressService
    {
        Task AddAddress(Address address);
        Task DeleteAddress(int id);
        Task<Address> GetByAddressId(int id);
        Task UpdateAddress(int id, string country, string region, string city, string street, int houseNumber, int apartmentNumber, string? description, string? pavilion);
    }
}