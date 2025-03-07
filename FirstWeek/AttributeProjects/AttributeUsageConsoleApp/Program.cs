using AttributeUsageConsoleApp;
using CustomAttributes;

//User user1 = new User { firstName = "Murat", lastName = "Mutlu", email = "muratmutlu010@gmail.com" };
//User user2 = new User { firstName = "Ali", lastName = "Veli", email = "" };

//Console.WriteLine("Geçerli mi ?: " + CustomRequiredFieldAttribute.IsValid(user1)); // True
//Console.WriteLine("Geçerli mi ?: " + CustomRequiredFieldAttribute.IsValid(user2)); // False

User user = new User();

Console.Write("First Name: ");
user.firstName = Console.ReadLine();

Console.Write("Last Name: ");
user.lastName = Console.ReadLine();

Console.Write("Email: ");
user.email = Console.ReadLine();

bool isValid = CustomRequiredFieldAttribute.IsValid(user);

if (isValid)
{
    Console.WriteLine("Kullanıcı doğrulaması başarılı.");
}
else
{
    Console.WriteLine("Kullanıcı doğrulaması başarısız. Eksik alan mevcut!");
}

