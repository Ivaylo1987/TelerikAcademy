using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace SuperMarketQueue
{
    class Program
    {
        static void Main()
        {
            var queque = new SuperQueue();
            var command = Console.ReadLine().Split(' ');
            

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Append":
                        Console.WriteLine(queque.Append(command[1]));
                        break;
                    case "Serve":
                        Console.WriteLine(queque.Server(int.Parse(command[1])));
                        break;
                    case "Find":
                        Console.WriteLine(queque.Find(command[1]));
                        break;
                    case "Insert":
                        Console.WriteLine(queque.Insert(int.Parse(command[1]), command[2]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }
        }
    }

    class SuperQueue
    {
        private BigList<string> queue;
        private const string ok = "OK";
        private const string error = "Error";
        Dictionary<string, int> occurances;

        public SuperQueue()
        {
            this.occurances = new Dictionary<string, int>();
            this.queue = new BigList<string>();
        }

        public string Append(string name)
        {
            this.queue.Add(name);
            if (!this.occurances.ContainsKey(name))
            {
                occurances.Add(name, 0);
            }

            occurances[name]++;

            return ok;
        }

        public string Insert(int postion, string name)
        {
            if (postion < 0 || this.queue.Count < postion)
            {
                return error;
            }
            else
            {
                if (!this.occurances.ContainsKey(name))
                {
                    occurances.Add(name, 0);
                }

                occurances[name]++;
                if (postion == 0)
                {
                    this.queue.AddToFront(name);

                    return ok;
                }
                else if (postion == this.queue.Count)
                {
                    this.queue.Add(name);
                    return ok;
                }
                else
                {
                    this.queue.Insert(postion, name);
                    return ok;
                }
            }
            
        }

        public int Find(string name)
        {
            if (this.occurances.ContainsKey(name))
            {
                return this.occurances[name];
            }

            return 0;
        }

        public string Server(int count)
        {
            if (this.queue.Count < count)
            {
                return error;
            }
            var toRemove = this.queue.GetRange(0, count);
            toRemove.ForEach(x => this.occurances[x]--);
            
            var result = string.Join(" ", toRemove);
            this.queue.RemoveRange(0, count);

            return result;
        }
    }
}
