namespace DesignPattern.Creational.Builder;

public interface IUserDtoBuilder
{
    public IUserDtoBuilder WithFirstName(string firstName);
    public IUserDtoBuilder WithLastName(string lastName);
    public IUserDtoBuilder WithEmail(string email);
    public IUserDtoBuilder WithPhoneNumber(string phoneNumber);
    public IUserDtoBuilder WithAge(int age);
    public User Build();
}