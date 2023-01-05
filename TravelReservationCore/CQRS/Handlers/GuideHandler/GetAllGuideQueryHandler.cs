using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetAllGuideQueryHandler:IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly TravelReservationDbContext _travelReservationDb;

        public GetAllGuideQueryHandler(TravelReservationDbContext travelReservationDb)
        {
            _travelReservationDb = travelReservationDb;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _travelReservationDb.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideID=x.GuideID,
                Description=x.Description,
                Image=x.Image,
                Name=x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
