using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library : IEnumerable<Book>
    {
        public IReadOnlyList<Book> Books { get; set; }
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }


        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            return new LibraryEnumerator(Books);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LibraryEnumerator(Books);
        }



        private class LibraryEnumerator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex = -1;
            public LibraryEnumerator(IEnumerable<Book> input)
            {
                books = input.ToList();
            }
            public Book Current
            {
                get
                {
                    try
                    {
                        return books[currentIndex];
                    }
                    catch (Exception)
                    {
                        throw new InvalidOperationException("Enumerator Index was out of Range!");
                    }
                }
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex < books.Count)
                {
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public void Dispose()
            {
            }
        }
    }
}
