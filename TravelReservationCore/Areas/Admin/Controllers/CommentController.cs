using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationBll.Concrete;
using TravelReservationDal.EntityFramework;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.GetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.GetById(id);
            _commentService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
