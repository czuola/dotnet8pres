using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

Console.WriteLine("Hello, World!");
MethodInfo refreshMemoryLimitMethod = typeof(GC).GetMethod(
    "_RefreshMemoryLimit", BindingFlags.NonPublic | BindingFlags.Static);

refreshMemoryLimitMethod.Invoke(null, Array<object>.Empty);