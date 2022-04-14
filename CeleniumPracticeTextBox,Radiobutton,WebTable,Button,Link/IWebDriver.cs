namespace CeleniumPracticeTextBox_Radiobutton_WebTable_Button_Link
{
    internal interface IWebDriver
    {
        object Navigate();
        object Manage();
        object FindElement(object p);
        void Close();
        void Quit();
    }
}