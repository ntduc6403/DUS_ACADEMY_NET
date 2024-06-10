using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace UI.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        UserBLL bll = new UserBLL();
        // GET: Admin/User
        public ActionResult UserList()
        {
            List<UserDTO>   model = new List<UserDTO>();
            model = bll.GetUsers();
            return View(model);
        }
        public ActionResult AddUser()
        {
            UserDTO model = new UserDTO();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO model)
        {
            if (model.UserImage == null)
            {
                ViewBag.ProcessState = General.Messages.ImageMissing;
            }
            else if (ModelState.IsValid)
            {
                string filename = "";
                //khoi tao doc hinh anh tu luong dau vao
                HttpPostedFileBase postedfile = model.UserImage;
                Bitmap UserImage = new Bitmap(postedfile.InputStream);

                //resize anh nhap vao
                Bitmap resizeImage = new Bitmap(UserImage, 128, 128);
                //kiem tra dinh dang hinh anh
                string ext = Path.GetExtension(postedfile.FileName);
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif")
                {
                    //tao unique tranh trung lap ten file anh
                    string uniqueNumber = Guid.NewGuid().ToString();
                    //merge file vs nhau
                    filename = uniqueNumber + postedfile.FileName;
                    resizeImage.Save(Server.MapPath("~/Areas/Admin/Content/UserImage/" + filename));
                    model.Imagepath = filename;

                    //adduser
                    bll.AddUser(model);
                    ViewBag.ProcessState = General.Messages.AddSuccess;
                    ModelState.Clear();
                    model = new UserDTO();
                }
                else
                {
                    ViewBag.ProcessState = General.Messages.ExtensionError;
                }
            }
            else
            {
                ViewBag.ProcessState = General.Messages.EmptyArea;
            }
            return View(model);
        }
        public ActionResult UpdateUser(int ID)
        {
            UserDTO dto = new UserDTO();
            dto = bll.GetUserWithID(ID);
            return View(dto);
        }
        [HttpPost]
        public ActionResult UpdateUser(UserDTO model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ProcessState = General.Messages.EmptyArea;

            }
            else
            {
                //kiểm tra hình ảnh có change ko 
                if (model.UserImage != null)
                {
                    string filename = "";
                    //khoi tao doc hinh anh tu luong dau vao
                    HttpPostedFileBase postedfile = model.UserImage;
                    Bitmap UserImage = new Bitmap(postedfile.InputStream);

                    //resize anh nhap vao
                    Bitmap resizeImage = new Bitmap(UserImage, 128, 128);
                    //kiem tra dinh dang hinh anh
                    string ext = Path.GetExtension(postedfile.FileName);
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif")
                    {
                        //tao unique tranh trung lap ten file anh
                        string uniqueNumber = Guid.NewGuid().ToString();
                        //merge file vs nhau
                        filename = uniqueNumber + postedfile.FileName;
                        resizeImage.Save(Server.MapPath("~/Areas/Admin/Content/UserImage/" + filename));
                        model.Imagepath = filename;
                    }

                }

                string oldImagePath = bll.UpdateUser(model);

                if (model.Imagepath != null)
                {
                    //xoa hinh anh cu thay hinh anh moi
                    if (System.IO.File.Exists(Server.MapPath("~/Areas/Admin/Content/UserImage/" + oldImagePath)))
                    {
                        System.IO.File.Delete(Server.MapPath("~/Areas/Admin/Content/UserImage/" + oldImagePath));
                    }
                    ViewBag.ProcessState = General.Messages.UpdateSuccess;


                }

            }
        
            return View(model);
        }
       
        public JsonResult DeleteUser(int ID)
        {
            string imagepath = bll.DeleteUser(ID);
            if (System.IO.File.Exists(Server.MapPath("~/Areas/Admin/Content/UserImage/" + imagepath)))
            {
                System.IO.File.Delete(Server.MapPath("~/Areas/Admin/Content/UserImage/" + imagepath));
            }
            return Json("");
        }
    }
}