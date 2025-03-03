﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class SocialMediaBLL
    {
        SocialMediaDAO dao = new SocialMediaDAO();
        
        public bool AddSocialMedia(SocialMediaDTO model)
        {
            SocialMedia social = new SocialMedia();
           

            social.Name = model.Name;
            social.Link = model.Link;
            social.ImagePath = model.ImagePath;
            social.AddDate = DateTime.Now;
            social.LastUpdateUserID = UserStatic.UserID;
            social.LastUpdateDate = DateTime.Now;
            int ID = dao.AddSocialMedia(social);
            LogDAO.AddLog(General.ProcessType.SocialAdd, General.TableName.social, ID);

            return true;
        }
    }
}
  
