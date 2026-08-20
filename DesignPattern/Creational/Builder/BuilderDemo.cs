namespace DesignPattern.Creational.Builder;

public class BuilderDemo
{
    public static void Run()
    {
        var userDto = new AdminUserDtoBuildler().
                                        WithAge(10)
                                        .WithEmail("abc@abc.com")
                                        .WithFirstName("John")
                                        .WithLastName("Doe")
                                        .WithPhoneNumber("01983938900").Build();
        
        Console.WriteLine($"AdminUser created: {userDto.ToString()}");
    }
    
    
}