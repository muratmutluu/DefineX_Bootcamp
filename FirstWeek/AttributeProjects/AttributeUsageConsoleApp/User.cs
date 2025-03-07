using CustomAttributes;

namespace AttributeUsageConsoleApp
{
    public class User
    {
        [CustomRequiredField]
        public string? firstName;

        [CustomRequiredField]
        public string? lastName;

        [CustomRequiredField]
        public string? email;
    }
}
