﻿using DTO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GeneralDAO : PostContext
    {
        

        public List<PostDTO> GetSliderPosts()
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.Slider == true && x.isDeleted == false  )
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                        }
                        ).OrderByDescending( x => x.AddDate ).Take(8).ToList();
            foreach(var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<PostDTO> GetBreakingPost()
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.Area3 == true && x.isDeleted == false)
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                        }
                        ).OrderByDescending(x => x.AddDate).Take(4).ToList();
            foreach (var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<PostDTO> GetPopularPosts()
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.isDeleted == false && x.Area2 == true)
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                        }
                        ).OrderByDescending(x => x.AddDate).Take(5).ToList();
            foreach (var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<PostDTO> GetMostViewedPosts()
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.isDeleted == false)
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                        }
                        ).OrderByDescending(x => x.viewcount).Take(5).ToList();
            foreach (var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<VideoDTO> GetVideos()
        {
            List<VideoDTO> dtolist = new List<VideoDTO>();
            List<Video> list = db.Videos.Where(x => x.isDeleted == false).OrderByDescending(x=> x.AddDate).Take(3).ToList();
            foreach (var item in list)
            {
                VideoDTO dto = new VideoDTO();
                dto.ID = item.ID;
                dto.Title = item.Title;
                dto.VideoPath = item.VideoPath;
                dto.OriginalVideoPath = item.OriginalVideoPath;
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);   
            }
            return dtolist;
        }

        public PostDTO GetPostDetail(int ID)
        {
            Post post = db.Posts.First(x => x.ID == ID);
            post.ViewCount++;
            db.SaveChanges();
            PostDTO dto = new PostDTO();
            dto.ID = post.ID;
            dto.ViewCount = post.ViewCount;
            dto.Title = post.Title;
            dto.ShortContent = post.ShortContent;
            dto.PostContent = post.PostContent;
            dto.Language = post.LanguageName;
            dto.SeoLink = post.SeoLink;
            dto.AddDate = post.AddDate;
            dto.CategoryID = post.CategoryID;
            dto.CategoryName = (db.Categories.First(x => x.ID == dto.CategoryID)).CategoryName;
            List<PostImage> images = db.PostImages.Where(x => x.isDeleted == false && x.PostID == ID).ToList();
            List<PostImageDTO> imagedtolist = new List<PostImageDTO>();
            foreach (var item in images)
            {
                PostImageDTO img = new PostImageDTO();
                img.ID = item.ID;
                img.ImagePath = item.ImagePath;
                imagedtolist.Add(img);
            }
            dto.PostImages = imagedtolist;
            dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == ID && x.isApproved == true).Count();
            List<Comment> comments = db.Comments.Where(x => x.isDeleted == false && x.PostID == ID && x.isApproved == true).ToList();
            List<CommentDTO> commentdtolist = new List<CommentDTO>();
            foreach (var item in comments)
            {
                CommentDTO cdto = new CommentDTO();
                cdto.ID = item.ID;
                cdto.AddDate = item.AddDate;
                cdto.CommentContent = item.CommentContent;
                cdto.Name = item.NameSurname;
                cdto.Email = item.Email;
                commentdtolist.Add(cdto);
            }
            dto.CommentList = commentdtolist;
            List<PostTag> tags = db.PostTags.Where(x => x.isDeleted == false && x.PostID == ID).ToList();
            List<TagDTO> taglist = new List<TagDTO>();
            foreach (var item in tags)
            {
                TagDTO tdto = new TagDTO();
                tdto.ID = item.ID;
                tdto.TagContent = item.TagContent;
                taglist.Add(tdto);
            }
            dto.TagList = taglist;
            //lấy video trùng title với póst tile sử dụng star with của LINQ
            List<Video> videos = db.Videos.Where(x => x.Title.ToLower().StartsWith(post.Title.ToLower())).ToList();
            //List<Video> videos = db.Videos.Where(x => x.Title == post.Title).ToList();
            List<VideoDTO> videodtolist = new List<VideoDTO>();
            foreach (var item in videos)
            {
                VideoDTO vdto = new VideoDTO();
                vdto.ID = item.ID;
                vdto.Title = item.Title;
                vdto.OriginalVideoPath = item.OriginalVideoPath;
                vdto.VideoPath = item.VideoPath;
                videodtolist.Add(vdto);
            }
            dto.Videos = videodtolist;

            return dto;
                
        }

        public List<VideoDTO> GetAllVideos()
        {
            List<VideoDTO> dtolist = new List<VideoDTO>();
            List<Video> list = db.Videos.Where(x => x.isDeleted == false).OrderByDescending(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                VideoDTO dto = new VideoDTO();
                dto.ID = item.ID;
                dto.Title = item.Title;
                dto.VideoPath = item.VideoPath;
                dto.OriginalVideoPath = item.OriginalVideoPath;
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<PostDTO> GetCategoryPostList(int categoryID)
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.isDeleted == false && x.CategoryID == categoryID )
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                            Language = p.LanguageName,
                            
                        }
                        ).OrderByDescending(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.Language = item.Language;              
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<PostDTO> GetSearchPost(string SearchText)
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.isDeleted == false && (x.Title.Contains(SearchText) ))
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                            Language = p.LanguageName,

                        }
                        ).OrderByDescending(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.Language = item.Language;
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }

        public List<PostDTO> GetSearchPostDetail(string SearchTextDetail)
        {
            List<PostDTO> dtolist = new List<PostDTO>();
            var list = (from p in db.Posts.Where(x => x.isDeleted == false && (x.Title.Contains(SearchTextDetail) || x.PostContent.Contains(SearchTextDetail)))
                        join c in db.Categories on p.CategoryID equals c.ID
                        select new
                        {
                            postID = p.ID,
                            title = p.Title,
                            categoryName = c.CategoryName,
                            seoLink = p.SeoLink,
                            viewcount = p.ViewCount,
                            AddDate = p.AddDate,
                            Language = p.LanguageName,

                        }
                        ).OrderByDescending(x => x.AddDate).ToList();
            foreach (var item in list)
            {
                PostDTO dto = new PostDTO();
                dto.ID = item.postID;
                dto.Title = item.title;
                dto.CategoryName = item.categoryName;
                dto.Language = item.Language;
                dto.ViewCount = item.viewcount;
                dto.SeoLink = item.seoLink;
                PostImage image = db.PostImages.First(x => x.isDeleted == false && x.PostID == item.postID);
                dto.ImagePath = image.ImagePath;
                dto.CommentCount = db.Comments.Where(x => x.isDeleted == false && x.PostID == item.postID && x.isApproved == true).Count();
                dto.AddDate = item.AddDate;
                dtolist.Add(dto);
            }
            return dtolist;
        }
    }
}
