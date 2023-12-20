namespace Beblio.Domain.Iterfaces;

internal interface IUsers
{
    Task<UsersDTO> FindByIdAsync(int id);
    Task<Enumerable<UsersDTO>> FindAllAsync();
    Task<UsersDTO> CreateAsync(UpdateUsersDTO entity);
}
