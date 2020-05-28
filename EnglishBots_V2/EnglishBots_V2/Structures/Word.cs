using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishBots_V2.Structures
{
    public class Word
    {
        public string RussianName { get; set; }
        public string FirstForm { get; set; }
        public string SecondForm { get; set; }
        public string ThirdForm { get; set; }

        public string Url { get; set; }
        public string Id { get; set; }
        public string FileId { get; set; }
        public string Title { get; set; }

        public List<string> SentencesWithWordList { get; set; }

        public override string ToString()
        {
            return $"🇺🇸Cлово:\t{this.RussianName}\t🇺🇸 \n 1️⃣ форма:\t{this.FirstForm}\t\n 2️⃣ форма:\t{this.SecondForm}\t\n 3️⃣ форма:\t{this.ThirdForm}\t\n ✏️ Предложения со словами: ✏️ \n {string.Join(Environment.NewLine, this.SentencesWithWordList)}";
        }
    }
}