﻿using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Article : EntityBase, IEntity
    {
        public string Title { get; set; } //Resim başlık
        public string Content { get; set; }//Resim İçerik
        public string Thumbnail { get; set; }// Resim url için
        public DateTime Date { get; set; }// Tarih
        public int ViewsCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public string SeoAuthor { get; set; } //Yazan
        public string SeoTags { get; set; } //Yazan
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } //Paylasan kullanıcı
        public ICollection<Comment> Comment { get; set; }
        public string SeoDescription { get; set; }
        public string Comments { get; set; }
    }

}