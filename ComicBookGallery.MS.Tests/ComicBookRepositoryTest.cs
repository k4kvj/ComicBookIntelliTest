using ComicBookGallery.Models;
// <copyright file="ComicBookRepositoryTest.cs">Copyright ©  2018</copyright>

using System;
using ComicBookGallery.Data;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComicBookGallery.Data.MS.Tests
{
    /// <summary>This class contains parameterized unit tests for ComicBookRepository</summary>
    [TestClass]
    [PexClass(typeof(ComicBookRepository))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ComicBookRepositoryTest
    {

        /// <summary>Test stub for GetComicBook(Int32)</summary>
        [PexMethod]
        public ComicBook GetComicBookTest([PexAssumeUnderTest] ComicBookRepository target, int id)
        {
            ComicBook result = target.GetComicBook(id);
            return result;
            // TODO: add assertions to method ComicBookRepositoryTest.GetComicBookTest(ComicBookRepository, Int32)
        }

        /// <summary>Test stub for GetComicBooks()</summary>
        [PexMethod]
        public ComicBook[] GetComicBooksTest([PexAssumeUnderTest] ComicBookRepository target)
        {
            ComicBook[] result = target.GetComicBooks();
            return result;
            // TODO: add assertions to method ComicBookRepositoryTest.GetComicBooksTest(ComicBookRepository)
        }
    }
}
