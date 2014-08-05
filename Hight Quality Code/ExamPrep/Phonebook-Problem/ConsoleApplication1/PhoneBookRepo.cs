namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    /// <summary>
    /// Keeps all phoneBook logic like Adding, changing and listing phone number.
    /// </summary>
    public class PhoneBookRepo : IPhonebookRepository
    {
        private OrderedSet<PhoneEntry> sorted = new OrderedSet<PhoneEntry>();
        private Dictionary<string, PhoneEntry> dict = new Dictionary<string, PhoneEntry>();
        private MultiDictionary<string, PhoneEntry> multidict = new MultiDictionary<string, PhoneEntry>(false);

        /// <summary>
        /// Adds a entry to the phonebook.
        /// </summary>
        /// <param name="name">Name of the person in the pnohebook</param>
        /// <param name="nums">The phonebook numbers that a person has</param>
        /// <returns>Boolean balue - true in success or false if not.</returns>
        public bool AddPhone(string name, IEnumerable<string> nums)
        {
            string nameToLower = name.ToLowerInvariant();
            PhoneEntry entry;
            bool flag = !this.dict.TryGetValue(nameToLower, out entry);

            if (flag)
            {
                entry = new PhoneEntry();
                entry.Name = name;
                entry.PhoneNumbers = new SortedSet<string>();
                this.dict.Add(nameToLower, entry);

                this.sorted.Add(entry);
            }

            foreach (var num in nums)
            {
                this.multidict.Add(num, entry);
            }

            entry.PhoneNumbers.UnionWith(nums);
            return flag;
        }

        public int ChangePhone(string oldent, string newent)
        {
            var found = this.multidict[oldent].ToList();

            foreach (var entry in found)
            {
                entry.PhoneNumbers.Remove(oldent);
                this.multidict.Remove(oldent, entry);

                entry.PhoneNumbers.Add(newent);
                this.multidict.Add(newent, entry);
            }

            return found.Count;
        }

        public PhoneEntry[] ListEntries(int first, int num)
        {
            if (first < 0 || first + num > this.dict.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            PhoneEntry[] list = new PhoneEntry[num];

            for (int i = first; i <= first + num - 1; i++)
            {
                PhoneEntry entry = this.sorted[i];
                list[i - first] =
                    entry;
            }

            return list;
        }
    }
}