// -----------------------------------------------------------------------
// <copyright file="IContainer.cs" company="-">
// Copyright © 2018
// </copyright>
// -----------------------------------------------------------------------
namespace CDUtility
{
    /// <summary>
    /// Container Interface
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public interface IContainer<T>
    {
        /// <summary>
        /// Add a data element to the top of the stack
        /// </summary>
        /// <param name="item">element added into the stack</param>
        void Push(T item);

        /// <summary>
        /// Remove a data element from the top of the stack
        /// </summary>
        /// <returns>the element removed</returns>
        T Pop();

        /// <summary>
        /// Returns the total number of elements in the stack
        /// </summary>
        /// <returns>the total number of elements in the stack</returns>
        int Size();

        /// <summary>
        /// Check if stack is empty.
        /// </summary>
        /// <returns>true, if stack is empty</returns>
        bool IsEmpty();
    }
}
