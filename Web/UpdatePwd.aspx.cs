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


public partial class UpdatePwd : System.Web.UI.Page
{
    public Maticsoft.Model.Admin users = new Maticsoft.Model.Admin();
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
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            Maticsoft.Model.Admin users = (Maticsoft.Model.Admin)Session["Users"];
            if (users.Pwd != txtOldPwd.Value.Trim())
            {
                txtOldPwd.Focus();
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('旧密码错误！');</script>");
                return;

            }
            else
            {
                Maticsoft.BLL.Admin UsersBLL = new Maticsoft.BLL.Admin();

                users.Pwd = txtNewPwd.Value.Trim();
                if (UsersBLL.Update(users) )
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码成功！\\n新密码为：" + txtNewPwd.Value.Trim() + "');location=location;</script>");
                    return;
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码失败！');</script>");
                    return;
                }
            }
        }
    }
}
