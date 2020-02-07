using System;
using StrukturyDanych.Exceptions;
using StrukturyDanych.Interfaces;

namespace StrukturyDanych
{
    public class Stack<T> : BaseArrayStructure<T>, IDataStructureOperations<T>
    {
        public Stack(int maxSize) : base(maxSize)
        {
        }

        /// <summary>
        /// Dodaje element na koniec stosu.
        /// </summary>
        public new void Push(T element)
        {
            if (!CanPush())
                throw new StackMaxiumSizeException();
            base.Push(element);
        }


        /// <summary>
        /// Zwraca ostatni elemnt i usuwa go ze stosu.
        /// </summary>
        public T Pop()
        {
            if (IsEmpty())
                throw new StackIsEmptyException();

            var result = Elements[Elements.Length - 1];

            RemoveLastElement();

            return result;
        }
    }
}