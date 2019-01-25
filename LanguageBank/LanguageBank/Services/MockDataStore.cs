using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageBank.Models;

namespace LanguageBank.Services
{
    public class MockDataStore : IDataStore<WordCombination>
    {
        List<WordCombination> items;

        public MockDataStore()
        {
            items = new List<WordCombination>();
            var mockItems = new List<WordCombination>
            {
                new WordCombination { Id = Guid.NewGuid(), Foreign = "First item", Native = "This is an item description." },
                new WordCombination { Id = Guid.NewGuid(), Foreign = "Second item", Native = "This is an item description." },
                new WordCombination { Id = Guid.NewGuid(), Foreign = "Third item", Native = "This is an item description." },
                new WordCombination { Id = Guid.NewGuid(), Foreign = "Fourth item", Native = "This is an item description." },
                new WordCombination { Id = Guid.NewGuid(), Foreign = "Fifth item", Native = "This is an item description." },
                new WordCombination { Id = Guid.NewGuid(), Foreign = "Sixth item", Native = "This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(WordCombination item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(WordCombination item)
        {
            var oldItem = items.Where((WordCombination arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            var oldItem = items.Where((WordCombination arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<WordCombination> GetItemAsync(Guid id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<WordCombination>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}