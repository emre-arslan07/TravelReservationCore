using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TravelReservationCore.CQRS.Queries.GuideQuery;
using TravelReservationCore.CQRS.Results.GuideResult;
using TravelReservationDal.Concrete;

namespace TravelReservationCore.CQRS.Handlers.GuideHandler
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly TravelReservationDbContext _travelReservationDb;

        public GetGuideByIDQueryHandler(TravelReservationDbContext travelReservationDb)
        {
            _travelReservationDb = travelReservationDb;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values =await _travelReservationDb.Guides.FindAsync(request.Id);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
