namespace CDUtility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    /// <summary>
    /// Stack implementation
    /// </summary>
    /// <typeparam name="T">Generic Type</typeparam>
    public class StackContainer<T> : IContainer<T>
    {       
        /// <summary>
        /// The list holds elements
        /// </summary>
        private List<T> items;

        public StackContainer()
        {            
            items = new List<T>();
        }

        /// <summary>
        /// Check if stack is empty.
        /// </summary>
        /// <returns>true, if stack is empty</returns>
        public bool IsEmpty()
        {
            return this.items == null || this.Size() == 0;
        }

        /// <summary>
        /// Remove a data element from the top of the stack
        /// </summary>
        /// <returns>the element removed</returns>
        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new StackOverflowException("Stack is empty");
            }

            var lastItem = this.items.Last();
            this.items.RemoveAt(this.Size() - 1);
            return lastItem;
        }

        /// <summary>
        /// Add a data element to the top of the stack
        /// </summary>
        /// <param name="item">element added into the stack</param>
        public void Push(T item)
        {
            this.items.Add(item);
        }

        /// <summary>
        /// Returns the total number of elements in the stack
        /// </summary>
        /// <returns>the total number of elements in the stack</returns>
        public int Size()
        {
            return this.items.Count();
        }
    }
}
