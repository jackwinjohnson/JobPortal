using AutoMapper;
using JobPortal.DataAccess.Models;
using JobPortal.DataAccess.PortalRepository;
using JobPortal.Dtos.Dtos;
using JobPortal.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Service.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;
        private readonly IMapper _mapper;
        public CourseService (IRepository<Course> courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<CourseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
