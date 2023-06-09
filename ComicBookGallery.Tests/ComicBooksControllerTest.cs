// <copyright file="ComicBooksControllerTest.cs">Copyright ©  2018</copyright>
using System;
using System.Web.Mvc;
using ComicBookGallery.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace ComicBookGallery.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ComicBooksController</summary>
    [PexClass(typeof(ComicBooksController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ComicBooksControllerTest
    {
        /// <summary>Test stub for Calculator(Decimal)</summary>
        [PexMethod]
        public string CalculatorTest([PexAssumeUnderTest]ComicBooksController target, decimal score)
        {
            string result = target.Calculator(score);
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.CalculatorTest(ComicBooksController, Decimal)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ComicBooksController ConstructorTest()
        {
            ComicBooksController target = new ComicBooksController();
            return target;
            // TODO: add assertions to method ComicBooksControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Detail2()</summary>
        [PexMethod]
        public ActionResult Detail2Test([PexAssumeUnderTest]ComicBooksController target)
        {
            ActionResult result = target.Detail2();
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.Detail2Test(ComicBooksController)
        }

        /// <summary>Test stub for Detail(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailTest(
            [PexAssumeUnderTest]ComicBooksController target,
            int? id
        )
        {
            ActionResult result = target.Detail(id);
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.DetailTest(ComicBooksController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]ComicBooksController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.IndexTest(ComicBooksController)
        }
    }
}
