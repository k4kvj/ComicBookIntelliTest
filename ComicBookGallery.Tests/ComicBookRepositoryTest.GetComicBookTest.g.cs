using Microsoft.Pex.Framework.Generated;
using NUnit.Framework;
using Microsoft.Pex.Framework;
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

namespace ComicBookGallery.Data.Tests
{
    public partial class ComicBookRepositoryTest
    {

[Test]
[PexGeneratedBy(typeof(ComicBookRepositoryTest))]
public void GetComicBookTest183()
{
    ComicBook comicBook;
    ComicBookRepository s0 = new ComicBookRepository();
    comicBook = this.GetComicBookTest(s0, 0);
    PexAssert.IsNull((object)comicBook);
    PexAssert.IsNotNull((object)s0);
}

[Test]
[PexGeneratedBy(typeof(ComicBookRepositoryTest))]
public void GetComicBookTest4()
{
    ComicBook comicBook;
    ComicBookRepository s0 = new ComicBookRepository();
    comicBook = this.GetComicBookTest(s0, 1);
    PexAssert.IsNotNull((object)comicBook);
    PexAssert.AreEqual<int>(1, comicBook.Id);
    PexAssert.AreEqual<string>("The Amazing Spider-Man", comicBook.SeriesTitle);
    PexAssert.AreEqual<int>(700, comicBook.IssueNumber);
    PexAssert.AreEqual<string>
        ("<p>Final issue! Witness the final hours of Doctor Octopus\' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>", 
         comicBook.DescriptionHtml);
    PexAssert.IsNotNull(comicBook.Artists);
    PexAssert.AreEqual<int>(5, comicBook.Artists.Length);
    PexAssert.IsNotNull((object)(comicBook.Artists[0]));
    PexAssert.AreEqual<string>("Dan Slott", comicBook.Artists[0].Name);
    PexAssert.AreEqual<string>("Script", comicBook.Artists[0].Role);
    PexAssert.IsNotNull((object)(comicBook.Artists[1]));
    PexAssert.AreEqual<string>("Humberto Ramos", comicBook.Artists[1].Name);
    PexAssert.AreEqual<string>("Pencils", comicBook.Artists[1].Role);
    PexAssert.IsNotNull((object)(comicBook.Artists[2]));
    PexAssert.AreEqual<string>("Victor Olazaba", comicBook.Artists[2].Name);
    PexAssert.AreEqual<string>("Inks", comicBook.Artists[2].Role);
    PexAssert.IsNotNull((object)(comicBook.Artists[3]));
    PexAssert.AreEqual<string>("Edgar Delgado", comicBook.Artists[3].Name);
    PexAssert.AreEqual<string>("Colors", comicBook.Artists[3].Role);
    PexAssert.IsNotNull((object)(comicBook.Artists[4]));
    PexAssert.AreEqual<string>("Chris Eliopoulos", comicBook.Artists[4].Name);
    PexAssert.AreEqual<string>("Letters", comicBook.Artists[4].Role);
    PexAssert.AreEqual<bool>(false, comicBook.Favorite);
    PexAssert.IsNotNull((object)s0);
}
    }
}
