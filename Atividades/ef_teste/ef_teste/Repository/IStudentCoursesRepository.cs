using ef_teste.Models;

namespace ef_teste.Repository
{
    public interface IStudentCoursesRepository
    {
        public Task Create(StudentCourses studentCourses);
        public Task Update(StudentCourses studentCourses);
        public Task Delete(StudentCourses studentCourses);
        public Task<List<StudentCourses>> GetByStudentId(int studentId);
        public Task<List<StudentCourses>> GetByCourseId(int courseId);
        public Task<List<StudentCourses>> Get(int courseId,int studentId);
        public Task<List<StudentCourses>> GetAll();
        public Task<List<StudentCourses>> GetByCourseName(string name);
        public Task<List<StudentCourses>> GetByStudentName(string name);

    }
}
