﻿using SugarNewsAPI.Constants;

namespace SugarNewsAPI.Models
{
    public class ArticlesResult
    {
        public Statuses Status { get; set; }
        public Error? Error { get; set; }
        public int TotalResults { get; set; }
        public List<Article>? Articles { get; set; }
    }
}

