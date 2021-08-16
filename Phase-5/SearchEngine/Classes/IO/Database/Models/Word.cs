﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SearchEngine.Classes.IO.Database.Models
{
    public class Word
    {
        [Key] 
        public string Statement { get; set; }

        public List<Word_Document> WordDocuments { get; set; }
    
    }
    
    

}