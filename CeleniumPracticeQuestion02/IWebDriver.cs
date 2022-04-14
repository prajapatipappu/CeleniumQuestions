namespace CeleniumPracticeQuestion02
{
    internal interface IWebDriver
    {
        object Navigate();
        object Manage();
        object FindElement(object p);
        object FindElements(object p);
    }
}