using AutoMapper;
using BooksProject.Models;

namespace BooksProject
{
    public class Mapper : Profile
    {
        public Mapper() 
        {
            CreateMap<AddUserDTO, Users>();
            CreateMap<Users, AddUserDTO>();
        }
    }
}
