using System;

public interface IBook 
{ 
    void ShowDetails(); 
}

public class Book : IBook
{
    protected string title;

    public Book(string title)
    {
        this.title = title;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"Book Details -> Title: {title}");
    }
}

public class Novel : Book
{
    public Novel(string title) : base(title)
    {

    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Type: Novel");
    }
}

public class Biography : Book
{
    public Biography(string title) : base(title)
    {

    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Type: Biography");
    }
}

public interface ITarget
{
    void ShowCategory(IBook book);
}

public class CategoryAdapter : ITarget
{
    private CategoryAdapee _categoryAdaptee;

    public CategoryAdapter(CategoryAdapee categoryAdaptee)
    {
        _categoryAdaptee = categoryAdaptee;
    }

    public void ShowCategory(IBook book)
    {
        _categoryAdaptee.DisplayCategory(book);
    }
}

public class CategoryAdapee
{ 
    public string Name { get; set; }

    public void DisplayCategory(IBook book) 
    {
        Console.WriteLine($"Category: {Name}");
        book.ShowDetails();
    } 
}

class Program
{
    static void Main()
    {
        CategoryAdapee fiction = new CategoryAdapee() { Name = "Fiction" };

        ITarget fictionAdapter = new CategoryAdapter(fiction);
        Book novel = new Novel("Dune");
        fictionAdapter.ShowCategory(novel);

        CategoryAdapee nonFiction = new CategoryAdapee() { Name = "Non-fiction" };

        ITarget nonFictionAdapter = new CategoryAdapter(nonFiction);
        Book biography = new Biography("Oppenheimer Biography");
        nonFictionAdapter.ShowCategory(biography);
    }
}