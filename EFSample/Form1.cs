using EFSample.Models.ORM;

namespace EFSample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        AkademiLibraryContext context = new AkademiLibraryContext();

        Book book = new Book();
        book.Name = "C#";
        book.PublisherName = "Ali";
        book.PublishDate = DateTime.Now;

        context.Books.Add(book);
        context.SaveChanges();

    }
}
