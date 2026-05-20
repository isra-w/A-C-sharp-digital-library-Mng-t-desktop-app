using d.labdemo.Repositories;

namespace d.labdemo.Services
{
    public class AuthService
    {
        private readonly UserRepository _repo;

        public AuthService()
        {
            _repo = new UserRepository();
        }

        public (bool Success, string? Role, string? Error) Login(string username, string password)
        {
            var creds = _repo.GetUserCredentialsByUsername(username);
            if (creds.PasswordHash == null)
            {
                return (false, null, "Record not found");
            }

            try
            {
                bool passwordVerified = BCrypt.Net.BCrypt.EnhancedVerify(password, creds.PasswordHash);
                if (!passwordVerified)
                {
                    return (false, null, "Invalid username or password");
                }

                return (true, creds.Role?.Trim(), null);
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
            finally
            {
                // DB connection closed by repository methods; nothing to do here
            }
        }
    }
}