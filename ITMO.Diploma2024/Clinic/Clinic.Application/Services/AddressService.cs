using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Models;

namespace Clinic.Application.Services;

public class AddressService : IAddressService
{
    private readonly IAddressesRepository _addressesRepository;

    public AddressService(IAddressesRepository addressesRepository)
    {
        _addressesRepository = addressesRepository;
    }

    public async Task AddAddress(Address address)
    {
        await _addressesRepository.Add(address);
    }

    public async Task<Address> GetByAddressId(int id)
    {
        return await _addressesRepository.GetById(id);
    }

    public async Task UpdateAddress(
        int id,
        string country,
        string region,
        string city,
        string street,
        int houseNumber,
        int apartmentNumber,
        string? description,
        string? pavilion)
    {
        await _addressesRepository.Update(id, country, region, city, street, houseNumber, apartmentNumber, description, pavilion);
    }

    public async Task DeleteAddress(int id)
    {
        await _addressesRepository.Delete(id);
    }
}
