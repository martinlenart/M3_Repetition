using System;

namespace Properties
{
    public class AClass<T> where T:class
    {
        public T field1;
        public readonly T field2 = default;

        public T prop1 { get; set; }
        public T prop2 { get; init; }
        public T prop3 { get; }
        
        public T[] array1;
        public readonly T[] array2;

        public AClass ()
        {
            field1 = default;
            field2 = default;

            prop1 = default;
            prop2 = default;
            prop3 = default;

            array1 = new T[2];
            array1[0] = default;
            array1[1] = default;

            array2 = new T[2];
            array2[0] = default;
            array2[1] = default;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AClass<int> myInstance1 = new AClass<int>();

            myInstance1.field1 = 5;
 //           myInstance.field2 = 5;

            myInstance1.prop1 = 5;
//            myInstance.prop2 = 5;
//            myInstance.prop3 = 5;

            myInstance1.array1[0] = 5;
            myInstance1.array1[1] = 5;
            myInstance1.array1 = default;

            myInstance1.array2[0] = 5;
            myInstance1.array2[1] = 5;
            //            myInstance.array2 = new int[5];

            AClass<string> myInstance2 = new AClass<string>();
            myInstance2.field1 = "Hello";
            myInstance2.array1[0] = "Hello";
        }
    }
}
