using d.labdemo.Repositories;
using System.Data;

namespace d.labdemo.Services
{
    public class UserService
    {
        private readonly UserRepository _repo;
        public UserService()
        {
            _repo = new UserRepository();
        }

        public DataTable LoadUsersByRole(string role)
        {
            return _repo.GetUsersByRole(role);
        }

        public int UpdateUserRole(int userId, string role)
        {
            return _repo.UpdateUserRole(userId, role);
        }
    }
}