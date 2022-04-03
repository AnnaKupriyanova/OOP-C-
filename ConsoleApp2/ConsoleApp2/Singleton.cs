using System;

namespace ConsoleApp2 { 
  public class Singleton { 
    private static Singleton Instance;
    private Singleton() { 
    }
    public static Singleton GetInstance { 
      get {
        if (Instance == null) Instance = new Singleton();
        return Instance;
      }
    }

    private void BaseInfo(out string name, out string author, out string keyWords, out string theme, out string filePath) {
      Console.WriteLine("Enter document name:");
      name = Console.ReadLine();
      Console.WriteLine("Enter author:");
      author = Console.ReadLine();
      Console.WriteLine("Enter key words:");
      keyWords = Console.ReadLine();
      Console.WriteLine("Enter theme:");
      theme = Console.ReadLine();
      Console.WriteLine("Enter file path:");
      filePath = Console.ReadLine();
    }

    private void HTMLInfo() {
      BaseInfo(out string Name, out string Author, out string KeyWords, out string Theme, out string FilePath);
      Console.WriteLine("Enter link: ");
      var Link = Console.ReadLine();
      
      Console.Clear();

      var Document = new HTML(Name, Author, KeyWords, Theme, FilePath, Link);
      Console.WriteLine("Document type: HTML" + "\n");
      Document.Info();
    }

    private void MSExcelInfo() {
      BaseInfo(out string Name, out string Author, out string KeyWords, out string Theme, out string FilePath);
      Console.WriteLine("Enter amount of columns: ");
      var Columns = Console.ReadLine();
      Console.WriteLine("Enter amount of lines: ");
      var Lines = Console.ReadLine();
      
      Console.Clear();

      var Document = new MSExcel(Name, Author, KeyWords, Theme, FilePath, Columns, Lines);
      Console.WriteLine("Document type: MSExcel" + "\n");
      Document.Info();
    }

    private void MSWordInfo() {
      BaseInfo(out string Name, out string Author, out string KeyWords, out string Theme, out string FilePath);
      Console.WriteLine("Enter amount of words: ");
      var Words = Console.ReadLine();
      
      Console.Clear();

      var Document = new MSWord(Name, Author, KeyWords, Theme, FilePath, Words);
      Console.WriteLine("Document type: MSWord" + "\n");
      Document.Info();
    }

    private void PDFInfo() {
      BaseInfo(out string Name, out string Author, out string KeyWords, out string Theme, out string FilePath);
      Console.WriteLine("Enter amount of pages: ");
      var Pages = Console.ReadLine();
      
      Console.Clear();

      var Document = new PDF(Name, Author, KeyWords, Theme, FilePath, Pages);
      Console.WriteLine("Document type: PDF" + "\n");
      Document.Info();
    }

    private void TXTInfo() {
      BaseInfo(out string Name, out string Author, out string KeyWords, out string Theme, out string FilePath);
      Console.WriteLine("Enter amount of words: ");
      var Words = Console.ReadLine();
      
      Console.Clear();

      var Document = new TXT(Name, Author, KeyWords, Theme, FilePath, Words);
      Console.WriteLine("Document type: TXT" + "\n");
      Document.Info();
    }

    public void Menu() { 
      Console.WriteLine("Choose the type of document: " + "\n");
      Console.WriteLine("HTML      0");
      Console.WriteLine("MSExcel   1");
      Console.WriteLine("MSWord    2");
      Console.WriteLine("PDF       3");
      Console.WriteLine("TXT       4");

      switch (Console.ReadLine()) { 
        case "0":
          HTMLInfo();
          break;
        case "1":
          MSExcelInfo();
          break;
        case "2":
          MSWordInfo();
          break;
        case "3":
          PDFInfo();
          break;
        case "4":
          TXTInfo();
          break;
        default:
          Console.WriteLine("\n" + "Error");
          break;
      }
      Console.ReadKey();
    } 
  }
}