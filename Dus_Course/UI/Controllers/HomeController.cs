using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        LayoutBLL layoutbll = new LayoutBLL();
        GeneralBLL generalbll = new GeneralBLL();
        PostBLL postbll = new PostBLL();
        ContactBLL contactbll = new ContactBLL();
        public ActionResult Index()
        {
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;

            GeneralDTO dto = new GeneralDTO();
            dto = generalbll.GetAllPosts();
            return View(dto);
        }
        public ActionResult CategoryPostList(string CategoryName)
        {
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();
            dto = generalbll.GetCategoryPostList(CategoryName);
            return View(dto);
        }
        public ActionResult PostDetail(int ID)
        {
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();

            dto = generalbll.GetPostDetailPageItemsWithID(ID);
            return View(dto);
        }
        [HttpPost]
        public ActionResult PostDetail(GeneralDTO model)
        {
            if (model.Name != null && model.Email != null && model.Message != null)
            {
                if (postbll.AddComment(model))
                {
                    ViewData["CommentState"] = "Success";
                    ModelState.Clear();
                }
                else
                    ViewData["CommentState"] = "Error";
            }
            else
            {
                ViewData["CommentState"] = "Error";
            }
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();
            model = generalbll.GetPostDetailPageItemsWithID(model.PostID);
            return View(model);
        }
        [Route("contactus")]
        public ActionResult ContactUs() {
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();
            dto = generalbll.GetContactPageItems();
            return View(dto);
        }
        [Route("contactus")]
        [HttpPost]
        public ActionResult ContactUs(GeneralDTO model)
        {
            if(model.Name != null && model.Subject != null && model.Email != null && model.Message != null)
            {
                if (contactbll.AddContact(model))
                {
                    ViewData["CommentState"] = "Success";


                }
                else
                {
                    ViewData["CommentState"] = "Error";


                }
            }
            else
            {
                ViewData["CommentState"] = "Error";


            }
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();
            dto = generalbll.GetContactPageItems();
            return View(dto);
        }
        [Route("search")]
        [HttpPost]
        public ActionResult Search( GeneralDTO model)
        {
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();
            dto = generalbll.GetSearchPosts(model.SearchText);
            
            return View(dto);
        }
        [Route("searchinpostdetail")]
        [HttpPost]
        public ActionResult SearchDetail(GeneralDTO model)
        {
            HomeLayoutDTO layoutdto = new HomeLayoutDTO();
            layoutdto = layoutbll.GetLayOutData();
            ViewData["LayoutDTO"] = layoutdto;
            GeneralDTO dto = new GeneralDTO();
            dto = generalbll.GetSearchPostsDetail(model.SearchTextDetail);

            return View(dto);
        }


    }
}