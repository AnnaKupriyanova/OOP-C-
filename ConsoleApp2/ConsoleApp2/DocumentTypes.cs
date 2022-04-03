using System;

namespace ConsoleApp2 {
  public class HTML : Document {
    private string Link { get; set; }

    public HTML(string Name, string Author, string KeyWords, string Theme, string FilePath, string link) : base(Name, Author, KeyWords, Theme, FilePath) {
      Link = link;
    }

    public override void Info() {
      base.Info();
      Console.WriteLine($"Link: {Link}");
    }
  }

  public class MSExcel : Document {
    private string Lines { get; set; }
    private string Columns { get; set; }

    public MSExcel(string Name, string Author, string KeyWords, string Theme, string FilePath, string lines, string columns) : base(Name, Author, KeyWords, Theme, FilePath) {
      Lines = lines;
      Columns = columns;
    }

    public override void Info() {
      base.Info();
      Console.WriteLine($"Amounr of lines: {Lines}");
      Console.WriteLine($"Amount of columns: {Columns}");
    }
  }

  public class MSWord : Document {
    private string Words { get; set; }

    public MSWord(string Name, string Author, string KeyWords, string Theme, string FilePath, string words) : base(Name, Author, KeyWords, Theme, FilePath) {
      Words = words;
    }

    public override void Info() {
      base.Info();
      Console.WriteLine($"Amount of words: {Words}");
    }
  }

  public class PDF : Document {
    private string Pages { get; set; }

    public PDF(string Name, string Author, string KeyWords, string Theme, string FilePath, string pages) : base(Name, Author, KeyWords, Theme, FilePath) {
      Pages = pages;
    }

    public override void Info() {
      base.Info();
      Console.WriteLine($"Amount of pages: {Pages}");
    }
  }

  public class TXT : Document {
    private string Words { get; set; }

    public TXT(string Name, string Author, string KeyWords, string Theme, string FilePath, string words) : base(Name, Author, KeyWords, Theme, FilePath) {
      Words = words;
    }

    public override void Info() {
      base.Info();
      Console.WriteLine($"Amount of words: {Words}");
    }
  }
}

