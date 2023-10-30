namespace DemoWebVuota
{
    public class C : MyInterface
    {
        Random random = new Random();
        public C()
        {
            
        }
        public int MyMethod()
        {
            Console.WriteLine("My method in C");
            return random.Next();
        }

        public string Welcome()
        {
            throw new NotImplementedException();
        }
    }


    public class B: MyInterface
    {
        private readonly IMyTime myTime;
        private int i = 0;

        public B(IMyTime myTime)
        {
            Console.WriteLine("Sono nella classe B");
            this.myTime = myTime;
        }

        public int MyMethod()
        {
            Console.WriteLine(i); ;
            return i++;            
        }

        public string Welcome()
        {
            if(myTime.Now().Hour < 12)
            {
                return "Buongiorno";
            } else if (myTime.Now().Hour < 18)
            {
                return "Buon pomeriggio";
            } else
            {
                return "Buona notte";
            }
        }
    }

    public class FakeTime : IMyTime
    {
        public DateTime Now()
        {
            return new DateTime(2021, 1, 1, 9, 0, 0);
        }
    }

    public class RealTime : IMyTime
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }


    public interface MyInterface
    {
        int MyMethod();
        string Welcome();
       // int i { get; set; }
    }


    public interface IMyTime
    {
        public DateTime Now();
    }

    //public abstract class MyAbstractClass
    //{
    //    public abstract void MyMethod();
    //}
    //public class  C1: MyAbstractClass
    //{
    //    public override void MyMethod()
    //    {
    //        Console.WriteLine("My method in B1"); ;
    //    }
    //}

    //public class B1: MyAbstractClass
    //{
    //    public override void MyMethod()
    //    {
    //        Console.WriteLine("My method in B1"); ;
    //    }
    //}


}
