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
        Console.WriteLine(total);
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

    //this method for me to format output in console
    static void PrintLine()
    {
        Console.WriteLine("============================");
    }
}
