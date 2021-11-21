using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;

public partial class ListDetails : System.Web.UI.Page {
    protected RequestContext ctx;

    protected void Page_Init(object sender, EventArgs e) {
        //ctx = DynamicDataRouteHandler.GetRequestContext(Context);
        //string procedure = String.Empty, data = String.Empty, data2 = String.Empty;
        //var parameters = ctx.RouteData.DataTokens;
        //foreach(var p in parameters)
        //{
        //    switch(p.Key)
        //    {
        //        case "procedure":
        //            procedure = p.Value.ToString();
        //            break;
        //        case "data":
        //            data = p.Value.ToString();
        //            break;
        //        case "data2":
        //            data2 = p.Value.ToString();
        //            break;
        //    }
        //}
    }

    protected void Page_Load(object sender, EventArgs e) {
        Title = "Execute";
        //var parameters = ctx.RouteData.DataTokens;
    }
    
}
