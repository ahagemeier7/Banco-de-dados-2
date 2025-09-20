﻿using ef_teste.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ef_teste.Controllers
{
    public class StudentCoursesController : Controller
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IStudentCoursesRepository _studentCoursesRepository;
        
        public StudentCoursesController(ICourseRepository courseRepository, IStudentRepository studentRepository, IStudentCoursesRepository studentCoursesRepository)
        {
            _courseRepository = courseRepository;
            _studentRepository = studentRepository;
            _studentCoursesRepository = studentCoursesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
