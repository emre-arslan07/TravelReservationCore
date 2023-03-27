using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationBll.Abstract.AbstractUnitOfWork;
using TravelReservationBll.Concrete;
using TravelReservationBll.Concrete.ConcreteUnitOfWork;
using TravelReservationBll.ValidationRules;
using TravelReservationDal.Abstract;
using TravelReservationDal.EntityFramework;
using TravelReservationDal.UnitOfWork;
using TravelReservationDTO.DTOs.AnnouncementDTOs;
using TravelReservationDTO.DTOs.ContactDTOs;

namespace TravelReservationBll.Container
{
   public static class Extensionss
    {
        public static void ContainerDependencies(IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EFCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EFDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EFAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EFReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EFGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EFContactUsDal>();
            
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementdDal, EFAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EFAccountDal>();

            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();
        }

        public static void CustomerValidator(IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDTO>, AnnouncementUpdateValidator>();
            services.AddTransient<IValidator<SendMessageDTO>, SendContactUsValidator>();

        }
    }
}
