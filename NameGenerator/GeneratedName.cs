namespace NameGenerator
{
    public class GeneratedName
    {
        public string EngName { get; set; }
        public string RusName { get; set; }
        public string DateOfBirth { get; set; }
        public string Comment { get; set; }

        public GeneratedName( string engName, string rusName, string DoB, string comment)
        {
            this.EngName = engName;
            this.RusName = rusName;
            this.DateOfBirth = DoB;
            this.Comment = comment;
        }
    }
}