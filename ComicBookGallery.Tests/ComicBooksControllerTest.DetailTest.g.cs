using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using NUnit.Framework;
using Microsoft.Pex.Framework;
using System.Web.Mvc;
using ComicBookGallery.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ComicBookGallery.Controllers.Tests
{
    public partial class ComicBooksControllerTest
    {

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest571()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, default(int?));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest208()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(0));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest999()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(1));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest588()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext = s0;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(1));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNotNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.IsNull
          (((ControllerBase)comicBooksController).ControllerContext.Controller);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest58801()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext = s0;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(1));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNotNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.IsNull
          (((ControllerBase)comicBooksController).ControllerContext.Controller);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest335()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      tempDataDictionary = new TempDataDictionary();
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)comicBooksController).TempData = tempDataDictionary;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(4));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest58802()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = routeData;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext = s0;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(1));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNotNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.IsNull
          (((ControllerBase)comicBooksController).ControllerContext.Controller);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest99901()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection = viewEngineCollection;
      ((ControllerBase)comicBooksController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(1));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}

[Test]
[PexGeneratedBy(typeof(ComicBooksControllerTest))]
public void DetailTest58803()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      ComicBooksController comicBooksController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      comicBooksController = new ComicBooksController();
      ((Controller)comicBooksController).Resolver = (IDependencyResolver)null;
      ((Controller)comicBooksController).ActionInvoker = (IActionInvoker)null;
      ((Controller)comicBooksController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)comicBooksController).Url = (UrlHelper)null;
      ((Controller)comicBooksController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)comicBooksController).ControllerContext = s0;
      ((ControllerBase)comicBooksController).TempData = (TempDataDictionary)null;
      ((ControllerBase)comicBooksController).ValidateRequest = false;
      ((ControllerBase)comicBooksController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)comicBooksController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)comicBooksController);
      actionResult = this.DetailTest(comicBooksController, new int?(1));
      disposables.Dispose();
      PexAssert.IsNotNull((object)actionResult);
      PexAssert.IsNotNull((object)comicBooksController);
      PexAssert.IsNotNull(((Controller)comicBooksController).AsyncManager);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.OutstandingOperations);
      PexAssert.IsNotNull
          (((Controller)comicBooksController).AsyncManager.Parameters);
      PexAssert.AreEqual<int>
          (45000, ((Controller)comicBooksController).AsyncManager.Timeout);
      PexAssert.IsNull(((Controller)comicBooksController).Url);
      PexAssert.IsNotNull(((ControllerBase)comicBooksController).ControllerContext);
      PexAssert.IsNull
          (((ControllerBase)comicBooksController).ControllerContext.Controller);
      PexAssert.AreEqual<bool>
          (false, ((ControllerBase)comicBooksController).ValidateRequest);
    }
}
    }
}
