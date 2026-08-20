namespace DesignPattern.Creational.Builder;

public class AdminUserDtoBuildler : UserDtoBuilder
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNumber;
    private int _age;

    public UserDtoBuilder WithFirstName(string firstName)
    {
        _firstName = firstName;
        return this;
    }

    public UserDtoBuilder WithLastName(string lastName)
    {
        _lastName = lastName;
        return this;
    }

    public UserDtoBuilder WithEmail(string email)
    {
        _email = email;
        return this;
    }

    public UserDtoBuilder WithPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
        return this;
    }

    public UserDtoBuilder WithAge(int age)
    {
        _age = age;
        return this;
    }

    public User Build()
    {
        return new User(_firstName, _lastName, _email, _phoneNumber, _age);
    }
}