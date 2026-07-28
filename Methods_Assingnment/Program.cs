namespace Methods_Assingnment;

internal class Program
{
    static void Main(string[] args)
    {
        #region question 1
        PrintLine(1);
        PrintWelcomeMessage();
        #endregion

        #region question 2
        PrintLine(2);
        PrintBookTitle("Clean Code");
        #endregion

        #region question 3
        PrintLine(3);

        int pages = 400;
        AddBounusPages(pages);
        Console.WriteLine(pages); // I expect to see 400, because this method does not change the value of the variable pages,
                                  // it only returns a new value (call by value for value type)
        #endregion

        #region question 4
        PrintLine(4);

        double[] prices = { 25.5, 40.0 };
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]); // i expect to see 20.5, (call by value for refrence type)
        #endregion

        #region question 5
        PrintLine(5);

        AddBounusPages(ref pages); // I expect to see 450, (call by reference for value type)
        Console.WriteLine(pages);
        #endregion

        #region question 6
        PrintLine(6);

        replaceArray(ref prices);
        Console.WriteLine($"prices length: {prices.Length}");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine(prices[i]);
        }
        #endregion

        #region question 7
        PrintLine(7);

        bool isFound = TryGetPrice("Clean Code", out double price);
        Console.WriteLine($"Book is found: {isFound}");
        Console.WriteLine($"price = {price}");
        #endregion

        #region question 8
        PrintLine(8);

        PrintBookInfo("Clean Code", pages);
        Console.WriteLine();
        PrintBookInfo("Clean Code");
        #endregion

        #region question 9
        PrintLine(9);

        PrintBookInfo(pages: 500, title: "C# in Depth");
        #endregion

        #region question 10
        PrintLine(10);
        PrintAllTitles("Clean Code", "C# in Depth", "The Pragmatic Programmer");
        #endregion
    }
    #region question 1
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }
    #endregion

    #region question 2
    static void PrintBookTitle(string title)
    {
        Console.WriteLine($"Book title: {title}");
    }
    #endregion

    #region question 3
    static int AddBounusPages(int pages)
    {
        return pages += 50;
    }
    #endregion

    #region question 4 
    static double ApplyDiscount(double[] prices)
    {
        return prices[0] -= 5;
    }
    #endregion

    #region question 5
    static int AddBounusPages(ref int pages)
    {
        pages += 50;
        return pages;
    }
    #endregion

    #region question 6
    static void replaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };

    }

    #endregion

    #region question 7
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0;
            return false;
        }
    }
    #endregion

    #region question 8
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title : {title}\nPages : {pages}");
    }
    #endregion

    #region question 10
    static void PrintAllTitles(params string[] titles)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            Console.WriteLine(titles[i]);
        }
    }
    #endregion
    //this method for me to format output in console
    static void PrintLine(int qNo)
    {
        Console.WriteLine($"\n====== Question {qNo} ======\n");
    }
}
