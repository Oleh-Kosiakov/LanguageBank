using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace LanguageBank.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<Guid, WordCombination> items =
            new ConcurrentDictionary<Guid, WordCombination>();

        public ItemRepository()
        {
            Add(new WordCombination { Id = Guid.NewGuid(), Foreign = "Item 1", Native = "This is an item description." });
            Add(new WordCombination { Id = Guid.NewGuid(), Foreign = "Item 2", Native = "This is an item description." });
            Add(new WordCombination { Id = Guid.NewGuid(), Foreign = "Item 3", Native = "This is an item description." });
        }

        public WordCombination Get(string id)
        {
            return items[new Guid(id)];
        }

        public IEnumerable<WordCombination> GetAll()
        {
            return items.Values;
        }

        public void Add(WordCombination item)
        {
            item.Id = Guid.NewGuid();
            items[item.Id] = item;
        }

        public WordCombination Find(string id)
        {
            WordCombination item;
            items.TryGetValue(new Guid(id), out item);

            return item;
        }

        public WordCombination Remove(string id)
        {
            WordCombination item;
            items.TryRemove(new Guid(id), out item);

            return item;
        }

        public void Update(WordCombination item)
        {
            items[item.Id] = item;
        }
    }
}
