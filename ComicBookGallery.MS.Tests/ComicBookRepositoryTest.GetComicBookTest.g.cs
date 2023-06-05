using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComicBookGallery.Data;
using ComicBookGallery.Models;
// <copyright file="ComicBookRepositoryTest.GetComicBookTest.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ComicBookGallery.Data.MS.Tests
{
    public partial class ComicBookRepositoryTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ComicBookRepositoryTest))]
public void GetComicBookTest183()
{
    ComicBook comicBook;
    ComicBookRepository s0 = new ComicBookRepository();
    comicBook = this.GetComicBookTest(s0, 0);
    Assert.IsNull((object)comicBook);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(ComicBookRepositoryTest))]
public void GetComicBookTest4()
{
    ComicBook comicBook;
    ComicBookRepository s0 = new ComicBookRepository();
    comicBook = this.GetComicBookTest(s0, 1);
    Assert.IsNotNull((object)comicBook);
    Assert.AreEqual<int>(1, comicBook.Id);
    Assert.AreEqual<string>("The Amazing Spider-Man", comicBook.SeriesTitle);
    Assert.AreEqual<int>(700, comicBook.IssueNumber);
    Assert.AreEqual<string>
        ("<p>Final issue! Witness the final hours of Doctor Octopus\' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>", 
         comicBook.DescriptionHtml);
    Assert.IsNotNull(comicBook.Artists);
    Assert.AreEqual<int>(5, comicBook.Artists.Length);
    Assert.IsNotNull((object)(comicBook.Artists[0]));
    Assert.AreEqual<string>("Dan Slott", comicBook.Artists[0].Name);
    Assert.AreEqual<string>("Script", comicBook.Artists[0].Role);
    Assert.IsNotNull((object)(comicBook.Artists[1]));
    Assert.AreEqual<string>("Humberto Ramos", comicBook.Artists[1].Name);
    Assert.AreEqual<string>("Pencils", comicBook.Artists[1].Role);
    Assert.IsNotNull((object)(comicBook.Artists[2]));
    Assert.AreEqual<string>("Victor Olazaba", comicBook.Artists[2].Name);
    Assert.AreEqual<string>("Inks", comicBook.Artists[2].Role);
    Assert.IsNotNull((object)(comicBook.Artists[3]));
    Assert.AreEqual<string>("Edgar Delgado", comicBook.Artists[3].Name);
    Assert.AreEqual<string>("Colors", comicBook.Artists[3].Role);
    Assert.IsNotNull((object)(comicBook.Artists[4]));
    Assert.AreEqual<string>("Chris Eliopoulos", comicBook.Artists[4].Name);
    Assert.AreEqual<string>("Letters", comicBook.Artists[4].Role);
    Assert.AreEqual<bool>(false, comicBook.Favorite);
    Assert.IsNotNull((object)s0);
}
    }
}
