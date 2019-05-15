using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BST oak = new BST();
            oak.Add(100);
            oak.Add(50);
            oak.Add(200);
            oak.Add(75);
            Console.WriteLine(oak.root.left.right.val);
        }
    }
}
