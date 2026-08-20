namespace DesignPattern.Creational.Builder;

public class Program
{
    public static void Main(string[] args)
    {
        var userDto = new AdminUserDtoBuildler().
                                        WithAge(10)
                                        .WithEmail("abc@abc.com")
                                        .WithFirstName("John")
                                        .WithLastName("Doe")
                                        .WithPhoneNumber("01983938900").Build();
        
        Console.WriteLine(userDto);
    }
}