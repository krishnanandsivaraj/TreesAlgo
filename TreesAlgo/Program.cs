using System;
using System.Collections;

namespace TreesAlgo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Tree
    {
        public Tree(int data) {
            this.Data = data;
            this.Next = null;
            this.Right = null;
        }
        public int Data { get; set; }

        public Tree Next { get; set; }

        public Tree Right { get; set; }

        public int GetData()
        {
            return Data;
        }

        public void SetData(int data)
        {
            this.Data = data;
        }

        public Tree GetLeft()
        {
            return Next;
        }

        public void SetRight()
        {
            Right.Data=Data;
        }

        public Tree GetRight()
        {
            return Right;
        }

        public void SetLeft()
        {
            Next.Data = Data;
        }

    }

    public class PreOrder
    {
        public void PreOrderTraversal(Tree tree)
        {
            Console.WriteLine(tree.Data);
            PreOrderTraversal(tree.GetLeft());
            PreOrderTraversal(tree.GetRight());
        }

        //recursive mode

        public ArrayList<Tree> PreOrderTraversalWithRecursion(Tree tree)
        {
            ArrayList<Tree> output = new ArrayList<Tree>();

            Stack<Tree> s = new Stack<Tree>();

            while (tree != null)
            {
                output.Add(s.Pop());
                while (tree.Next != null)
                {
                    output.Add(tree.Next);
                }

                while (tree.Right != null)
                {
                    output.Add(tree.Right);
                }
            }
            return output;
        }

    }

    public class InOrder
    {
        public void InOrderTraversal(Tree tree)
        {
            InOrderTraversal(tree);
            Console.WriteLine(tree.Data);
            InOrderTraversal(tree);
        }

        public void InOrderTraversalWithoutRecursion(Tree tree)
        {
            if (tree != null)
            {
                Console.WriteLine(tree.Next.Data);
                Console.WriteLine(tree.Data);
                Console.WriteLine(tree.Right.Data);

            }
        }
    }

    
}
