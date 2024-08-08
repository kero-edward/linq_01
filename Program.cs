using Day_01_G03;

namespace linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            /// 1. Find all products that are out of stock.
            ///var outOfStockProducts = ListGenerator.ProductsList.Where( p => p.UnitsInStock == 0);
            ///foreach (var product in outOfStockProducts)
            ///{
            ///    Console.WriteLine(product);
            ///}

            /// 2. Find all products that are in stock and cost more than 3.00 per unit.
            ///var FilteredProducts = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00);
            ///foreach (var Product in FilteredProducts)
            ///{
            ///    Console.WriteLine(Product);
            ///}

            /// 3. Returns digits whose name is shorter than their value.
            ///string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///var shorterNameDigits = Arr.Where((d, i) => d.Length < i);
            ///foreach (var digit in shorterNameDigits)
            ///{
            ///    Console.WriteLine(digit);
            ///}
            #endregion

            #region Ordering Operators
            /// 1. Sort a list of products by name.
            ///var orderedProductsByName = ListGenerator.ProductsList.OrderBy( p => p.ProductName);
            ///foreach (var product in orderedProductsByName)
            ///{
            ///    Console.WriteLine(product);
            ///}

            /// 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            ///string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///var sortedArr = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            ///foreach (var word in sortedArr)
            ///{
            ///    Console.WriteLine(word);
            ///}

            /// 3. Sort a list of products by units in stock from highest to lowest.
            ///var sortedProducts = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);
            ///foreach (var product in sortedProducts)
            ///{
            ///    Console.WriteLine(product);
            ///}

            /// 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            ///string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///var sortedArr = Arr.OrderBy(w => w.Length).ThenBy(w => w);
            ///foreach (var word in sortedArr)
            ///{
            ///    Console.WriteLine(word);
            ///}

            /// 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            ///string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///var sortedArr = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            ///foreach (var word in words)
            ///{
            ///    Console.WriteLine(word);
            ///}

            /// 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            ///var sortedProducts = ListGenerator.ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            ///foreach (var product in sortedProducts)
            ///{
            ///    Console.WriteLine(product);
            ///}

            /// 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            ///string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///var sortedArr = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            ///foreach (var word in sortedArr)
            ///{
            ///    Console.WriteLine(word);
            ///}

            /// 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            ///string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///var result = Arr.Where(w => w[1] == 'i').Reverse();
            ///foreach (var word in result)
            ///{
            ///    Console.WriteLine(word);
            ///}
            #endregion
        }
    }
}