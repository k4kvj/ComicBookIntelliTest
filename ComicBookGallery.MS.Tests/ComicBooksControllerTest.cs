// <copyright file="ComicBooksControllerTest.cs">Copyright ©  2018</copyright>
using System;
using ComicBookGallery.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComicBookGallery.Controllers.MS.Tests
{
    /// <summary>This class contains parameterized unit tests for ComicBooksController</summary>
    [PexClass(typeof(ComicBooksController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ComicBooksControllerTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ComicBooksController ConstructorTest()
        {
            ComicBooksController target = new ComicBooksController();
            return target;
            // TODO: add assertions to method ComicBooksControllerTest.ConstructorTest()
        }
    }
}
