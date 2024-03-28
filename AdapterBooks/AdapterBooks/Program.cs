using System;

public interface IBook 
{ 
    void ShowDetails(); 
}

public interface IBookCategory 
{ 
    void ShowCategory(); 
}

public class FictionCategory : IBookCategory 
{ 
    public void ShowCategory() 
    { 
        Console.WriteLine("Fiction"); 
    } 
}

public class NonFictionCategory : IBookCategory 
{ 
    public void ShowCategory() 
    { 
        Console.WriteLine("Non-Fiction"); 
    } 
}

public class Book : IBook
{
    protected IBookCategory _category;

    public Book(IBookCategory category) 
    { 
        _category = category; 
    }

    public virtual void ShowDetails() 
    { 
        Console.WriteLine("Book Details:"); _category.ShowCategory(); 
    }
}

public class Novel : Book
{
    public Novel(IBookCategory category) : base(category) { }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Type: Novel");
    }
}

public class Biography : Book
{
    public Biography(IBookCategory category) : base(category) { }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Type: Biography");
    }
}

public class CategoryAdapter : IBookCategory
{
    private Category _category;

    public CategoryAdapter(Category category)
    {
        _category = category;
    }

    public void ShowCategory()
    {
        _category.DisplayCategory();
    }
}

public class Category { public void DisplayCategory() { } }

class Program
{
    static void Main()
    {
        Category fiction = new Category(); Category nonFiction = new Category();

        IBookCategory fictionAdapter = new CategoryAdapter(fiction);
        IBookCategory nonFictionAdapter = new CategoryAdapter(nonFiction);

        Book novel = new Novel(fictionAdapter);
        novel.ShowDetails();

        Book biography = new Biography(nonFictionAdapter);
        biography.ShowDetails();
    }
}