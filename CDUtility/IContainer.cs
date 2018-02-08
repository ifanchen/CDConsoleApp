namespace CDUtility
{
    /// <summary>
    /// Contianer Interface
    /// </summary>
    interface IContainer<T>
    {
        void Push(T item);
        T Pop();
        int Size();
        bool IsEmpty();
    }
}
