namespace Task2;

public class PhotoBook
{
    private int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int pages)
    {
        numPages = pages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}
