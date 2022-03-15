using Microsoft.AspNetCore.Http;
using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CNewsViewModel
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

        [DisplayName("圖片")]
        public string NewsFigures
        {
            get { return this.news.NewsFigure; }
            set { this.news.NewsFigure = value; }
        }

        [DisplayName("圖片")]

        public IFormFile NewsFigure { get; set; }

        [DisplayName("公告種類")]
        public int NewsTypeId
        {
            get { return this.news.NewsTypeId; }
            set { this.news.NewsTypeId = value; }
        }
        public int NewsId {
            get { return this.news.NewsId; }
            set { this.news.NewsId = value; }
        }

        [DisplayName("員工ID")]
        public int NewsManagerId
        {
            get { return this.news.NewsManagerId; }
            set { this.news.NewsManagerId = value; }
        }

        [DisplayName("員工")]
        public string NewsManagerName
        {
            get;
            set;
        }

        [DisplayName("發布時間")]
        public DateTime NewsTime
        {
            get { return this.news.NewsTime; }
            set { this.news.NewsTime = value; }
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

        //[DisplayName("圖片")]
        //public string NewsFigure
        //{
        //    get { return this.news.NewsFigure; }
        //    set { this.news.NewsFigure = value; }
        //}

        public virtual LogIn NewsManager
        {
            get { return this.news.NewsManager; }
            set { this.news.NewsManager = value; }
        }
        public virtual NewsType NewsType
        {
            get { return this.news.NewsType; }
            set { this.news.NewsType = value; }
        }

        private LogIn _login = null;
        public LogIn login
        {
            get
            {
                if (_login == null)
                    _login = new LogIn();
                return _login;
            }
            set { _login = value; }
        }

        public int LogInId
        {
            get { return this.login.LogInId; }
            set { this.login.LogInId = value; }
        }

        [DisplayName("員工")]
        public string LogInName
        {
            get { return this.login.LogInName; }
            set { this.login.LogInName = value; }
        }

        private NewsType _newsType = null;
        public NewsType newsType
        {
            get
            {
                if (_newsType == null)
                    _newsType = new NewsType();
                return _newsType;
            }
            set { _newsType = value; }
        }

        [DisplayName("類型")]
        public string NewsTypeName
        {
            get { return this.newsType.NewsTypeName; }
            set { this.newsType.NewsTypeName = value; }
        }
    }
}
