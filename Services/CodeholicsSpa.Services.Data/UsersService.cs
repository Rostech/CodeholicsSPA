namespace CodeholicsSPA.Services.Data
{
    using System.Linq;
    using Models;
    using CodeholicsSPA.Data;
    using Codeholics.Common.Constants;
    using Contracts;

    public class UsersService : IUsersService
    {
        private ICodeholicsSPAData data;

        public UsersService(ICodeholicsSPAData data)
        {
            this.data = data;
        }

        public IQueryable<User> All(int page = 1, int pageSize = Defaults.DefaultPageSize)
        {
            return this.data.Users
                .All()
                .OrderBy(u => u.UserName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<User> ById(string id)
        {
            return data.Users
                .All()
                .Where(u => u.Id == id);
        }
    }
}
