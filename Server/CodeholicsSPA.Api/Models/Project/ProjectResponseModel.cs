namespace CodeholicsSPA.Api.Models.Project
{
    using Infrastructures.Mapping;
    using AutoMapper;
    using System;
    using CodeholicsSPA.Models;

    public class ProjectResponseModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? Deadline { get; set; }

        public string Creator { get; set; }

        public int TotalUsers { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<Project, ProjectResponseModel>()
                .ForMember(p => p.TotalUsers, opts => opts.MapFrom(p => p.Users.Count));
        }
    }
}
