namespace StrukturyDanych.Interfaces
{
    interface IDataStructureOperations<T>
    {

        /// <summary>
        /// Dodaję element do struktury
        /// </summary>
        void Push(T element);

        /// <summary>
        /// Pobiera element ze struktury.
        /// </summary>
        /// <returns></returns>
        T Pop();
    }
}
