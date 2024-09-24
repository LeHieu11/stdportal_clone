using API.DTOs;
using API.Entities;
using AutoMapper;

public class MappingProfile : Profile {
    public MappingProfile() {
        // Add as many of these lines as you need to map your objects
        CreateMap<MonHoc, MonHocDTO>().ReverseMap();
        CreateMap<ChuongTrinhDaoTao, ChuongTrinhDaoTaoDTO>().ReverseMap();
        CreateMap<ChuongTrinhDaoTaoChiTiet, ChuongTrinhDaoTaoChiTietDTO>().ReverseMap();
    }
}