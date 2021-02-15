using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehiclesGarage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private T[] internalArray;
        private int capacity;
        private int size;

        // public int Count { get; private set; }

        public T[] InternalArray
        {
            get 
            { 
                return internalArray; 
            }
            set 
            { 
                internalArray = value; 
            }
        }

        public int Size 
        { 
            get 
            { 
                return size; 
            } 
        }
        public int Capacity
        {
            get { 
                  return capacity; 
                }
            set { 
                  capacity = value; 
                }
        }

        public Garage(int capacitet)
        {
            this.size = 0;
            this.capacity = capacitet; 
            internalArray = new T[capacitet];

        }

        public IEnumerator<T> GetEnumerator()
        {

            //return ((IEnumerable<T>)internalArray).GetEnumerator();
            for (int i = 0; i < internalArray.Length; i++)
            {
                if (internalArray[i] != null) yield return internalArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {

            int factor = 2;
            if (this.size == this.capacity)
            {
                this.capacity *= factor;
                T[] newArray = new T[this.capacity];
                System.Array.Copy(this.internalArray, newArray, this.size);
                this.internalArray = newArray;
            }
            this.internalArray[this.size] = item;
            this.size++;
        }

        public void Remove(T item)
        {
              
       this.internalArray = this.internalArray.Where(val => val != item).ToArray();

        }

    }
}
