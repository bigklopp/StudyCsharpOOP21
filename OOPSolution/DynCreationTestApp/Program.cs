using System;
using System.Reflection;

namespace DynCreationTestApp
{
    class Profile
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public void Print() { Console.WriteLine($"{Name}, {PhoneNumber}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile1 = new Profile
            {
                Name = "박찬호",
                PhoneNumber = "010-9975-5511"

            };
            profile1.Print();


            Type type = typeof(Profile);
            Object profile2 = Activator.CreateInstance(type);
            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo phonenumber = type.GetProperty("PhoneNumber");
            name.SetValue(profile2, "류현진", null);
            phonenumber.SetValue(profile2, "010-9999-9999",null);

            MethodInfo print = type.GetMethod("Print");
            print.Invoke(profile2, null);

        }
    }
}
