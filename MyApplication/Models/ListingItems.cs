using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
    public class ListingItems
    {
        public string ItemImg { get; set; } //string of the filepath for the image
        public string ItemTitle { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get; set; }
        public string ItemCondition { get; set; }
        public string Category { get; set; }
 

    }
}