namespace ExamRepetition
{
    public class ClassA
    {

        public string MyString { get; set; } = "Hello";
        int _MyProperty;
        public int MyProperty
        {
            get => _MyProperty;
            set
            {
                if (value != 0)
                    _MyProperty = value;
            }
        }
        public ClassA()
        {
            //Very difficult task to calculate _MyProperty
            _MyProperty = int.MaxValue;
        }

        public void Deconstruct(out int myproperty, out string myString)
        {
            myproperty = MyProperty;
            myString = MyString;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var myA = new ClassA();
            myA.MyProperty = 0;
            myA.MyString = "Martin";

            (int i, string s) = myA;
            System.Console.WriteLine(i);
            System.Console.WriteLine(s);



        }
    }
}
