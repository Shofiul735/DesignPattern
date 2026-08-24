namespace DesignPattern.Creational.Builder;

public class AdminUserDtoBuildler : IUserDtoBuilder
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNumber;
    private int _age;

    public IUserDtoBuilder WithFirstName(string firstName)
    {
        _firstName = firstName;
        return this;
    }

    public IUserDtoBuilder WithLastName(string lastName)
    {
        _lastName = lastName;
        return this;
    }

    public IUserDtoBuilder WithEmail(string email)
    {
        _email = email;
        return this;
    }

    public IUserDtoBuilder WithPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
        return this;
    }

    public IUserDtoBuilder WithAge(int age)
    {
        _age = age;
        return this;
    }

    public User Build()
    {
        return new User(_firstName, _lastName, _email, _phoneNumber, _age);
    }
}