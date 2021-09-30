namespace OpenAPi_Demo
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string[] Technologies { get; set; }
        public _Links _links { get; set; }
    }
}

public class _Links
{
    public string Self { get; set; }
}
