using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    internal class arrays_collections
    {
        static void Main()
        {
            /*array();*/
            eggcarton();
        }

        static void array()
        {
            int[] someIntegers = new int[3]; // holds 3 elements, with indexes of 0, 1, and 2.
                                             // uninitialized elements of a declared array hold the default value for the type (in this case 0).
            Console.WriteLine(someIntegers[0]);
            Console.WriteLine(someIntegers[1]);
            Console.WriteLine(someIntegers[2]);

            int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array
            Console.WriteLine(moreIntegers[0]);
            Console.WriteLine(moreIntegers[1]);
            Console.WriteLine(moreIntegers[2]);
            // write out more if you like

            int[] otherIntegers = new[] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred
            Console.WriteLine(otherIntegers[0]);
            Console.WriteLine(otherIntegers[1]);
            Console.WriteLine(otherIntegers[2]);
            // write out more if you like
        }

        static void eggcarton()
        {
            int[,] eggcarton = new int[2, 6]; // a typical egg carton can be thought of as a 2x6 array
            Console.WriteLine(eggcarton[0, 0]); // one "corner" of the array
            Console.WriteLine(eggcarton[1, 5]); // the opposite "corner"

            int[,] sometable = { { 1, 2, 3 }, { 4, 5, 6 } }; // you can fill a multi-dimensional array on assignment as well
            Console.WriteLine(sometable[0, 0]); // one "corner" of the array
            Console.WriteLine(sometable[1, 2]); // the opposite "corner"
        }

        /*static void jaggedarray()
        {
            int[][] jaggedArray = new int[4][]; // define first dimension
            jaggedArray[0] = new int[2] { 1, 2 }; // set values of first array
            Console.WriteLine(jaggedArray[0][0]); // first element in first row
            Console.WriteLine(jaggedArray[0][1]); // second element in first row

            // additional rows haven't yet been created/assigned
            Console.WriteLine(jaggedArray[1]); // value is null

            int[] someIntegers = { 1, 2, 3 };

            int x = 1 + someIntegers[0]; // x = 2
            int y = 2 * someIntegers[2]; // y = 6
            someIntegers[2] = y; // someIntegers now contains { 1, 2, 6 }
            someIntegers[3] = 3; // EXCEPTION
        }*/

        /*static void ienumerable()
        {
            int[] someIntegers = { 1, 2, 3 };

            int x = 1 + someIntegers[0]; // x = 2
            Console.WriteLine(x);

            int y = 2 * someIntegers[2]; // y = 6
            Console.WriteLine(y);

            someIntegers[2] = y; // someIntegers now contains { 1, 2, 6 }
            Console.WriteLine(someIntegers[0]);
            Console.WriteLine(someIntegers[1]);
            Console.WriteLine(someIntegers[2]);

            // following lines produces an exception
            someIntegers[3] = 3; // EXCEPTION
        }

        static void stringsplit()
        {
            string input = "red,blue,yellow,green";
            string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
        }

        static void stringjoin()
        {
            string input = "red,blue,yellow,green";
            string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

            string output = String.Join(" | ", colors);
            Console.WriteLine(output);
        }

        static void declarelist()
        {
            List<int> someInts = new List<int>(); // declares an empty list
            someInts.Add(2);  // the list now has one item in it: {2}
            Console.WriteLine($"someInts[0]: {someInts[0]}");

            List<int> moreInts = new List<int>() { 2, 3, 4 }; // you can initialize a list when you create it
            Console.WriteLine($"moreInts[0]: {moreInts[0]}");

            string[] colors = "red,blue,yellow,green".Split(','); // an array of 4 strings
            List<string> colorList = new List<string>(colors); // initialize the list from an array
            Console.WriteLine($"colorList[0]: {colorList[0]}");
        }

        static void listadd()
        {
            List<string> colors = new List<string>() { "black", "white", "gray" };
            colors.Remove("black");
            colors.Insert(0, "orange"); // orange is the new black
            Console.WriteLine($"colors[0] {colors[0]}");

            colors.RemoveAll(c => c.Contains("t")); // removes all elements matching condition (containing a "t")
                                                    // colors currently: orange, gray
            Console.WriteLine($"colors[1] {colors[1]}");

            colors.RemoveAt(0); // removes the first element (orange)
            Console.WriteLine($"colors[0] {colors[0]}");

            int numColors = colors.Count; // Count currently is 1
            Console.WriteLine($"numColors: {numColors}");

            colors.Clear(); // colors is now an empty list
            Console.WriteLine($"colors.Count: {colors.Count}");
        }

        static void listcreate()
        {
            var colors = new List<string>() { "blue", "green", "yellow" };
            colors.ForEach(Console.WriteLine); // equivalent to ForEach(c => Console.WriteLine(c)) 
        }

        static void Main()
        {
            var colors = new List<string>() { "blue", "green", "yellow" };
            Console.WriteLine(String.Join(",", colors));
        }*/
    }
}
