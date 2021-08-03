﻿using System;
using System.Collections.Generic;
using SearchEngine.Interfaces;

namespace SearchEngine
{
    public class Manager : IManager
    {
        private const string EndDelimiter = "$";
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void MakeSearchEngine()
        {
            throw new System.NotImplementedException();
        }

        public void MakeInvertedIndex(string path)
        {
            throw new System.NotImplementedException();
        }

        public HashSet<int> DoSearch(string toSearch)
        {
            throw new System.NotImplementedException();
        }

        public void PrintElements(ICollection<int> elements)
        {
            foreach (int id in elements) {
                Console.WriteLine("element" + id);
            }
        }

        public bool Finished(string toSearch)
        {
            return toSearch == EndDelimiter;
        }
    }
}