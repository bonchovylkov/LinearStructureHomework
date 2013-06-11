using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   public class ListItem<T>
    {
       public T Value { get; set; }
       public ListItem<T> NextItem { get; set; }
       

       public ListItem(T value, ListItem<T> previusNode)
       {
           this.Value = value;
           previusNode.NextItem = this;
       }
       //if the linkedlist is empty we use this constructor
       public ListItem(T value)
       {
           this.Value = value;
           NextItem = null;
       }

    }

