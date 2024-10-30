namespace Library;

public class LongestNameVisitor : IVisitor<Person>
{
    private int nameLength = 0;

    public int NameLength
    {
        get { return this.nameLength; }
    }

    public string LongestName { get; set; }
    public void Visit(Node<Person> node)
    {
        if (nameLength < node.Member.Name.Length)
        {
            nameLength = node.Member.Name.Length;
            LongestName = node.Member.Name;
        }
    }
}
