using System;
using System.Collections.Generic;

namespace LanguageBank.Models
{
    public interface IItemRepository
    {
        void Add(WordCombination item);
        void Update(WordCombination item);
        WordCombination Remove(string key);
        WordCombination Get(string id);
        IEnumerable<WordCombination> GetAll();
    }
}
