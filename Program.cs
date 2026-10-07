using c__Book;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections;
using System.Collections.Generic;


internal class Program
{
    public static void Main(string[] args)
    {
        //INTERFACES
        //    Console.WriteLine("Hello, World!");
        //    var obj = new DerivedInterface();

        //    obj.method1();
        //    obj.method2();
        //

        //GENERICS

        //var obj = new generics<int>();
        //obj.display(5);
        //var obj2 = new generics<string>();  
        //obj2.display("Hello");

        // LIST<T>
        //List<int> numbers = new List<int>();
        //numbers.Add(1);     
        //numbers.Add(2);
        //numbers.Add(3);
        //numbers.Add(4);
        //foreach (var i in numbers) {
        //    Console.WriteLine(i);
        //}

        //GENERIC CLASS

        //var obj = new GenericClass<int>("Integer", 5);
        //var obj2 = new GenericClass<string>("String", "Hello");
        //var obj3 = new GenericClass<double>("Double", 25.5);


        //GENERIC METHOD

        //var a = 20; var b = 30;
        //var obj = new GenericMethod();
        //obj.Swap<int>(ref a, ref b);
        //Console.WriteLine($"Variable A : {a} , Variable B : {b}");

        //EXTENTION METHOD

        // string name = "Mandeep";
        // Console.WriteLine(name);

        //Console.WriteLine( name.Greet());


        //ARRAY 

        //int[] arr = new int[4];
        //Console.WriteLine(arr[1]);

        // person class obj array

        //Person[] personarr = { new Person { name = "Chaitanya", age = 20 },
        //                       new Person { name = "Mandeep" , age = 23 },
        //                       new Person { name = "Rajat" , age = 21 }
        //} ;

        //foreach (Person i in personarr)
        //{
        //    Console.WriteLine($"Name = {i.name} , Age = {i.age}");
        //}


        //2d array

        //int[,] array = new int[4, 4]

        // { { 1,2,3,4 },{ 5,6,7,8 },{ 9,10,11,12},{ 13,14,15,16 } };

        //for (int i = 0; i < array.GetLength(0); i++)
        //{
        //    for (int j = 0; j < array.GetLength(1); j++)
        //    {
        //        Console.Write(array[i,j]+ " ");
        //    }
        //    Console.WriteLine("");
        //}

        //3D array

        //        int[,,] array3D =
        // {
        //    {
        //        { 1,  2,  3 },
        //        { 4,  5,  6 },
        //        { 7,  8,  9 }
        //    },

        //    {
        //        { 10, 11, 12 },
        //        { 13, 14, 15 },
        //        { 16, 17, 18 }
        //    },

        //    {
        //        { 19, 20, 21 },
        //        { 22, 23, 24 },
        //        { 25, 26, 27 }
        //    }
        //};

        //        for (int i = 0; i < array3D.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < array3D.GetLength(1); j++)
        //            {
        //                for(int k = 0; k < array3D.GetLength(2); k++)
        //                {
        //                    Console.Write(array3D[i, j, k] + " ");
        //                }
        //                Console.WriteLine(" ");
        //            }
        //            Console.WriteLine(" ");
        //        }


        //Jagged Array 

        //int[][] jaggedarr = new int[3][]
        //    {new int[]{1,2,3,4,5,6,7},
        //    new int[]{8,9,10 },
        //    new int[]{2 ,4 ,4 }};

        //foreach (int[] i in jaggedarr) {

        //    foreach (int j in i)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //        }


        //Array properties

        //int[] numbers = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};

        //Console.WriteLine(numbers.Length);
        //Console.WriteLine(numbers.Rank);

        //array create instance 

        //Array array = Array.CreateInstance(typeof(int), 5);

        //array.SetValue(10, 0);
        //array.SetValue(20, 1);
        //array.SetValue(30, 2);
        //array.SetValue(40, 3);
        //array.SetValue(50, 4);

        //foreach (var item in array) 
        //{
        //    Console.WriteLine(item);
        //}

        //for (int i = 0; i < array.Length; i++) { 
        //Console.WriteLine(array.GetValue(i));
        //}



        //Clone array 


        //int[] array1 = { 1, 2, 3, 4, 5, };
        //int[] array2 = (int[])array1.Clone();
        //int[] array3 = new int[10];
        //Array.Copy(array1, array3, 10);


        //array of object and icomparable

        //ArrayOfObjects[] array = 
        //{
        //    new ArrayOfObjects() { name = "Chaitanya" , age = 20 },
        //    new ArrayOfObjects() { name = "Mandeep" , age = 23 },
        //    new ArrayOfObjects() { name = "Suman" , age = 25 },
        //    new ArrayOfObjects() { name = "Ayush" , age = 17 }
        //};
        //foreach (ArrayOfObjects obj in array) { Console.WriteLine(obj.age); }
        //Array.Sort(array);
        //Console.WriteLine("After sort");
        //foreach (ArrayOfObjects obj in array) { Console.WriteLine(obj.age); }


        // Icomparer

        // ArrayOfObjects[] array =
        // {
        //     new ArrayOfObjects() { name = "Chaitanya" , age = 20 },
        //     new ArrayOfObjects() { name = "Mandeep" , age = 23 },
        //     new ArrayOfObjects() { name = "Suman" , age = 25 },
        //     new ArrayOfObjects() { name = "Ayush" , age = 17 }
        // };

        // var compare = new Comparer();

        //Console.WriteLine(compare.Compare(array[0], array[1]));


        //array segment 

        //int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        //ArraySegment<int> segment = new ArraySegment<int>(array, 2, 4);

        //foreach(var i in segment)
        //{
        //    Console.Write(i + " ");
        //}

        //IEnumarator Implementation


        //List<int> numbers = new List<int>() { 11, 22, 33, 44, 55, 66, 77 };
        //IEnumerator<int> nums = numbers.GetEnumerator();

        //while (nums.MoveNext())
        //{
           
        //    Console.WriteLine(nums.Current);
        //}


        //IEnumerable<int> GetNumber()
        //{
        //    yield return 0;
        //    yield return 1;
        //    yield return 2;
        //    yield return 3;

        //}

        //foreach (int i in GetNumber())
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerator<int> GetNumbers()
        //{
        //    yield return 0;
        //    yield return 1;
        //    yield return 2;
        //    yield return 3;
        //}

        //var enumerator = GetNumbers();

        //while (enumerator.MoveNext())
        //{
        //    var value = enumerator.Current;
        //    Console.WriteLine(value);
        //}


        //Tuple generic

        Tuple<int, string> values= new Tuple<int, string>(  1 , "hi");
        Console.WriteLine(values.Item1);
        Console.WriteLine(values.Item2);

       



    }
}