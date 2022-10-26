using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            Node nRoot = new Node(5, null);

            tree.Root = nRoot;

            /*nRoot.Value = 5;
            nRoot.Parent = null;*/

            /*Node child1 = new Node(3, nRoot);
            Node child2 = new Node(2, nRoot);

            nRoot.Children.Add(child1);
            nRoot.Children.Add(child2);*/

            nRoot.addChild(3, nRoot);
            nRoot.addChild(2, nRoot);


            foreach (Node node in nRoot.Children)
            {
                Console.WriteLine($"Parent = {node.Parent.Value}, value = {node.Value}");
            }
            Console.WriteLine("==================");


            Node child = nRoot.insert(10);
            Console.WriteLine($"Parent = {child.Parent.Value}, Value = {child.Value}");


            Console.ReadKey();
        }


    }

    public class Tree
    {
        public Node Root { get; set; }
        public List<Node> Nodes { get; set; }
        public LinkedList<Node> LinkedList = new LinkedList<Node>();

        public Tree StartBranch(int parentValue)
        {
            if (LinkedList.Count == 0)
            {
                Node rootNode = new Node(parentValue, null);
                Nodes.Add(rootNode);
                LinkedList.AddFirst(rootNode);
            }
            else
            {
                Node newParent = LinkedList.First().insert(parentValue);
                Nodes.Add(newParent);
                LinkedList.AddLast(newParent);
            }
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }

        public Node()
        {
            //this.Children = new List<Node>();
        }

        public Node(int value, Node parent)
        {
            Value = value;
            Parent = parent;
            Children = new List<Node>();
        }

        public void addChild(int value, Node parent)
        {
            Node newNode = new Node(value, parent);
            parent.Children.Add(newNode);
        }

        public Node insert(int value)
        {
            Node newNode = new Node(value, Parent = this);
            this.Children.Add(newNode);

            return newNode;
        }
    }
}

