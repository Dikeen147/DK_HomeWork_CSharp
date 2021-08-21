using System;

namespace W8_T3_BelieveOrNotBelieve
{
    [Serializable]
    public class Question
    {
        public string text;
        public bool trueFalse;
        public Question() {}
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
}
