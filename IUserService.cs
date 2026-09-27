public interface IUserService
{
    void AddUser(User user); 
    List<User> GetAll();
    void Update(User user);
    void Delete(User user); 

}