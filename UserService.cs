using System.Security.Cryptography.X509Certificates;

public class UserService: IUserService
{
    List<User> users = new List<User>();
    public void AddUser(User user)
    {
        users.Add(user);
    }
    public void Delete(User user)
    {
       users.Remove(user);
    }
    public List<User> GetAll()
    {
        return users;
    }
    public void Update(User user)
    {
        foreach(var item in users)
        {
            if(item.id == user.id)
            {
                item.Name = user.Name;
                item.SurName = user.SurName;
                
            }
        }
    }
}