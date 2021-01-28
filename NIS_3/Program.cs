using System;
using System.Collections.Generic;
using System.IO;
using BinarySearchTreeLib;
using IBinarySearchTree;

namespace NIS_3
{
    class Program
    {
        static float[] arr = new float[] { (float)3.14, (float)2.1, (float)1.45, (float)9.56, (float)10.14 };
        static List<float> list = new List<float> { (float)3.14, (float)2.1, (float)1.45, (float)9.56, (float)10.14, (float)123.44, (float)9.3, (float)101.3, (float)124.2 };
        static void Main(string[] args)
        {
            TestDelegate _td2 = MainTree;
            TestClass.TestVersions(_td2);
        }
        static void MainTree(IBinarySearchTree.IBinarySearchTree<float> _BSTf, string _fileName)
        {
            StreamWriter fstr_out = new StreamWriter(_fileName);
            IsEmptyCheck(ref _BSTf, ref fstr_out);
            IsEmptyAfterInsertCheck(ref _BSTf, ref fstr_out);
            IsEmptyAfterRemoveCheck(ref _BSTf, ref fstr_out);
            IsEmptyAfterInsertArray(ref _BSTf, ref fstr_out);
            IsEmptyAfterInsertList(ref _BSTf, ref fstr_out);
            CountCheck(ref _BSTf, ref fstr_out);
            CountArrayInsertingCheck(ref _BSTf, ref fstr_out);
            CountListInsertingCheck(ref _BSTf, ref fstr_out);
            HeightArrayCheck(ref _BSTf, ref fstr_out);
            HeightListCheck(ref _BSTf, ref fstr_out);
            FindMaxCheck(ref _BSTf, ref fstr_out);
            FindMinCheck(ref _BSTf, ref fstr_out);
            MinValueRemoveCheck(ref _BSTf, ref fstr_out);
            MaxValueRemoveCheck(ref _BSTf, ref fstr_out);
            SearchCheck(ref _BSTf, ref fstr_out);
            RootCopyCheck(ref _BSTf, ref fstr_out);
            ContainsCheck(ref _BSTf, ref fstr_out);
            ToListCheck(ref _BSTf, ref fstr_out);
            RemoveNonExistantValueCheck(ref _BSTf, ref fstr_out);
            ToEmptyListCheck(ref _BSTf, ref fstr_out);
            EmptyRootCopyCheck(ref _BSTf, ref fstr_out);
            fstr_out.Close();
        }
        static void IsEmptyCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            streamWriter.WriteLine("Empty BST Is Empty: {0}", _BSTf.IsEmpty);
            Console.WriteLine("Empty BST Is Empty: {0}", _BSTf.IsEmpty);
        }
        static void IsEmptyAfterInsertCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert((float)3.14);
            streamWriter.WriteLine("BST with one element is empty: {0}", _BSTf.IsEmpty);
            Console.WriteLine("BST with one element is empty: {0}", _BSTf.IsEmpty);
            _BSTf.Clear();
        }
        static void IsEmptyAfterRemoveCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert((float)3.14);
            _BSTf.Remove((float)3.14);
            streamWriter.WriteLine("Empty BST after one inserted and one removed element is empty: {0}", _BSTf.IsEmpty);
            Console.WriteLine("Empty BST after one inserted and one removed element is empty: {0}", _BSTf.IsEmpty);
            _BSTf.Clear();
        }
        static void IsEmptyAfterInsertArray(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(arr);
            streamWriter.WriteLine("BST after inserted an array with {0} elements is empty: {1}", arr.Length, _BSTf.IsEmpty);
            Console.WriteLine("BST after inserted an array with {0} elements is empty: {1}",arr.Length, _BSTf.IsEmpty);
            _BSTf.Clear();
        }
        static void IsEmptyAfterInsertList(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            streamWriter.WriteLine("BST after inserted a list with {0} elements is empty: {1}", list.Count, _BSTf.IsEmpty);
            Console.WriteLine("BST after inserted a list with {0} elements is empty: {1}", list.Count, _BSTf.IsEmpty);
            _BSTf.Clear();
        }
        static void CountCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert((float)3.14);
            streamWriter.WriteLine("Numb of values in BST is {0}", _BSTf.Count);
            Console.WriteLine("Numb of values in BST is {0}", _BSTf.Count);
            _BSTf.Clear();
        }
        static void CountArrayInsertingCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(arr);
            streamWriter.WriteLine("Numb of values in BST inserted by array is {0}", _BSTf.Count);
            Console.WriteLine("Numb of values in BST inserted by array is {0}", _BSTf.Count);
            _BSTf.Clear();
        }
        static void CountListInsertingCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            streamWriter.WriteLine("Numb of values in BST inserted by list is {0}", _BSTf.Count);
            Console.WriteLine("Numb of values in BST inserted by list is {0}", _BSTf.Count);
            _BSTf.Clear();
        }
        static void HeightArrayCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(arr);
            streamWriter.WriteLine("Height in BST inserted by array is {0}", _BSTf.Height);
            Console.WriteLine("Height in BST inserted by array is {0}", _BSTf.Height);
            _BSTf.Clear();
        }
        static void HeightListCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            streamWriter.WriteLine("Height in BST inserted by list is {0}", _BSTf.Height);
            Console.WriteLine("Height in BST inserted by list is {0}", _BSTf.Height);
            _BSTf.Clear();
        }
        static void FindMaxCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            streamWriter.WriteLine("(WRONG)Max value is {0}", _BSTf.FindMax());
            Console.WriteLine("(WRONG)Max value is {0}", _BSTf.FindMax());
            _BSTf.Clear();
        }
        static void FindMinCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            streamWriter.WriteLine("(WRONG)Min value is {0}", _BSTf.FindMin());
            Console.WriteLine("(WRONG)Min value is {0}", _BSTf.FindMin());
            _BSTf.Clear();
        }
        static void MinValueRemoveCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            _BSTf.RemoveMin();

            foreach (var b in _BSTf.ToArray())
                Console.Write("{0} ", b);

            streamWriter.WriteLine("(WRONG)Min remove works wrong");
            Console.WriteLine("(WRONG)Min remove works wrong");
            _BSTf.Clear();
        }
        static void MaxValueRemoveCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            _BSTf.RemoveMax();

            foreach (var b in _BSTf.ToArray())
                Console.Write("{0} ", b);

            streamWriter.WriteLine("(WRONG)Max remove works wrong");
            Console.WriteLine("(WRONG)Max remove works wrong");
            _BSTf.Clear();
        }
        static void SearchCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            try
            {
                streamWriter.WriteLine("Existing value in BST was searched by Find void and value is {0}", _BSTf.Find((float)1.45));
                Console.WriteLine("Existing value in BST was searched by Find void and value is {0}", _BSTf.Find((float)1.45));
            }
            catch
            {
                streamWriter.WriteLine("(WRONG-EXCEPTION)Existing value in BST was searched by Find void and value is ...");
                Console.WriteLine("(WRONG-EXCEPTION)Existing value in BST was searched by Find void and value is ...");
            }

            try
            {
                streamWriter.WriteLine("NonExisting value in BST was searched by Find void and value is {0}", _BSTf.Find((float)1.99));
                Console.WriteLine("NonExisting value in BST was searched by Find void and value is {0}", _BSTf.Find((float)1.99));
            }
            catch
            {
                streamWriter.WriteLine("(WRONG-EXCEPTION)NonExisting value in BST was searched by Find void and value is ...");
                Console.WriteLine("(WRONG-EXCEPTION)NonExisting value in BST was searched by Find void and value is ...");
            }
            _BSTf.Clear();
        }
        static void RootCopyCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            var a = _BSTf.Root;
            streamWriter.WriteLine("Root is {0}", a.Value);
            Console.WriteLine("Root is {0}", a.Value);
            _BSTf.Clear();
        }
        static void ContainsCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);

            streamWriter.WriteLine("Existing value in BST was checked by Contains void and the bool value is {0}", _BSTf.Contains((float)3.14));
            Console.WriteLine("Existing value in BST was checked by Contains void and the bool value is {0}", _BSTf.Contains((float)3.14));

            streamWriter.WriteLine("NonExisting value in BST was checked by Contains void and the bool value is {0}", _BSTf.Contains((float)3.11));
            Console.WriteLine("NonExisting value in BST was checked by Contains void and the bool value is {0}", _BSTf.Contains((float)3.11));

            _BSTf.Clear();
        }
        static void ToListCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            var _l = _BSTf.ToList();
            Console.WriteLine("List of values after ToList void:");
            streamWriter.WriteLine("List of values after ToList void:");

            foreach (var a in _l)
            {
                Console.Write("{0} ",a);
                streamWriter.Write("{0} ", a);
            }

             _BSTf.Clear();
        }
        static void RemoveNonExistantValueCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            _BSTf.Insert(list);
            Console.WriteLine();
            try
            {
                _BSTf.Remove((float)3.999);
                Console.WriteLine("(WRONG)NonExistant value was remove");
                streamWriter.WriteLine("(WRONG)NonExistant value was remove");
            }
            catch
            {
                Console.WriteLine("(EXCEPTION)NonExistant value was not remove");
                streamWriter.WriteLine("(EXCEPTION)NonExistant value was not remove");
            }
            _BSTf.Clear();
        }
        static void ToEmptyListCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            var _l = _BSTf.ToList();
            Console.WriteLine("List of values after ToList void:");
            streamWriter.WriteLine("List of values after ToList void:");

            foreach (var a in _l)
            {
                Console.Write("{0} ", a);
                streamWriter.Write("{0} ", a);
            }

            _BSTf.Clear();
        }
        static void EmptyRootCopyCheck(ref IBinarySearchTree.IBinarySearchTree<float> _BSTf, ref StreamWriter streamWriter)
        {
            streamWriter.WriteLine("Numb of values in BST is {0}", _BSTf.Height);
            Console.WriteLine("Numb of values in BST is {0}", _BSTf.Height);
            _BSTf.Clear();
        }
    }
}
