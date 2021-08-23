using System;
using System.Collections.Generic;

namespace W8_T5_ConvertCSVtoXML
{
    class GenerateName
    {
        private List<string> woman;
        private List<string> man;
        private List<string> lastName;
        private Random rnd;

        public GenerateName(List<string> woman, List<string> man, List<string> lastName)
        {
            rnd = new Random();
            this.woman = woman;
            this.man = man;
            this.lastName = lastName;
        }
        public string LastFirstName()
        {
            int sex = rnd.Next(0, 100) + 1;
            string lastName = this.lastName[rnd.Next(0, this.lastName.Count)];
            
            return sex > 50
                            ? $"{lastName} {man[rnd.Next(0, man.Count)]}"
                            : $"{lastName}a {woman[rnd.Next(0, woman.Count)]}";
        }
    }
}
