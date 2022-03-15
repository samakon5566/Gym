using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CFitnessVideoViewModel
    {
        private FitnessVideo _fitnessVideo = null;
        public FitnessVideo fitnessVideo
        {
            get
            {
                if (_fitnessVideo == null)
                    _fitnessVideo = new FitnessVideo();
                return _fitnessVideo;
            }
            set { _fitnessVideo = value; }
        }
        public int FitnessVideoId
        {
            get { return this.fitnessVideo.FitnessVideoId; }
            set { this.fitnessVideo.FitnessVideoId = value; }
        }
        [DisplayName("影片名稱")]
        public string FitnessVideoTitle
        {
            get { return this.fitnessVideo.FitnessVideoTitle; }
            set { this.fitnessVideo.FitnessVideoTitle = value; }
        }
        [DisplayName("影片內容")]
        public string FitnessVideoContent
        {
            get { return this.fitnessVideo.FitnessVideoContent; }
            set { this.fitnessVideo.FitnessVideoContent = value; }
        }
        [DisplayName("網址")]
        public string FitnessVideoUrl
        {
            get { return this.fitnessVideo.FitnessVideoUrl; }
            set { this.fitnessVideo.FitnessVideoUrl = value; }
        }

        [DisplayName("影片上傳時間")]
        public DateTime FitnessVideoTime
        {
            get { return this.fitnessVideo.FitnessVideoTime; }
            set { this.fitnessVideo.FitnessVideoTime = value; }
        }

        [DisplayName("上傳教練編號")]
        public int FitnessVideoCoachId
        {
            get { return this.fitnessVideo.FitnessVideoCoachId; }
            set { this.fitnessVideo.FitnessVideoCoachId = value; }
        }


        [DisplayName("教練名稱")]
        public string FitnessVideoCoachName
        {
            get { return this.fitnessVideo.FitnessVideoCoach.CoachNavigation.LogInName; }
            set { this.fitnessVideo.FitnessVideoCoach.CoachNavigation.LogInName = value; }
        }


        [DisplayName("課程種類編號")]
        public int FitnessVideoCourseCategoryId
        {
            get { return this.fitnessVideo.FitnessVideoCourseCategoryId; }
            set { this.fitnessVideo.FitnessVideoCourseCategoryId = value; }
        }
        
    }
}
