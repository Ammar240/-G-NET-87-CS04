namespace Methods_Assingnment;

internal class Program
{
    static void Main(string[] args)
    {
        #region question 1
        PrintWelcomeMessage();

        Console.WriteLine("============================");
        #endregion

        #region question 2
        PrintBookTitle("Clean Code");
        PrintLine();
        #endregion

        #region question 3
        int pages = 400;
        int total = AddBounusPages(pages);
        Console.WriteLine(pages); // I expect to see 400, because this method does not change the value of the variable pages,
                                  // it only returns a new value (call by value)
        PrintLine();
        #endregion

        #region question 4
        double[] prices = { 25.5, 40.0 }; 
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]); // i expect to see 20.5, (call by value for refrence type)
        PrintLine();
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
        return pages + 50;
    }
    #endregion

    #region question 4 
    static double ApplyDiscount(double[] prices)
    {
        return prices[0] -= 5;
    }
    #endregion

    //this method for me to format output in console
    static void PrintLine()
    {
        Console.WriteLine("============================");
    }
}
