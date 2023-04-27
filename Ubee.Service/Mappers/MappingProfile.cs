using AutoMapper;
using Ubee.Domain.Entities;
using Ubee.Service.DTOs;

namespace Ubee.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User
        CreateMap<UserForCreationDto, User>().ReverseMap();
        CreateMap<UserDto, User>().ReverseMap();

        // Wallet
        CreateMap<WalletDto, Wallet>().ReverseMap();
        CreateMap<WalletForCreationDto, Wallet>().ReverseMap();

        // Info
        CreateMap<InfoCreationDto, Info>().ReverseMap();
        CreateMap<InfoDto , Info>().ReverseMap();

        // Transaction
        CreateMap<TransactionDto, Transaction>().ReverseMap();
        CreateMap<TransactionForCreationDto, Transaction>().ReverseMap();
    }
}
