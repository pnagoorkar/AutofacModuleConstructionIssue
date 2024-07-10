using Autofac;

namespace AutofacModuleConstructionIssue
{
    public class MyModule : Module
    {
        public MyModule(ParameterType1 parameterType1)
        {
            Console.WriteLine($"Hello from constructor 1");
            Console.WriteLine();
        }
        public MyModule(ParameterType2 parameterType2)
        {
            Console.WriteLine($"Hello from constructor 2");
            Console.WriteLine();
        }
        public MyModule(ParameterType1 parameterType1, ParameterType2 parameterType2)
        {
            Console.WriteLine($"Hello from constructor 3");
            Console.WriteLine();
        }
    }
    public class ParameterType1
    {
        public string Str1 { get; set; }
    }

    public class ParameterType2
    {
        public string Str2 { get; set; }
    }
}
