namespace RecoverMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var allNodes = new Dictionary<char, Node>();

            for (int j = 0; j < lines; j++)
            {
                var input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    Node node;

                    if (allNodes.ContainsKey(input[i]))
                    {
                        node = allNodes[input[i]];
                    }
                    else
                    {
                        node = new Node(input[i]);
                        allNodes.Add(input[i], node);
                    }

                    if (0 < i)
                    {
                        var parent = input[i - 1];
                        node.Parents.Add(allNodes[parent]);
                        allNodes[parent].Children.Add(node);
                    }
                }
            }

            var result = new List<char>();
            var noIncomingEdges = new SortedSet<char>();

            foreach (var item in allNodes)
            {
                if (item.Value.Parents.Count == 0)
                {
                    noIncomingEdges.Add(item.Value.Value);
                }

            }

            while (noIncomingEdges.Count > 0)
            {
                var current = noIncomingEdges.Min();
                noIncomingEdges.Remove(current);

                result.Add(current);

                foreach (var child in allNodes[current].Children)
                {
                    child.Parents.Remove(allNodes[current]);
                    if (child.Parents.Count == 0)
                    {
                        noIncomingEdges.Add(child.Value);
                    }
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }

    class Node
    {
        public Node(char value)
        {
            this.Value = value;
            this.Children = new List<Node>();
            this.Parents = new List<Node>();
        }

        public char Value { get; set; }
        public List<Node> Children { get; set; }
        public List<Node> Parents { get; set; }
    }
}