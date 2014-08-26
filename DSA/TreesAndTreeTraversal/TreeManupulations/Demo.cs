namespace TreeManupulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        private static int FindRoot(IDictionary<int, Node<int>> nodes)
        {
            var result = nodes.First(pair => !pair.Value.HasParent);
            return result.Key;
        }

        private static IEnumerable<int> Findleaves(IDictionary<int, Node<int>> nodes)
        {
            var result = nodes.Where(pair => pair.Value.Children.Count == 0);
            return result.Select(pair => pair.Key);
        }

        private static IEnumerable<int> FindMiddleChildren(IDictionary<int, Node<int>> nodes)
        {
            var result = nodes.Where(pair => pair.Value.Children.Count != 0 && pair.Value.HasParent);
            return result.Select(pair => pair.Key);
        }

        static void Main()
        {
            var numberOfNodes = int.Parse(Console.ReadLine());
            var nodes = new Dictionary<int, Node<int>>();

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var parent = int.Parse(input[0]);
                var child = int.Parse(input[1]);

                if (!nodes.ContainsKey(child))
                {
                    nodes[child] = new Node<int>(child);
                }

                nodes[child].HasParent = true;

                if (!nodes.ContainsKey(parent))
                {
                    nodes[parent] = new Node<int>(parent);
                }

                nodes[parent].Children.Add(nodes[child]);

            }

            // Find root
            Console.WriteLine(FindRoot(nodes));
            // Find Leaves
            Console.WriteLine(string.Join(", ", Findleaves(nodes)));
            // Find Middle Children
            Console.WriteLine(string.Join(", ", FindMiddleChildren(nodes)));
        }
    }
}
