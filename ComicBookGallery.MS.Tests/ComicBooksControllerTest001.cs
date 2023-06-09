using System.Web.Mvc;
// <copyright file="ComicBooksControllerTest001.cs">Copyright ©  2018</copyright>

using System;
using ComicBookGallery.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComicBookGallery.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(ComicBooksController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ComicBooksControllerTest
    {

        [PexMethod]
        public string Calculator([PexAssumeUnderTest] ComicBooksController target, decimal score)
        {
            string result = target.Calculator(score);
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.Calculator(ComicBooksController, Decimal)
        }

        [PexMethod]
        public ActionResult Detail([PexAssumeUnderTest] ComicBooksController target, int? id)
        {
            ActionResult result = target.Detail(id);
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.Detail(ComicBooksController, Nullable`1<Int32>)
        }

        [PexMethod]
        public ActionResult Detail2([PexAssumeUnderTest] ComicBooksController target)
        {
            ActionResult result = target.Detail2();
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.Detail2(ComicBooksController)
        }

        [PexMethod]
        public ActionResult Index([PexAssumeUnderTest] ComicBooksController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method ComicBooksControllerTest.Index(ComicBooksController)
        }
    }
}
