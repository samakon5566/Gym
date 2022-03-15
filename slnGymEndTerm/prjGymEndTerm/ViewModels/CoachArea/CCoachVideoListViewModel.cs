using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.CoachArea
{
    public class CCoachVideoListViewModel
    {
        FitnessVideo _video = null;
        public FitnessVideo video
        {
            get
            {
                if (_video == null)
                    _video = new FitnessVideo();
                return _video;
            }
            set { _video = value; }
        }
        [DisplayName("影片ID")]
        public int VideoId
        {
            get { return this.video.FitnessVideoId; }
            set { this.video.FitnessVideoId = value; }
        }
        [DisplayName("影片標題")]
        public string VideoTitle
        {
            get { return this.video.FitnessVideoTitle; }
            set { this.video.FitnessVideoTitle = value; }
        }
        [DisplayName("影片描述")]
        public string VideoContent
        {
            get { return this.video.FitnessVideoContent; }
            set { this.video.FitnessVideoContent = value; }
        }
        [DisplayName("影片連結")]
        public string VideoUrl
        {
            get { return this.video.FitnessVideoUrl; }
            set { this.video.FitnessVideoUrl = value; }
        }
        [DisplayName("上傳時間")]
        public DateTime VideoUploadTime
        {
            get { return this.video.FitnessVideoTime; }
            set { this.video.FitnessVideoTime = value; }
        }
        [DisplayName("影片類別")]
        public String VideoCategory
        {
            get { return this.video.FitnessVideoCourseCategory.CourseCategoryName; }
            set { this.video.FitnessVideoCourseCategory.CourseCategoryName = value; }
        }


    }
}
