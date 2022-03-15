using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.News_ViewModels
{
    public class CDiscountViewModel
    {
        private News _news = null;
        public News news
        {
            get
            {
                if (_news == null)
                    _news = new News();
                return _news;
            }
            set { _news = value; }
        }
        [DisplayName("標題")]
        public string NewsTitle
        {
            get { return this.news.NewsTitle; }
            set { this.news.NewsTitle = value; }
        }
        [DisplayName("內容")]
        public string NewsContent
        {
            get { return this.news.NewsContent; }
            set { this.news.NewsContent = value; }
        }
        [DisplayName("照片")]
        public string NewsFigure
        {
            get { return this.news.NewsFigure; }
            set { this.news.NewsFigure = value; }
        }
        [DisplayName("貼文者")]
        public string PostName
        {
            get { return this.news.NewsManager.LogInName; }
            set { this.news.NewsManager.LogInName = value; }
        }
        [DisplayName("時間")]
        public DateTime NewsTime
        {
            get { return this.news.NewsTime; }
            set { this.news.NewsTime = value; }
        }

    }
}
