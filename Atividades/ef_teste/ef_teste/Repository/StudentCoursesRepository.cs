
using ef_teste.Data;
using ef_teste.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ef_teste.Repository
{
    public class StudentCoursesRepository : IStudentCoursesRepository
    {
        private readonly SchoolContext _context;

        public StudentCoursesRepository(SchoolContext context)
        {
            _context = context;
        }
        public async Task Create(StudentCourses studentCourses)
        {
            await _context.StudentCourses.AddAsync(studentCourses);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(StudentCourses studentCourses)
        {
            _context.StudentCourses.Remove(studentCourses);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StudentCourses>> Get(int courseId, int studentId)
        {
            var data = await _context.StudentCourses.Include(x => x.Course).Include(x => x.Student)
                .Where(x => x.StudentId == studentId &&  x.CourseId == courseId).ToListAsync();
            return data!;
        }

        public async Task<List<StudentCourses>> GetAll()
        {
            var data = await _context.StudentCourses.Include(x => x.Course).Include(x => x.Student).ToListAsync();
            return data!;
        }

        public async Task<List<StudentCourses>> GetByCourseId(int courseId)
        {
            var student = await _context.StudentCourses.Where(s => s.CourseId == courseId).ToListAsync();
            return student;
        }

        public async Task<List<StudentCourses>> GetByCourseName(string name)
        {
            var data = await _context.StudentCourses.Include(x => x.Course).Include(x => x.Student)
                .Where(x => x.Course!.Name == name).ToListAsync();
            return data!;
        }

        public async Task<List<StudentCourses>> GetByStudentId(int studentId)
        {
            var student = await _context.StudentCourses.Where(s => s.StudentId == studentId).ToListAsync();
            return student;
        }

        public async Task<List<StudentCourses>> GetByStudentName(string name)
        {
            var data = await _context.StudentCourses.Include(x => x.Course).Include(x => x.Student)
                        .Where(x => x.Student!.FirstMidName == name || x.Student.LastName == name).ToListAsync();
            return data!;
        }

        public async Task Update(StudentCourses studentCourses)
        {
            _context.StudentCourses.Update(studentCourses);
            await _context.SaveChangesAsync();
        }

    }
}
