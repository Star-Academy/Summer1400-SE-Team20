﻿using System.Collections.Generic;
using System.Linq;
using SearchEngine.Database;
using SearchEngine.Interfaces;

namespace SearchEngine.Classes
{
    public class DatabaseInvertedIndex : IInvertedIndex<string, Document>
    {
        public bool ContainsKey(string key)
        {
            using var indexingContext = new IndexingContext();
            var contains = indexingContext.WordDocumentsPairs.Any(x => x.Statement == key);
            indexingContext.SaveChanges();
            return contains;
        }

        public HashSet<Document> Get(string key)
        {
            using var indexingContext = new IndexingContext();
            Word pair = indexingContext.WordDocumentsPairs.SingleOrDefault(x => x.Statement == key);
            return pair != null ? new HashSet<Document>(pair.Documents) : new HashSet<Document>();
        }

        public void Add(string key, Document value)
        {
            using var indexingContext = new IndexingContext();
            Word pair = indexingContext.WordDocumentsPairs.SingleOrDefault(x => x.Statement == key);
            if (pair == null)
            {
                pair = new Word() {Statement = key, Documents = new List<Document>() {value}};
                indexingContext.WordDocumentsPairs.Add(pair);
            }
            else
            {
                // pair.Documents.Add(value);
                // indexingContext.WordDocumentsPairs.Update(pair);
            }

            indexingContext.SaveChanges();
        }
    }
}