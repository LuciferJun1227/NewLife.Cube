﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/NoPermission.cshtml")]
    public partial class _Views_Shared_NoPermission_cshtml : System.Web.Mvc.WebViewPage<System.Web.Mvc.HandleErrorInfo>
    {
        public _Views_Shared_NoPermission_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\NoPermission.cshtml"
  
    //Layout = "_Ace_Layout.cshtml";
    Layout = "_Layout.cshtml";
    //Layout = NewLife.Cube.Setting.Current.Layout;

    //var context = ViewBag.Context as AuthorizationContext;
    var Resource = ViewBag.Resource;
    var Permission = (PermissionFlags)ViewBag.Permission;
    var pm = Permission.GetDescription();
    var menu = ViewBag.Menu as IMenu;

    ViewBag.Title = String.Format("没有访问资源[{0}]的权限[{1}]", Resource, pm);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteAttribute("title", Tuple.Create(" title=\"", 549), Tuple.Create("\"", 593)
            
            #line 16 "..\..\Views\Shared\NoPermission.cshtml"
, Tuple.Create(Tuple.Create("", 557), Tuple.Create<System.Object, System.Int32>(menu == null ? "" : menu.FullName
            
            #line default
            #line hidden
, 557), false)
);

WriteLiteral(">\r\n        <strong>\r\n            <pre");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">访问资源 ");

            
            #line 18 "..\..\Views\Shared\NoPermission.cshtml"
                                                         Write(Resource);

            
            #line default
            #line hidden
WriteLiteral(" 需要 ");

            
            #line 18 "..\..\Views\Shared\NoPermission.cshtml"
                                                                      Write(pm);

            
            #line default
            #line hidden
WriteLiteral(" 权限</pre>\r\n        </strong>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 777), Tuple.Create("\"", 803)
, Tuple.Create(Tuple.Create("", 784), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/User/Logout")
, 784), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"ace-icon fa fa-power-off\"");

WriteLiteral("></i>\r\n            以其它身份登录\r\n        </a>\r\n        <a");

WriteLiteral(" href=\"javascript: history.go(-1);\"");

WriteLiteral(" class=\"btn btn-info\"");

WriteLiteral(">返回上一页</a>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
