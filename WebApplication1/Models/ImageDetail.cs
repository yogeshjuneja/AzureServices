using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ImageDetail
    {
        public List<Category> categories { get; set; }
        public string requestId { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public double score { get; set; }
    }

    public class Metadata
    {
        public int width { get; set; }
        public int height { get; set; }
        public string format { get; set; }
    }
     
    ///
    //    {
    //  "categories": [{
    //    "name": "outdoor_road",
    //    "score": 0.91015625
    //  }],
    //  "requestId": "e35fc7d2-e583-44f5-8898-54a2afdd8d4c",
    //  "metadata": {
    //    "width": 800,
    //    "height": 530,
    //    "format": "Jpeg"
    //  }
    //}
    ///
}