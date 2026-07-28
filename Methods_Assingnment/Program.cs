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


    //this method for me to format output in console
    static void PrintLine()
    {
        Console.WriteLine("============================");
    }
}
