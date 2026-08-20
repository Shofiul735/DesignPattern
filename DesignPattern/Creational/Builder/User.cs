namespace DesignPattern.Creational.Builder;

public class User
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNumber;
    private int _age;
    
    public User(
        string firstName, 
        string lastName,
        string email,
        string phoneNumber,
        int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phoneNumber = phoneNumber;
        _age = age;
    }
    
    
}