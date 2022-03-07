namespace nmnielsen.Service.Interfaces;
public interface IUserService
{
    /// <summary>
    /// Checks if the user thats logged in have the giving role,
    /// and returns true if it has and false if not.
    /// </summary>
    /// <returns>True/False</returns>
    Task<bool> CheckUserPermission(string neededRole);
}