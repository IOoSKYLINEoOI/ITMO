using Clinic.Core.Models;

namespace Clinic.Core.Interfaces.Repositories;

public interface IAddressesRepository
{
    Task Add(Address address);
    Task Delete(int id);
    Task<Address> GetById(int id);
    Task Update(
        int id, 
        string country, 
        string region, 
        string city, 
        string street, 
        int houseNumber, 
        int apartmentNumber, 
        string? description, 
        string? pavilion);
}
