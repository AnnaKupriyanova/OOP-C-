using System;

namespace ConsoleApp2 {

  public abstract class Document {
    private string Name { get; set; }
    private string Author { get; set; }
    private string KeyWords { get; set; }
    private string Theme { get; set; }
    private string FilePath { get; set; }

    public Document(string name, string author, string keyWords, string theme, string filePath) {
      Name = name;
      Author = author;
      KeyWords = keyWords;
      Theme = theme;
      FilePath = filePath;
    }

    public virtual void Info() {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Author: {Author}");
      Console.WriteLine($"KeyWords: {KeyWords}");
      Console.WriteLine($"Theme: {Theme}");
      Console.WriteLine($"FilePath: {FilePath}");
    }
  }
}
