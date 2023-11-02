namespace DemoWebVuota
{
    public class A
    {
        private readonly MyInterface myInterface;
        private readonly IConfiguration configuration;

        public A(MyInterface myInterface, IConfiguration configuration)
        {
            Console.WriteLine("Sono nella classe A");
            this.myInterface = myInterface;
            this.configuration = configuration;
        }

        public string DoSomething()
        {
            return $"{configuration["SettingSpeciale"]}   {myInterface.Welcome()}";
            // return $"{configuration["MySetting2:A"]}   {myInterface.Welcome()}";
            // return $"Do something in class A:  {myInterface.MyMethod()}";
        }
    }

    //public class A1
    //{
    //    public A1(MyAbstractClass myAbstractClass)
    //    {
    //        myAbstractClass.MyMethod();
    //    }
    //}
}
