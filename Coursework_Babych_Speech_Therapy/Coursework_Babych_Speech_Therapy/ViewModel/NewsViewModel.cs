using System;
using System.Collections.Generic;
using System.Text;


namespace Coursework_Babych_Speech_Therapy.Model
{
     public class NewsViewModel
    {
        public List<News> News { get; set; }
        public NewsViewModel()
        {
            News = new News().GetNews();
        }
    }
}