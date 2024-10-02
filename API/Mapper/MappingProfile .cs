using API.DTOs;
using API.Entities;
using AutoMapper;

public class MappingProfile : Profile {
    public MappingProfile() {
        // Add as many of these lines as you need to map your objects
        CreateMap<MonHoc, MonHocDTO>().ReverseMap();
        CreateMap<ChuongTrinhDaoTao, ChuongTrinhDaoTaoDTO>().ReverseMap();
        CreateMap<ChuongTrinhDaoTaoChiTiet, ChuongTrinhDaoTaoChiTietDTO>()
            .ForMember(dest => dest.MaMonHoc, opt => opt.MapFrom(src => src.MonHoc.MaMonHoc))
            .ForMember(dest => dest.TenMonHoc, opt => opt.MapFrom(src => src.MonHoc.TenMonHoc))
            .ForMember(dest => dest.MoTa, opt => opt.MapFrom(src => src.MonHoc.MoTa))
            .ForMember(dest => dest.TinChi, opt => opt.MapFrom(src => src.MonHoc.TinChi))
            .ForMember(dest => dest.TinChiLyThuyet, opt => opt.MapFrom(src => src.MonHoc.TinChiLyThuyet))
            .ForMember(dest => dest.TinChiThucHanh, opt => opt.MapFrom(src => src.MonHoc.TinChiThucHanh))
            .ForMember(dest => dest.NamHoc, opt => opt.MapFrom(src => src.HocPhi.NamHoc))
            .ForMember(dest => dest.SoTien, opt => opt.MapFrom(src => src.HocPhi.SoTien));
        CreateMap<HocPhi, HocPhiDTO>().ReverseMap();
    }
}