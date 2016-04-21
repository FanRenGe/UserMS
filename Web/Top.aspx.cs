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
using Maticsoft.Model;
using Maticsoft.BLL;

public partial class Top : System.Web.UI.Page
{
    public Maticsoft.Model.Admin Ad = new Maticsoft.Model.Admin();
    public string userName = "";
    public string roleName = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Users"] != null)
        {
            Ad = (Maticsoft.Model.Admin)Session["Users"];
            userName = Ad.Name;
            roleName = "";
        }
        else
        {
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }
    }

    protected void LBQuit_Click(object sender, EventArgs e)
    {
        Session["Users"] = null;
        Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
    }
}
