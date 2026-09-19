using System.Reflection;

namespace ConsoleApp46;

internal class ReflectionHelper
{
    public static void InspectAndInvoke(object obj)
    {
        var type = obj.GetType();
        var methods = type.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        foreach (var method in methods)
        {
            if (method.GetCustomAttributes(typeof(AuditLoggable), false).Length > 0)
            {
                Console.WriteLine($"Invoking method: {method.Name}");
                method.Invoke(obj, null);
            }
        }
        var fields = type.GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine($"Field: {field.Name}, Value: {field.GetValue(obj)}");
        }
    }
}
