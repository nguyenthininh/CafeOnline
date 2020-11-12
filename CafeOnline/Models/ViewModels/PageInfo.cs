﻿using System;

namespace CafeOnline.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages =>(int)Math.Ceiling((double)TotalItems / ItemsPerPage);
    }
}
