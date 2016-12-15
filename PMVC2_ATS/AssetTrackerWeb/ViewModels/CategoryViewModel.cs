using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTracker.Core.Models;

namespace AssetTrackerWeb.ViewModels
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }
        public ICollection<GeneralCategory> GeneralCategories { get; set; }
    }
}