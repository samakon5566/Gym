using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class GYMContext : DbContext
    {
        public GYMContext()
        {
        }

        public GYMContext(DbContextOptions<GYMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendanceType> AttendanceTypes { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CourseCategory> CourseCategories { get; set; }
        public virtual DbSet<CourseClass> CourseClasses { get; set; }
        public virtual DbSet<CourseDetail> CourseDetails { get; set; }
        public virtual DbSet<CustomerLetter> CustomerLetters { get; set; }
        public virtual DbSet<Dicount> Dicounts { get; set; }
        public virtual DbSet<DiscountPlan> DiscountPlans { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentCategory> EquipmentCategories { get; set; }
        public virtual DbSet<EquipmentRestoration> EquipmentRestorations { get; set; }
        public virtual DbSet<FitnessVideo> FitnessVideos { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<LetterStatus> LetterStatuses { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<LoginType> LoginTypes { get; set; }
        public virtual DbSet<MemberLesson> MemberLessons { get; set; }
        public virtual DbSet<MemberScore> MemberScores { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsTypes { get; set; }
        public virtual DbSet<OrderCourse> OrderCourses { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PostureChange> PostureChanges { get; set; }
        public virtual DbSet<RefundReason> RefundReasons { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=GYM;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<AttendanceType>(entity =>
            {
                entity.ToTable("Attendance_Type");

                entity.Property(e => e.AttendanceTypeId).HasColumnName("Attendance_TypeID");

                entity.Property(e => e.AttendanceName)
                    .HasMaxLength(10)
                    .HasColumnName("Attendance_Name");
            });

            modelBuilder.Entity<Classroom>(entity =>
            {
                entity.ToTable("Classroom");

                entity.Property(e => e.ClassroomId).HasColumnName("Classroom_ID");

                entity.Property(e => e.ClassroomAccommodation).HasColumnName("Classroom_Accommodation");

                entity.Property(e => e.ClassroomName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Classroom_Name");
            });

            modelBuilder.Entity<Coach>(entity =>
            {
                entity.ToTable("Coach");

                entity.Property(e => e.CoachId)
                    .ValueGeneratedNever()
                    .HasColumnName("Coach_ID");

                entity.Property(e => e.CoachAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Coach_Address");

                entity.Property(e => e.CoachBackground).HasColumnName("Coach_Background");

                entity.Property(e => e.CoachExperience).HasColumnName("Coach_Experience");

                entity.HasOne(d => d.CoachNavigation)
                    .WithOne(p => p.Coach)
                    .HasForeignKey<Coach>(d => d.CoachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coach_LogIn");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("Company_ID");

                entity.Property(e => e.ComapnyPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Comapny_phone");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Company_Name");

                entity.Property(e => e.CompanyTaxId).HasColumnName("Company_TaxID");
            });

            modelBuilder.Entity<CourseCategory>(entity =>
            {
                entity.ToTable("CourseCategory");

                entity.Property(e => e.CourseCategoryId).HasColumnName("CourseCategory_ID");

                entity.Property(e => e.CourseCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CourseCategory_Name");
            });

            modelBuilder.Entity<CourseClass>(entity =>
            {
                entity.ToTable("CourseClass");

                entity.Property(e => e.CourseClassId).HasColumnName("CourseClass_ID");

                entity.Property(e => e.CourseClassClassroomId).HasColumnName("CourseClass_ClassroomID");

                entity.Property(e => e.CourseClassCoachId).HasColumnName("CourseClass_CoachID");

                entity.Property(e => e.CourseClassDetailId).HasColumnName("CourseClass_Detail_ID");

                entity.Property(e => e.CourseClassName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CourseClass_Name");

                entity.Property(e => e.CourseClassPeople).HasColumnName("CourseClass_people");

                entity.Property(e => e.CourseClassPlanId).HasColumnName("CourseClass_PlanID");

                entity.HasOne(d => d.CourseClassClassroom)
                    .WithMany(p => p.CourseClasses)
                    .HasForeignKey(d => d.CourseClassClassroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseClass_Classroom");

                entity.HasOne(d => d.CourseClassCoach)
                    .WithMany(p => p.CourseClasses)
                    .HasForeignKey(d => d.CourseClassCoachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseClass_Coach");

                entity.HasOne(d => d.CourseClassDetail)
                    .WithMany(p => p.CourseClasses)
                    .HasForeignKey(d => d.CourseClassDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseClass_CourseDetail");

                entity.HasOne(d => d.CourseClassPlan)
                    .WithMany(p => p.CourseClasses)
                    .HasForeignKey(d => d.CourseClassPlanId)
                    .HasConstraintName("FK_CourseClass_Discount_Plan");
            });

            modelBuilder.Entity<CourseDetail>(entity =>
            {
                entity.ToTable("CourseDetail");

                entity.Property(e => e.CourseDetailId).HasColumnName("CourseDetail_ID");

                entity.Property(e => e.CourseCategoryId).HasColumnName("CourseCategory_ID");

                entity.Property(e => e.CourseDetailCal).HasColumnName("CourseDetail_Cal");

                entity.Property(e => e.CourseDetailIntroduce).HasColumnName("CourseDetail_introduce");

                entity.Property(e => e.CourseDetailMoney).HasColumnName("CourseDetail_Money");

                entity.Property(e => e.CourseDetailName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CourseDetail_Name");

                entity.Property(e => e.CourseDetailPicture).HasColumnName("CourseDetail_Picture");

                entity.Property(e => e.CourseDetailTime).HasColumnName("CourseDetail_Time");

                entity.HasOne(d => d.CourseCategory)
                    .WithMany(p => p.CourseDetails)
                    .HasForeignKey(d => d.CourseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseMaster_CourseCategory");
            });

            modelBuilder.Entity<CustomerLetter>(entity =>
            {
                entity.HasKey(e => e.LetterId)
                    .HasName("PK_Customer_Letter_1");

                entity.ToTable("Customer_Letter");

                entity.Property(e => e.LetterId).HasColumnName("Letter_ID");

                entity.Property(e => e.LetterContent)
                    .IsRequired()
                    .HasColumnName("Letter_Content");

                entity.Property(e => e.LetterEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Letter_Email");

                entity.Property(e => e.LetterManergerContent).HasColumnName("Letter_ManergerContent");

                entity.Property(e => e.LetterManergerId).HasColumnName("Letter_ManergerID");

                entity.Property(e => e.LetterName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Letter_Name");

                entity.Property(e => e.LetterPhone)
                    .HasMaxLength(10)
                    .HasColumnName("Letter_Phone")
                    .IsFixedLength(true);

                entity.Property(e => e.LetterStatusId).HasColumnName("Letter_StatusID");

                entity.Property(e => e.LetterTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Letter_Time");

                entity.HasOne(d => d.LetterManerger)
                    .WithMany(p => p.CustomerLetters)
                    .HasForeignKey(d => d.LetterManergerId)
                    .HasConstraintName("FK_Customer_Letter_LogIn2");

                entity.HasOne(d => d.LetterStatus)
                    .WithMany(p => p.CustomerLetters)
                    .HasForeignKey(d => d.LetterStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Letter_Letter_Status");
            });

            modelBuilder.Entity<Dicount>(entity =>
            {
                entity.ToTable("Dicount");

                entity.Property(e => e.DicountId).HasColumnName("Dicount_ID");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("Discount_Percent");
            });

            modelBuilder.Entity<DiscountPlan>(entity =>
            {
                entity.ToTable("Discount_Plan");

                entity.Property(e => e.DiscountPlanId).HasColumnName("Discount_planID");

                entity.Property(e => e.DicountId).HasColumnName("DicountID");

                entity.Property(e => e.DiscountPlan1)
                    .IsRequired()
                    .HasColumnName("Discount_plan");

                entity.HasOne(d => d.Dicount)
                    .WithMany(p => p.DiscountPlans)
                    .HasForeignKey(d => d.DicountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discount_Plan_Dicount");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.EquipmentId).HasColumnName("Equipment_ID");

                entity.Property(e => e.EquipmentCategoryId).HasColumnName("Equipment_CategoryID");

                entity.Property(e => e.EquipmentClassroomId).HasColumnName("Equipment_ClassroomID");

                entity.Property(e => e.EquipmentCompanyId).HasColumnName("Equipment_CompanyID");

                entity.Property(e => e.EquipmentCycle).HasColumnName("Equipment_Cycle");

                entity.Property(e => e.EquipmentDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_Day");

                entity.HasOne(d => d.EquipmentCategory)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Equipment_Category");

                entity.HasOne(d => d.EquipmentClassroom)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentClassroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Classroom");

                entity.HasOne(d => d.EquipmentCompany)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Company");
            });

            modelBuilder.Entity<EquipmentCategory>(entity =>
            {
                entity.ToTable("Equipment_Category");

                entity.Property(e => e.EquipmentCategoryId).HasColumnName("Equipment_CategoryID");

                entity.Property(e => e.EquipmentCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Equipment_CategoryName");

                entity.Property(e => e.EquipmentPicture).HasColumnName("Equipment_Picture");
            });

            modelBuilder.Entity<EquipmentRestoration>(entity =>
            {
                entity.HasKey(e => e.RestorationId);

                entity.ToTable("Equipment_Restoration");

                entity.Property(e => e.RestorationId).HasColumnName("RestorationID");

                entity.Property(e => e.EquipmentId).HasColumnName("Equipment_ID");

                entity.Property(e => e.EquipmentServiceDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_ServiceDay");

                entity.Property(e => e.EquipmentStayServiceDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Equipment_stayServiceDay");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.EquipmentRestorations)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Restoration_Equipment1");
            });

            modelBuilder.Entity<FitnessVideo>(entity =>
            {
                entity.ToTable("FitnessVideo");

                entity.Property(e => e.FitnessVideoId).HasColumnName("FitnessVideo_ID");

                entity.Property(e => e.FitnessVideoCoachId).HasColumnName("FitnessVideo_CoachID");

                entity.Property(e => e.FitnessVideoContent)
                    .IsRequired()
                    .HasColumnName("FitnessVideo_Content");

                entity.Property(e => e.FitnessVideoCourseCategoryId).HasColumnName("FitnessVideo_CourseCategoryID");

                entity.Property(e => e.FitnessVideoTime)
                    .HasColumnType("datetime")
                    .HasColumnName("FitnessVideo_Time");

                entity.Property(e => e.FitnessVideoTitle)
                    .IsRequired()
                    .HasColumnName("FitnessVideo_Title");

                entity.Property(e => e.FitnessVideoUrl)
                    .IsRequired()
                    .HasColumnName("FitnessVideo_URL");

                entity.HasOne(d => d.FitnessVideoCoach)
                    .WithMany(p => p.FitnessVideos)
                    .HasForeignKey(d => d.FitnessVideoCoachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FitnessVideo_Coach");

                entity.HasOne(d => d.FitnessVideoCourseCategory)
                    .WithMany(p => p.FitnessVideos)
                    .HasForeignKey(d => d.FitnessVideoCourseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FitnessVideo_CourseCategory");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("Lesson");

                entity.Property(e => e.LessonId).HasColumnName("Lesson_ID");

                entity.Property(e => e.LessonClassId).HasColumnName("Lesson_ClassID");

                entity.Property(e => e.LessonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Lesson_Time");

                entity.HasOne(d => d.LessonClass)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.LessonClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_CourseClass");
            });

            modelBuilder.Entity<LetterStatus>(entity =>
            {
                entity.ToTable("Letter_Status");

                entity.Property(e => e.LetterStatusId).HasColumnName("Letter_StatusID");

                entity.Property(e => e.LetterStatusName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Letter_StatusName");
            });

            modelBuilder.Entity<LogIn>(entity =>
            {
                entity.ToTable("LogIn");

                entity.Property(e => e.LogInId).HasColumnName("LogIn_ID");

                entity.Property(e => e.LogInAccount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("LogIn_Account");

                entity.Property(e => e.LogInBrithDay)
                    .HasColumnType("datetime")
                    .HasColumnName("LogIn_BrithDay");

                entity.Property(e => e.LogInEmail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("LogIn_Email");

                entity.Property(e => e.LogInGender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("LogIn_Gender");

                entity.Property(e => e.LogInHeight)
                    .HasColumnType("decimal(4, 1)")
                    .HasColumnName("LogIn_Height");

                entity.Property(e => e.LogInIdNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("LogIn_IdNumber");

                entity.Property(e => e.LogInName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("LogIn_Name");

                entity.Property(e => e.LogInPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LogIn_Password");

                entity.Property(e => e.LogInPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("LogIn_Phone");

                entity.Property(e => e.LogInRegisterTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LogIn_RegisterTime");

                entity.Property(e => e.LogInTypeId).HasColumnName("LogIn_TypeID");

                entity.Property(e => e.LogInWeight)
                    .HasColumnType("decimal(4, 1)")
                    .HasColumnName("LogIn_Weight");

                entity.Property(e => e.LoginFigure).HasColumnName("Login_Figure");

                entity.HasOne(d => d.LogInType)
                    .WithMany(p => p.LogIns)
                    .HasForeignKey(d => d.LogInTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Member_Type");
            });

            modelBuilder.Entity<LoginType>(entity =>
            {
                entity.ToTable("LoginType");

                entity.Property(e => e.LoginTypeId).HasColumnName("LoginType_ID");

                entity.Property(e => e.LoginTypeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("LoginType_Name");
            });

            modelBuilder.Entity<MemberLesson>(entity =>
            {
                entity.ToTable("Member_Lesson");

                entity.Property(e => e.MemberLessonId).HasColumnName("MemberLesson_ID");

                entity.Property(e => e.AttendanceTypeId).HasColumnName("Attendance_TypeID");

                entity.Property(e => e.MemberLessonLessonId).HasColumnName("MemberLesson_LessonID");

                entity.Property(e => e.MemberLessonMemberId).HasColumnName("MemberLesson_MemberID");

                entity.HasOne(d => d.AttendanceType)
                    .WithMany(p => p.MemberLessons)
                    .HasForeignKey(d => d.AttendanceTypeId)
                    .HasConstraintName("FK_MemberLesson_Attendance_Type");

                entity.HasOne(d => d.MemberLessonLesson)
                    .WithMany(p => p.MemberLessons)
                    .HasForeignKey(d => d.MemberLessonLessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberLesson_Lesson");

                entity.HasOne(d => d.MemberLessonMember)
                    .WithMany(p => p.MemberLessons)
                    .HasForeignKey(d => d.MemberLessonMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Lesson_LogIn");
            });

            modelBuilder.Entity<MemberScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId);

                entity.ToTable("Member_Score");

                entity.Property(e => e.ScoreId).HasColumnName("Score_ID");

                entity.Property(e => e.ClassRecord).HasColumnType("datetime");

                entity.Property(e => e.CourseClassId).HasColumnName("CourseClassID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.HasOne(d => d.CourseClass)
                    .WithMany(p => p.MemberScores)
                    .HasForeignKey(d => d.CourseClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Score_CourseClass");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberScores)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Score_LogIn");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId).HasColumnName("News_ID");

                entity.Property(e => e.NewsContent)
                    .IsRequired()
                    .HasColumnName("News_Content");

                entity.Property(e => e.NewsFigure).HasColumnName("News_Figure");

                entity.Property(e => e.NewsManagerId).HasColumnName("News_ManagerID");

                entity.Property(e => e.NewsTime)
                    .HasColumnType("datetime")
                    .HasColumnName("News_Time");

                entity.Property(e => e.NewsTitle)
                    .IsRequired()
                    .HasColumnName("News_Title");

                entity.Property(e => e.NewsTypeId).HasColumnName("News_TypeID");

                entity.HasOne(d => d.NewsManager)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_LogIn");

                entity.HasOne(d => d.NewsType)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_News_Type");
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.ToTable("News_Type");

                entity.Property(e => e.NewsTypeId).HasColumnName("NewsType_ID");

                entity.Property(e => e.NewsTypeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NewsType_Name");
            });

            modelBuilder.Entity<OrderCourse>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Order_Course");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.OrderClassId).HasColumnName("Order_ClassID");

                entity.Property(e => e.OrderMemberId).HasColumnName("Order_MemberID");

                entity.Property(e => e.OrderPaymentId).HasColumnName("Order_PaymentID");

                entity.Property(e => e.OrderReasonId).HasColumnName("Order_ReasonID");

                entity.Property(e => e.OrderReasonMoney)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Order_ReasonMoney")
                    .IsFixedLength(true);

                entity.Property(e => e.OrderReviseTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_ReviseTime");

                entity.Property(e => e.OrderStatusId).HasColumnName("Order_StatusID");

                entity.Property(e => e.OrderTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_Time");

                entity.HasOne(d => d.OrderClass)
                    .WithMany(p => p.OrderCourses)
                    .HasForeignKey(d => d.OrderClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Course_CourseClass");

                entity.HasOne(d => d.OrderMember)
                    .WithMany(p => p.OrderCourses)
                    .HasForeignKey(d => d.OrderMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Course_LogIn");

                entity.HasOne(d => d.OrderPayment)
                    .WithMany(p => p.OrderCourses)
                    .HasForeignKey(d => d.OrderPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Course_Payment");

                entity.HasOne(d => d.OrderReason)
                    .WithMany(p => p.OrderCourses)
                    .HasForeignKey(d => d.OrderReasonId)
                    .HasConstraintName("FK_Order_Course_Refund_Reason1");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.OrderCourses)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_Order_Course_Refund_Reason");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_Reason");

                entity.ToTable("Order_Status");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.StatusContent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("status_Content");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Payment_Name");
            });

            modelBuilder.Entity<PostureChange>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Posture_Change");

                entity.Property(e => e.RecordId).HasColumnName("Record_ID");

                entity.Property(e => e.BasalMetabolism)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("Basal_Metabolism");

                entity.Property(e => e.Fat).HasColumnType("decimal(4, 1)");

                entity.Property(e => e.MuscleBass)
                    .HasColumnType("decimal(4, 1)")
                    .HasColumnName("Muscle_Bass");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(4, 1)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PostureChanges)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posture_Change_Order_Course");
            });

            modelBuilder.Entity<RefundReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("Refund_Reason");

                entity.Property(e => e.ReasonId).HasColumnName("Reason_ID");

                entity.Property(e => e.ReasonContent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Reason_Content");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RefundReasons)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Refund_Reason_Order_Status");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId).HasColumnName("Skill_ID");

                entity.Property(e => e.SkillCoachId).HasColumnName("Skill_CoachID");

                entity.Property(e => e.SkillCourseCategoryId).HasColumnName("Skill_CourseCategoryID");

                entity.HasOne(d => d.SkillCoach)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.SkillCoachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_Coach");

                entity.HasOne(d => d.SkillCourseCategory)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.SkillCourseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_CourseCategory");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
