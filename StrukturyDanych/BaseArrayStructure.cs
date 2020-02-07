using System.Reflection.Metadata.Ecma335;
using StrukturyDanych.Interfaces;

namespace StrukturyDanych
{
    public abstract class BaseArrayStructure<T>
    {
        protected T[] Elements;
        protected int MaxSize;
        public int CurrentSize => Elements.Length;
        protected BaseArrayStructure(int maxSize)
        {
            MaxSize = maxSize;
            Elements = new T[]{};
        }

        protected void Push(T element)
        {
            var newArray = new T[Elements.Length + 1];

            for (var i = 0; i < Elements.Length + 1; i++)
            {
                if (i == Elements.Length)
                    newArray[i] = element;
                else
                    newArray[i] = Elements[i];
            }

            Elements = newArray;
        }


        /// <summary>
        /// Usuwa pierwszy element z kolejki.
        /// </summary>
        protected void RemoveFirstElement()
        {
            var newArray = new T[Elements.Length - 1];

            // Iteracja po wszystkich elementach, poza pierwszym i dodanie ich do nowej tablicy.
            for (var i = 1; i < Elements.Length; i++)
            {
                newArray[i - 1] = Elements[i];
            }

            Elements = newArray;
        }

        /// <summary>
        /// Usuwa ostatni element ze stosu.
        /// </summary>
        protected void RemoveLastElement()
        {
            var newArray = new T[Elements.Length - 1];

            // Iteracja po wszystkich elementach ze starej tablicy, oprócz ostatniego elementu (dodanie do nowej tablicy).
            for (var i = 0; i < Elements.Length - 1; i++)
            {
                newArray[i] = Elements[i];
            }

            Elements = newArray;
        }

        protected bool CanPush() =>
            Elements.Length < MaxSize;

        protected bool IsEmpty() =>
            Elements.Length == 0;
    }
}
