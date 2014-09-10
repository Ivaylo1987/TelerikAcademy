namespace Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var asked = int.Parse(Console.ReadLine());
            var rabbitsGroups = new Dictionary<int, int>();

            for (int i = 0; i < asked; i++)
            {
                int answer = int.Parse(Console.ReadLine());
                answer++;
                if (!rabbitsGroups.ContainsKey(answer))
                {
                    rabbitsGroups.Add(answer, 0);
                }

                rabbitsGroups[answer]++;
            }
            var count = 0;
            foreach (var group in rabbitsGroups)
            {
                var numberOfGroups = group.Value / group.Key;
                var excess = group.Value % group.Key;

                if (excess != 0)
                {
                    numberOfGroups++;
                }

                count += numberOfGroups * group.Key;
            }

            Console.WriteLine(count);
        }
    }
}
