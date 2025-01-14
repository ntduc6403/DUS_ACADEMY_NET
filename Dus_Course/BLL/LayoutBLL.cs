﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LayoutBLL
    {
        CategoryDAO categorydao = new CategoryDAO();
        SocialMediaDAO socialmediadao   = new SocialMediaDAO();
        FavDAO favdao = new FavDAO();
        MetaDAO metadao = new MetaDAO();
        AddressDAO addressdao = new AddressDAO();
        PostDAO postdao = new PostDAO();
        public HomeLayoutDTO GetLayOutData()
        {
            HomeLayoutDTO dto = new HomeLayoutDTO();
            dto.Categories = categorydao.GetCategories();
            List<SocialMediaDTO> socialmedialist = new List<SocialMediaDTO>();
            socialmedialist = socialmediadao.GetSocialMedias();
            dto.Facebook = socialmedialist.First(x => x.Link.Contains("facebook"));
            dto.Twitter = socialmedialist.First(x => x.Link.Contains("twitter"));
            dto.Instagram = socialmedialist.First(x => x.Link.Contains("instagram"));
            dto.Youtube = socialmedialist.First(x => x.Link.Contains("youtube"));
            dto.Linkedin = socialmedialist.First(x => x.Link.Contains("linkedin"));
            dto.FavDTO = favdao.GetFav();
            dto.MetaList = metadao.GetMetaData();
            List<AddressDTO> addresseslist = addressdao.GetAddresses();
            dto.Address = addresseslist.First();
            dto.HotNews = postdao.GetHotNews();



            return dto;
        }
    }
}
