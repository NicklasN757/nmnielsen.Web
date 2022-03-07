using nmnielsen.Repository.Interfaces;
using nmnielsen.Service.Interfaces;

namespace nmnielsen.Service.Services;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    //Calls and logs(not) the "CheckUserPermission" function from the UserRepository
    public async Task<bool> CheckUserPermission(string neededRole)
    {
        try
        {
            bool tmpBool = await _userRepository.CheckUserPermission(neededRole);

            return tmpBool;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}