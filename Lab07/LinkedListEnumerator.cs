using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07;

public class LinkedListEnumerator<T> : IEnumerator<T>
{
    private DNode<T>? firstNode;
    private DNode<T>? currentNode;
    public LinkedListEnumerator(DNode<T> head)
    {
        firstNode = head;
        currentNode = null;
    }

    public bool MoveNext()
    {
        if (currentNode == null)
        {
            currentNode = firstNode;
            return true;
        }
        else
        {
            if (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                return true;
            }
            else
                return false;
        }
    }

    public void Reset()
    {
        currentNode = null;
    }

    public void Dispose()
    {

    }

    public T Current
    {
        get
        {
            if (currentNode == null)
                return default!;
            else
                return currentNode.Value;
        }
    }

    object IEnumerator.Current => Current!;
}