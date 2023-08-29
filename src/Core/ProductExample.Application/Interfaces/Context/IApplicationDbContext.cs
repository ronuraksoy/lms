using Microsoft.EntityFrameworkCore;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Educations> Educations { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<StudentAnswers> StudentAnswers { get; set; }
        public DbSet<StudentAssesments> StudentAssesments { get; set; }
        public DbSet<ValidAnswers> ValidAnswers { get; set; }
        public DbSet<ExamsQuestions> ExamsQuestions { get; set; }
        public DbSet<AchievementCategory> AchievementCategories { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<EducationAssignments> EducationAssignments { get; set; }
        public DbSet<StudentAssignments> StudentAssignments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<AssignmentResult> AssignmentResults { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventSpeakers> EventSpeakers { get; set; }
        public DbSet<EventParticipants> EventParticipants { get; set; }
        public DbSet<EventParticipantsAnswer> EventParticipantsAnswers { get; set; }
        public DbSet<EventQuestions> EventQuestions { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<BookRecommendations> BookRecommendations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<StudentQuestions> studentQuestions { get; set; }
        public DbSet<StudentExamEntitlement> StudentExamEntitlements { get; set; }
        public DbSet<StudentExamLogs> StudentExamLogs { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CurriculumLesson> CurriculumLessons { get; set; }
        public DbSet<Classrooms> Classrooms { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<AnnouncementStudent> AnnouncementStudent { get; set; }
        public DbSet<ExamsQuestionsReport> examsQuestionsReports { get; set; }
    }
}
