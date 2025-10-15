using System.Collections;
using System.Collections.Generic;

namespace Lab07;

public class DoublyLinkedList<T> : IDoubleEndedCollection<T>, IEnumerable<T>
{
    private DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    public int Length { get; private set; } = 0;
    public T First => _head!.Value!;
    public T Last => _tail!.Value!;

    public void AddLast(T Value)
    {
        DNode<T> node = new DNode<T> { Value = Value };
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail!.Next = node;
            node.Previous = _tail;
            _tail = node;
        }

        Length++;

    }

    public void AddFirst(T Value)
    {
        DNode<T> node = new DNode<T> { Value = Value };
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            node.Next = _head;
            _head.Previous = node;
            _head = node;
        }

        Length++;
    }

    public void RemoveFirst()
    {
        if (_head == _tail) // List contains one item
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _head = _head!.Next;
            _head!.Previous = null;
        }

        Length--;
    }

    public void RemoveLast()
    {
        if (_head == _tail) // List contains one item
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _tail = _tail!.Previous;
            _tail!.Next = null;
        }

        Length--;
    }

    public void InsertAfter(DNode<T> node, T Value)
    {

    }

    public void RemoveByValue(T Value)
    {

    }

    public void ReverseList()
    {
        DNode<T>? current = _head;
        DNode<T>? temp = null;

        while (current != null)
        {
            temp = current.Previous;
            current.Previous = current.Next;
            current.Next = temp;
            current = current.Previous;
        }

        if (temp != null)
        {
            _tail = _head;
            _head = temp.Previous;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}