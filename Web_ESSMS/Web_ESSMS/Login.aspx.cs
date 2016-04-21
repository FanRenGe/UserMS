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
        Users users = new Users();
        HttpCookie cookies = Request.Cookies["validate"];
        if (this.txtU_Check.Value.Trim() == cookies.Value)
        {
            if (UsersBLL.GetUsersLogin(this.txtU_Name.Value.Trim(), this.txtU_Pass.Value.Trim(), out users))
            {
                Session["Users"] = users;
                Response.Redirect("Index.aspx");
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或者密码错误！');</script>");
                return;
            }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('验证码错误！');</script>");
            return;
        }
    }
}
