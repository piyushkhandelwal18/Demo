using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user, HttpPostedFileBase file)
        {
            HttpPostedFileBase f = Request.Files[0];
            return View();
        }

        [HttpPost]
        public ActionResult Upload(UploadImage uploadimage)
        {
            /*
            HttpPostedFileBase file = Request.Files["ImageUpload"];
            byte[] data;
            using (Stream inputStream = file.InputStream)
            {
                MemoryStream memoryStream = inputStream as MemoryStream;
                if (memoryStream == null)
                {
                    memoryStream = new MemoryStream();
                    inputStream.CopyTo(memoryStream);
                }
                data = memoryStream.ToArray();
            }
            if (data != null)
            {
                UploadImage img1 = new UploadImage();
                img1.ImageName = file.FileName;
                img1.Image = data;

                using (ImageContext img = new ImageContext())
                {
                    img.Image.Add(img1);
                    img.SaveChanges();
                }
            }
            */
            /*
            uploadimage.Id = Guid.NewGuid();

            if (file != null && file.FileName != null && file.FileName != "")
            {
                FileInfo fi = new FileInfo(file.FileName);
                if (fi.Extension != ".jpeg" && fi.Extension != ".jpg")
                {
                    TempData["Errormsg"] = "Image File Extension is Not valid";
                    return View(uploadimage);
                }
                else
                {
                    string image1 = "image1";
                    uploadimage.ImageName = uploadimage.Id + fi.Extension;

                    file.SaveAs(Server.MapPath("~/Content/Image/" + uploadimage.Id + fi.Extension));
                    
                }*/
            return View();
        }


    }
}