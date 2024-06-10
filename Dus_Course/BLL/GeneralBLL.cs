using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BLL
{
    public class GeneralBLL
    {
        GeneralDAO dao = new GeneralDAO();
        AdsDAO adsdao = new AdsDAO();
        public GeneralDTO GetAllPosts()
        {
            GeneralDTO dto = new GeneralDTO();
            dto.SliderPost = dao.GetSliderPosts();
            dto.BreakingPost = dao.GetBreakingPost();
            dto.PopularPost = dao.GetPopularPosts();
            dto.MostViewedPost = dao.GetMostViewedPosts();
            dto.Videos = dao.GetVideos();
            dto.Adslist = adsdao.GetAds();
            return dto;
        }
        CategoryDAO categorydao = new CategoryDAO();
        public GeneralDTO GetCategoryPostList(string categoryName)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPost();
            dto.Adslist = adsdao.GetAds();
            if(categoryName == "Videos")
            {
                dto.Videos = dao.GetAllVideos();
                dto.CategoryName = "Videos";
            }
            else
            {
                List<CategoryDTO> categorylist = categorydao.GetCategories();
                int categoryID = 0;
                foreach(var item in categorylist)
                {
                    if (categoryName == SeoLink.GenerateUrl(item.CategoryName))
                    {
                        categoryID = item.ID;
                       
                        dto.CategoryName = item.CategoryName;
                        break;
                    }

                }
                dto.CategoryPostList = dao.GetCategoryPostList(categoryID);
            }

            return dto;
        }

        public GeneralDTO GetPostDetailPageItemsWithID(int ID)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPost();
            dto.Adslist = adsdao.GetAds();
            dto.PostDetail = dao.GetPostDetail(ID);
            //dto.Videos = dao.GetVideos();
            

            return dto;
        }
        AddressDAO addressdao = new AddressDAO();
        public GeneralDTO GetContactPageItems()
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPost();
            dto.Adslist = adsdao.GetAds();
            dto.Address = addressdao.GetAddresses().First();
            return dto;
        }

        public GeneralDTO GetSearchPosts(string SearchText)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPost();
            dto.Adslist = adsdao.GetAds();
            dto.CategoryPostList = dao.GetSearchPost(SearchText);
            dto.SearchText = SearchText;
            return dto;
        }

        public GeneralDTO GetSearchPostsDetail(string SearchTextDetail)
        {
            GeneralDTO dto = new GeneralDTO();
            dto.BreakingPost = dao.GetBreakingPost();
            dto.Adslist = adsdao.GetAds();
            dto.CategoryPostList = dao.GetSearchPostDetail(SearchTextDetail);
            dto.SearchTextDetail = SearchTextDetail;
            return dto;
        }
    }
}
