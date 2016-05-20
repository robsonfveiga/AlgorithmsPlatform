using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Collections
{
    public sealed class LinkedNode<T>
    {
        public LinkedNode(LinkedNode<T> Previous,T Value){
            this.Previous = Previous;
            this.Value = Value;
        }

        public  LinkedNode<T> List { get; set; }
      
        public  LinkedNode<T> Next { get; set; }
       
        public  LinkedNode<T> Previous { get; set; }

        public T Value { get; set; }
    }
}
