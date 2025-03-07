using System.Reflection;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class CustomRequiredFieldAttribute : Attribute
    {
        public static bool IsValid(object value)
        {
            if (value == null) return false;

            Type type = value.GetType();
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                object[] customFieldAttr = field.GetCustomAttributes(typeof(CustomRequiredFieldAttribute), true);
                if (customFieldAttr.Length != 0)
                {
                    string fieldValue = field.GetValue(value) as string;
                    if (string.IsNullOrEmpty(fieldValue))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
