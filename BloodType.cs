using System.Collections.Generic;
namespace BloodClinic
{
    public class BloodType
    {
        private static Dictionary<string, List<string>> BloodMatrix = new Dictionary<string, List<string>>
        {
            {"AB+", new List<string> { "O-", "O+", "B-", "B+", "A-", "A+", "AB-", "AB+" }},
            {"AB-", new List<string> { "O-", "B-", "A-", "AB-" }},
            { "A+", new List<string> { "O-", "O+", "A-", "A+" }},
            { "A-", new List<string> { "O-", "A-" }},
            { "B+", new List<string> { "O-", "O+", "B-", "B+" }},
            { "B-", new List<string> { "O-", "B-" }},
            { "O+", new List<string> { "O-", "O+" }},
            { "O-", new List<string> { "O-"} }
        };

        public BloodType(string letter, char sign)
        {
            Letter = letter;
            Sign = sign;
        }

        public string Letter { get; set; } //O, A, B, AB
        public char Sign { get; set; } // -/+

        // TODO: Implement this
        public bool CanDonateTo(BloodType recipientType)
        {
            var group = recipientType.Letter + recipientType.Sign;
            List<string> types = BloodMatrix[group];
            return types != null && types.Contains(this.Letter + this.Sign);
        }
    }
}