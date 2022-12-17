using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Concrete;
using TravelReservationDal.EntityFramework;

namespace TravelReservationCore.ViewComponents.Comments
{
    public class CommentsList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetCommentByDestinationId(id);
            return View(values);
        }
    }
}
