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
using Model;
using BLL;
using System.Collections.Generic;

public partial class Left : System.Web.UI.Page
{
    public List<Modules> listModeuleBig = new List<Modules>();
    public Users users = new Users();
    /// <summary>
    /// 加载左侧导航栏大类，大类管理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];

            listModeuleBig = ModulesBLL.AllData(" and ModuleId in ( select ParentModuleId From dbo.Modules where ModuleId in (SELECT ModuleId FROM Authority WHERE RoleId="+users.RoleId+") group by ParentModuleId)");
      
        }
        else
        {
            users = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }

    }
}
