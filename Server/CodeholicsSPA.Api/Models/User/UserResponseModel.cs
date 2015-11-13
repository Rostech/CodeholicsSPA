using AutoMapper;
using CodeholicsSPA.Api.Infrastructures.Mapping;
using CodeholicsSPA.Models;

namespace CodeholicsSPA.Api.Models
{
    public class UserResponseModel : IMapFrom<User>
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}
