using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTracker.Core.Models;

namespace AssetTrackerWeb.ViewModels
{
    public class SubCategoryViewModel
    {
        public SubCategory SubCategory { get; set; }
        public ICollection<GeneralCategory> GeneralCategory { get; set; }
        public ICollection<Category> Category { get; set; } 
    }
}