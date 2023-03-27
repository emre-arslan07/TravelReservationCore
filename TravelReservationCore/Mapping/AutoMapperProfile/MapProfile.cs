using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationDTO.DTOs.AnnouncementDTOs;
using TravelReservationDTO.DTOs.AppUserDTOs;
using TravelReservationDTO.DTOs.ContactDTOs;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTO, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTO>();

            CreateMap<AppUserRegisterDTO, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTO>();

            CreateMap<AppUserLoginDTO, AppUser>();
            CreateMap<AppUser, AppUserLoginDTO>();

            CreateMap<AnnouncementListDTO,Announcement>();
            CreateMap<Announcement,AnnouncementListDTO>();

            CreateMap<AnnouncementUpdateDTO, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDTO>();

            CreateMap<SendMessageDTO, ContactUs>().ReverseMap();
        }
    }
}
