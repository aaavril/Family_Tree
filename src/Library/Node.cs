namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node<T>
{
    private T member;

    private List<Node<T>> children = new List<Node<T>>();

    public T Member {
        get
        {
            return this.member;
        }
    }

    public ReadOnlyCollection<Node<T>> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(T member)
    {
        this.member = member;
    }

    public void AddChildren(Node<T> n)
    {
        this.children.Add(n);
    }
    public void Accept(IVisitor<T> visitor)
    {
        visitor.Visit(this);
        foreach (var item in this.children)
        {
            item.Accept(visitor);
        }
    }
}
