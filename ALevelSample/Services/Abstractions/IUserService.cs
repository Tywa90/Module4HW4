using System.Threading.Tasks;
using ALevelSample.Models;

namespace ALevelSample.Services.Abstractions;

public interface IUserService
{
    Task<string> AddUser(string firstName, string lastName);

    Task<User> GetUser(string id);

    Task<User> UpdateUser(string id, string updateName, string updateLastName);

    Task<bool> DeleteUser(string id);
}