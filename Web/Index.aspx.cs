using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public partial class Index : System.Web.UI.Page
{
    public Maticsoft.Model.Admin  users = new  Maticsoft.Model.Admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Maticsoft.Model.Admin)Session["Users"];
        }
        else
        {
            users = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }

    }
}
