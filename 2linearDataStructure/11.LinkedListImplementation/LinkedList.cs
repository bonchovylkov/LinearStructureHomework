using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LinkedList<T>
{
    public ListItem<T> FirstElement { get; private set; }
    private ListItem<T> LastElement { get; set; }
    public int Count { get;  private set; }

    public LinkedList()
    {
        this.FirstElement = null;
        this.Count = 0;
    }

    public void AddAtTheEnd(T value)
    {
        if (FirstElement==null)
        {
            FirstElement = new ListItem<T>(value);
            LastElement=FirstElement;
        }
        else 
        {
            ListItem<T> newItem = new ListItem<T>(value,LastElement );
            LastElement = newItem;
        }
        Count++;
    }

    public void AddAtBeggining(T value)
    {
        if (FirstElement == null)
        {
            FirstElement = new ListItem<T>(value);
            LastElement = FirstElement;
        }
        else
        {
            ListItem<T> newItem = new ListItem<T>(value);
            newItem.NextItem = FirstElement;
            this.FirstElement = newItem;
        }
        Count++;
    }

    public void RemoveFirst()
    {
        if (FirstElement == null)
        {
            throw new ArgumentException("The list is empty!");
        }
        this.FirstElement = FirstElement.NextItem;
        Count--;
    }

    public void RemoveLast()
    {
        if (FirstElement ==null)
        {
            throw new ArgumentException("The list is empty!");
        }

        ListItem<T> itemToRemove = this.FirstElement;
        
        //here we found the item
        while (itemToRemove.NextItem!=null)
        {
            itemToRemove = itemToRemove.NextItem;
        }

        ListItem<T> again = this.FirstElement;

        //here we remove it becouse they are same object
        while (again.NextItem!=itemToRemove)
        {
            again = again.NextItem;
        }
        again.NextItem = null;

        Count--;
    }

    //public void AddBefore(ListItem<T> item,T value)
    //{
       
    //    ListItem<T> next = FirstElement;
    //    //find the element which we gonna add before
    //    while (next.NextItem!=item)
    //    {
    //        next = next.NextItem;
    //        if (next == null)
    //        {
    //            throw new ArgumentException("The ListItem do not belong the linkend list!");
    //        }
    //    }

    //    ListItem<T> newItem = new ListItem<T>(value);
    //    newItem.NextItem = next.NextItem;
    //    next.NextItem = newItem;
    //}

}

