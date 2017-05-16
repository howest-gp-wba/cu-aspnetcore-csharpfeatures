using System.Collections;
using System.Collections.Generic;

namespace CoreCourse.CSharpFeatures.Models
{
    public static class IEnumerableBookExtensions
    {
        public static int TotalPages(this IEnumerable<Book> bookCollection)
        {
            int totalPages = 0;
            foreach (Book book in bookCollection)
                totalPages += book?.Pages ?? 0;

            return totalPages;
        }

        public static IEnumerable<Book> GetByMinimumPages(
            this IEnumerable<Book> bookCollection, int minimumPages)
        {
            foreach (Book book in bookCollection)
                if ((book?.Pages ?? 0) >= minimumPages)
                    yield return book;
        }

    }
}

