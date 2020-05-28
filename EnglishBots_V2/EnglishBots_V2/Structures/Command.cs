using System.Collections.Generic;

namespace EnglishBots_V2.Structures
{
    public class Command
    {
        public string GetAnswers { get; set; }
        public List<string> SentencesWithWordList { get; set; }

        public override string ToString()
        {
            return $"{GetAnswers}";
        }
    }
}
