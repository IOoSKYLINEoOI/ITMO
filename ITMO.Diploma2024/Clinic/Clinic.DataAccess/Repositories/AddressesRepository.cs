using AutoMapper;
using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Models;
using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataAccess.Repositories;

public class AddressesRepository : IAddressesRepository
{
    private readonly ClinicDbContext _context;
    private readonly IMapper _mapper;

    public AddressesRepository(ClinicDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Add(Address address)
    {

        var addressEntity = new AddressEntity()
        {
            Id = address.Id,
            Country = address.Country,
            Region = address.Region,
            City = address.City,
            Street = address.Street,
            HouseNumber = address.HouseNumber,
            Pavilion = address.Pavilion,
            ApartmentNumber = address.ApartmentNumber,
            Description = address.Description
        };

        await _context.Addresses.AddAsync(addressEntity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(
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
        await _context.Addresses
            .Where(x => x.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(s => s.Country, s => country)
                .SetProperty(s => s.Region, s => region)
                .SetProperty(s => s.City, s => city)
                .SetProperty(s => s.Street, s => street)
                .SetProperty(s => s.HouseNumber, s => houseNumber)
                .SetProperty(s => s.Pavilion, s => pavilion)
                .SetProperty(s => s.ApartmentNumber, s => apartmentNumber)
                .SetProperty(s => s.Description, s => description));
    }

    public async Task<Address> GetById(int id)
    {
        var addressEntity = await _context.Addresses
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id) ?? throw new Exception();

        return _mapper.Map<Address>(addressEntity);
    }

    public async Task Delete(int id)
    {
        await _context.Addresses
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
    }
}
