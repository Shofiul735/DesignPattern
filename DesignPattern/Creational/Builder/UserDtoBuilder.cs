namespace DesignPattern.Creational.Builder;

public interface UserDtoBuilder
{
    public UserDtoBuilder WithFirstName(string firstName);
    public UserDtoBuilder WithLastName(string lastName);
    public UserDtoBuilder WithEmail(string email);
    public UserDtoBuilder WithPhoneNumber(string phoneNumber);
    public UserDtoBuilder WithAge(int age);
    public User Build();
}