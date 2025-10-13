using NuGet.Frameworks;

namespace Lab07.Tests;

public class LinkedListStartingEmptyTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void Setup()
    {
        list = new DoublyLinkedList<int>();
    }

    [Test]
    public void HasCorrectLength()
    {
        Assert.AreEqual(0, list.Length);
    }

    [Test]
    public void SingleAddLast()
    {
        list.AddLast(10);

        Assert.AreEqual(1, list.Length);
        Assert.AreEqual(10, list.First);
        Assert.AreEqual(10, list.Last);
    }

    [Test]
    public void SingleAddFirst()
    {
        list.AddFirst(20);

        Assert.AreEqual(1, list.Length);
        Assert.AreEqual(20, list.First);
        Assert.AreEqual(20, list.Last);
    }
}

public class LinkedListStartingWithOneAtBackTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void SetUp()
    {
        list = new DoublyLinkedList<int>();
        list.AddLast(10);
    }

    [Test]
    public void SingleAddLast()
    {
        list.AddLast(20);

        Assert.AreEqual(2, list.Length);
        Assert.AreEqual(10, list.First);
        Assert.AreEqual(20, list.Last);
    }

    [Test]
    public void SingleAddFirst()
    {
        list.AddFirst(5);

        Assert.AreEqual(2, list.Length);
        Assert.AreEqual(5, list.First);
        Assert.AreEqual(10, list.Last);
    }

    [Test]
    public void RemoveLast()
    {
        list.RemoveLast();

        Assert.AreEqual(0, list.Length);
    }

    [Test]
    public void RemoveFirst()
    {
        list.RemoveFirst();

        Assert.AreEqual(0, list.Length);
    }
}

public class LinkedListStartingWithOneAtFrontTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void SetUp()
    {
        list = new DoublyLinkedList<int>();
        list.AddFirst(10);
    }

    [Test]
    public void SingleAddLast()
    {
        list.AddLast(20);

        Assert.AreEqual(2, list.Length);
        Assert.AreEqual(10, list.First);
        Assert.AreEqual(20, list.Last);
    }

    [Test]
    public void SingleAddFirst()
    {
        list.AddFirst(5);

        Assert.AreEqual(2, list.Length);
        Assert.AreEqual(5, list.First);
        Assert.AreEqual(10, list.Last);
    }

    [Test]
    public void RemoveLast()
    {
        list.RemoveLast();

        Assert.AreEqual(0, list.Length);
    }

    [Test]
    public void RemoveFirst()
    {
        list.RemoveFirst();

        Assert.AreEqual(0, list.Length);
    }
}

public class LinkedListStartingWithTwoTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void SetUp()
    {
        list = new DoublyLinkedList<int>();
        list.AddFirst(10);
        list.AddLast(15);
    }

    [Test]
    public void RemoveFrontThenBackEqualsNull()
    {
        Assert.AreEqual(2, list.Length);

        list.RemoveFirst();
        Assert.AreEqual(1, list.Length);
        Assert.AreEqual(15, list.First);

        list.RemoveLast();
        Assert.AreEqual(0, list.Length);
    }
}

public class LinkedListStartingWithThreeTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void SetUp()
    {
        list = new DoublyLinkedList<int>();
        list.AddFirst(2);
        list.AddFirst(1);
        list.AddLast(3);
    }

    [Test]
    public void ReverseListWorks()
    {
        list.ReverseList();

        Assert.AreEqual(3, list.Length);
        Assert.AreEqual(1, list.Last);
        Assert.AreEqual(3, list.First);
    }
}