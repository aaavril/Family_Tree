namespace Library;

public class OldestSonVisitor : IVisitor<Person>
{
    private int age = 0;

    public int Age
    {
        get
        {
            return this.age;
        }
    }

    public void Visit(Node<Person> node)
    {
        if (node.Children.Count==0)
        {
            if (age < node.Member.Age)
            {
                age = node.Member.Age;
            }
        }
    }
}