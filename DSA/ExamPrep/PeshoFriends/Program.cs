using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeshoFriends
{
    class Program
    {
        private static Dictionary<int, Node> graph = new Dictionary<int, Node>();
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var numberNodes = int.Parse(input[0]);
            var numberOfStreets = int.Parse(input[1]);
            var numberOfHospitals = int.Parse(input[2]);

            var hospitalNodes = Console.ReadLine().Split(' ');

            foreach (var item in hospitalNodes)
            {
                var hospital = new Node(int.Parse(item));
                hospital.IsHospital = true;
                graph.Add(hospital.Id, hospital);
            }

            for (int i = 0; i < numberOfStreets; i++)
            {
                var street = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                Node firstNode; 
                Node secondNode;

                if (!graph.ContainsKey(street[0]))
                {
                    graph.Add(street[0], new Node(street[0]));
                }
                firstNode = graph[street[0]];

                if (!graph.ContainsKey(street[1]))
                {
                    graph.Add(street[1], new Node(street[1]));
                }
                secondNode = graph[street[1]];

                firstNode.Connections.Add(new Connection(secondNode, street[2]));
                secondNode.Connections.Add(new Connection(firstNode, street[2]));
            }

            long minDijkstraDistance = long.MaxValue;

            foreach (var item in graph)
            {
                if (item.Value.IsHospital)
                {
                    GetDijkstrasValues(item.Value);
                    long sum = 0;

                    foreach (var node in graph)
                    {
                        if (!node.Value.IsHospital)
                        {
                            sum += node.Value.DijkstraDistance;
                        }
                    }

                    if (minDijkstraDistance > sum)
                    {
                        minDijkstraDistance = sum;
                    }
                }
            }


            Console.WriteLine(minDijkstraDistance);
        }


        private static void GetDijkstrasValues(Node pilar)
        {
            pilar.DijkstraDistance = 0;

            var queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                if (node.Value != pilar)
                {
                    node.Value.DijkstraDistance = int.MaxValue;
                }

                queue.Enqueue(node.Value);
            }

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.DijkstraDistance == int.MaxValue)
                {
                    break;
                }

                foreach (var edge in current.Connections)
                {
                    var currentDistance = current.DijkstraDistance + edge.Distance;
                    if (currentDistance < edge.ToNode.DijkstraDistance)
                    {
                        edge.ToNode.DijkstraDistance = currentDistance;
                        queue.Enqueue(edge.ToNode);
                    }
                }
            }

        }

    }

    public class Node : IComparable
    {
        public Node(int id)
        {
            this.Id = id;
            this.Connections = new List<Connection>();
        }

        public int Id { get; private set; }

        public int DijkstraDistance { get; set; }

        public bool IsHospital { get; set; }

        public ICollection<Connection> Connections { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Node))
            {
                return -1;
            }

            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }

    public class Connection
    {
        public Connection(Node node, int distance)
        {
            this.ToNode = node;
            this.Distance = distance;
        }

        public Node ToNode { get; set; }

        public int Distance { get; set; }
    }

    public class PriorityQueue<T>
    {
        private T[] items;
        private int heapSize;
        private Comparison<T> comparisonType;

        public PriorityQueue()
            : this(4, null)
        {
        }

        public PriorityQueue(Comparison<T> comparison)
            : this(4, comparison)
        {
        }

        public PriorityQueue(int capacity)
            : this(capacity, null)
        {
        }

        public PriorityQueue(int capacity, Comparison<T> comparison)
        {
            this.items = new T[capacity];
            this.comparisonType = comparison;

            if (comparison == null)
            {
                this.comparisonType = new Comparison<T>(Comparer<T>.Default.Compare);
            }
        }

        public int Count
        {
            get
            {
                return this.heapSize;
            }

            set
            {
                this.heapSize = value;
            }
        }

        public void Enqueue(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.ResizeHeap();
            }

            this.items[this.Count] = item;
            this.HeapUp(this.Count);
            this.Count++;
        }

        public T Peak()
        {
            return this.items[0];
        }

        public T Dequeue()
        {
            T item = this.items[0];
            this.Count--;

            this.items[0] = this.items[this.Count];
            this.HeapDown(0);

            return item;
        }

        private void ResizeHeap()
        {
            T[] resizedData = new T[this.items.Length * 2];
            Array.Copy(this.items, 0, resizedData, 0, this.items.Length);
            this.items = resizedData;
        }

        private void HeapUp(int childIndex)
        {
            if (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;

                if (this.IsFirstLessThanSecond(childIndex, parentIndex))
                {
                    this.SwapItems(parentIndex, childIndex);
                    this.HeapUp(parentIndex);
                }
            }
        }

        private void HeapDown(int parentIndex)
        {
            int leftChildIndex = (2 * parentIndex) + 1;
            int rightChildIndex = leftChildIndex + 1;
            int largestChildIndex = parentIndex;

            if (leftChildIndex < this.Count && this.IsFirstLessThanSecond(leftChildIndex, largestChildIndex))
            {
                largestChildIndex = leftChildIndex;
            }

            if (rightChildIndex < this.Count && this.IsFirstLessThanSecond(rightChildIndex, largestChildIndex))
            {
                largestChildIndex = rightChildIndex;
            }

            if (largestChildIndex != parentIndex)
            {
                this.SwapItems(parentIndex, largestChildIndex);
                this.HeapDown(largestChildIndex);
            }
        }

        private void SwapItems(int parentIndex, int childIndex)
        {
            T tempItem = this.items[parentIndex];
            this.items[parentIndex] = this.items[childIndex];
            this.items[childIndex] = tempItem;
        }

        private bool IsFirstLessThanSecond(int indexA, int indexB)
        {
            if (this.comparisonType.Invoke(this.items[indexA], this.items[indexB]) < 0)
            {
                return true;
            }

            return false;
        }
    }
}
