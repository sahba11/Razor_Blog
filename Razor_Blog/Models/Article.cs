﻿using System;
using System.Reflection;
using Razor_Blog.Models;

namespace Razor_Blog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }


        public Article(string title, string picture, string pictureAlt, string pictureTitle, string shortDescription,
            string body)
        {
            Title = title;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Body = body;
            CreationDate= DateTime.Now;

        }

    }

}

