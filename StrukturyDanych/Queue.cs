using StrukturyDanych.Exceptions;
using StrukturyDanych.Interfaces;

namespace StrukturyDanych
{
    public class Queue<T> : BaseArrayStructure<T>, IDataStructureOperations<T>
    {
        public Queue(int maxSize) : base(maxSize)
        {
        }

        /// <summary>
        /// Dodaje element na koniec kolejki
        /// </summary>
        public new void Push(T element)
        {
            if (!CanPush())
                throw new QueueMaxiumSizeException();
            base.Push(element);
        }

        /// <summary>
        /// Pobiera pierwszy element z kolejki i usuwa go.
        /// </summary>
        public T Pop()
        {
            if (IsEmpty())
                throw new QueueIsEmptyException();

            var result = Elements[0];

            RemoveFirstElement();

            return result;
        }
    }
}