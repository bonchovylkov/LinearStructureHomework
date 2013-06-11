using System;

class QueueNode<T>
{
    public QueueNode<T> NextNode { get; set; }
    public T Data { get; set; }

    public QueueNode(T @data)
    {
        this.Data = @data;
    }
}

class MyQueue<T>
{
    private QueueNode<T> head;
    private QueueNode<T> tail;
    private int count = 0;

    public MyQueue() { }

    public void Enqueue(T data)
    {
        QueueNode<T> newNode = new QueueNode<T>(data);

        if (head == null)
        {
            head = newNode;
            tail = head;
        }
        else
        {
            tail.NextNode = newNode;
            tail = newNode;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is Empty!");
        }

        T result = head.Data;
        head = head.NextNode;
        count--;
        return result;
    }

    public int Count
    {
        get { return this.count; }
    }
}