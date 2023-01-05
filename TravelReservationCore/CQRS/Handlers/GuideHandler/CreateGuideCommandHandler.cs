using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TravelReservationCore.CQRS.Commands.GuideCommand;
using TravelReservationDal.Concrete;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.CQRS.Handlers.GuideHandler
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly TravelReservationDbContext _travelReservationDb;

        public CreateGuideCommandHandler(TravelReservationDbContext travelReservationDb)
        {
            _travelReservationDb = travelReservationDb;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _travelReservationDb.Guides.Add(new Guide
            {
                Name=request.Name,
                Description=request.Description,
                Status=true,
            });
            await _travelReservationDb.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
