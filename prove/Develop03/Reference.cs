using System.Dynamic;
using System.Runtime.CompilerServices;

public class Reference
{
   private string _book;
   private int chapter;
   private int verse;

   private int endVerse;

   public Reference(string book, int chapter,int verse)
   {
      this._book = book;
      this.chapter = chapter;
      this.verse = verse;
   }
   public Reference(string book, int chapter,int verse,int endVerse)
   {
      this._book = book;
      this.chapter = chapter;
      this.verse = verse;
      this.endVerse = endVerse;
      if (endVerse > 0);
   }

   public string Book{
      get{ return _book; }
   }
   public int Chapter{
   get{
      return chapter;
   }
   }
   public int Verse{
      get{ return verse; 
      }
   }

public int EndVerse{
   get{ return endVerse; }
}
public override string ToString()
{
   if(verse == endVerse)
   {
      return $"{Book} {Chapter}: {Verse}";
   }
   else
   {
      return $"{Book} {chapter}: {verse} - {endVerse}";
      }
   }
}
