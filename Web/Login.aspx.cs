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


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        Maticsoft.Model.Admin Admin = new Maticsoft.Model.Admin();
       
            Maticsoft.BLL.Admin admin = new Maticsoft.BLL.Admin();

            DataSet ds = admin.GetList(" Name='" + this.txtU_Name.Value.Trim() + "'  and Pwd='" + this.txtU_Pass.Value.Trim()+"'");
           DataTable dt=ds.Tables[0];
            if (dt.Rows.Count>0)
            {
                Admin.Name= this.txtU_Name.Value.Trim();
                 Admin.Pwd= this.txtU_Pass.Value.Trim();
                 Admin.ID =Convert.ToInt32( dt.Rows[0]["ID"]);
                 Session["Users"] = Admin;
                Response.Redirect("Index.aspx");
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或者密码错误！');</script>");
                return;
            }
      
    }
}
