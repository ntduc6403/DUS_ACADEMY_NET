using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class CommentController : BaseController
    {
        PostBLL bll = new PostBLL();
      
        public ActionResult UnapprovedComment()
        {
            List<CommentDTO> commentlist = new List<CommentDTO>();
            commentlist = bll.GetComment();
            return View(commentlist);
        }
        public ActionResult AllComments()
        {
            List<CommentDTO> commentlist = bll.GetAllComment();
            return View(commentlist);
        }
        public ActionResult ApprovedComment(int ID)
        {
            bll.ApproveComment(ID);
            return RedirectToAction("UnapprovedComment", "Comment");
        }
        public ActionResult ApprovedComment2(int ID)
        {
            bll.ApproveComment(ID);
            return RedirectToAction("AllComments", "Comment");
        }
        public JsonResult DeleteComment(int ID)
        {
            bll.DeleteComment(ID);
            return Json("");
        }
    }
}