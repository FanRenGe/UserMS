using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class UsersAdd : System.Web.UI.Page
{
    public string strNav = "添加员工";
    public Users users = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
        }
        else
        {
            users = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }
        if (!IsPostBack)
        {
            
         
            if (Request.QueryString["id"] != null)//点击修改传值
            {

                Users model = UsersBLL.GetIdByUsers(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.UserId != 0)
                {
                    txtEmail.Value = model.Email.Trim();
                    txtPhone.Value = model.Phone.Trim();
                    txtPwd.Value = model.Pwd.Trim();
                    txtRealName.Value = model.RealName.Trim();
                    txtRemark.Value = model.Remark.Trim();
                    txtUserName.Value = model.UserName.Trim();
                    ddlRoleId.SelectedValue = model.RoleId.ToString().Trim();
                    ddlDeptId.SelectedValue = model.DeptId.ToString().Trim();

                }
                strNav = "修改员工";
                btnUpdate.Text = "修改";

            }

        }
    }

  





    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (btnUpdate.Text == "添加")
        {

            Users model = new Users();
            model.DeptId = Convert.ToInt32(ddlDeptId.SelectedValue.Trim());
            model.Email = txtEmail.Value.Trim();
            model.Phone = txtPhone.Value.Trim();
            model.Pwd = txtPwd.Value.Trim();
            model.RealName = txtRealName.Value.Trim();
            model.Remark = txtRemark.Value.Trim();
            model.RoleId = Convert.ToInt32(ddlRoleId.SelectedValue);
            model.UserName = txtUserName.Value.Trim();
            
            if (UsersBLL.AddUsers(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('UsersManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加失败！');</script>");
                return;
            }


        }
        else
        {
            Users model = UsersBLL.GetIdByUsers(Convert.ToInt32(Request.QueryString["id"]));

            model.DeptId = Convert.ToInt32(ddlDeptId.SelectedValue.Trim());
            model.Email = txtEmail.Value.Trim();
            model.Phone = txtPhone.Value.Trim();
            model.Pwd = txtPwd.Value.Trim();
            model.RealName = txtRealName.Value.Trim();
            model.Remark = txtRemark.Value.Trim();
            model.RoleId = Convert.ToInt32(ddlRoleId.SelectedValue);
            model.UserName = txtUserName.Value.Trim();


            if (UsersBLL.UpdateUsers(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('UsersManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                return;
            }

        }
    }
}
