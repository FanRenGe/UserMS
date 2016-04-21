using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class UsersAdd : System.Web.UI.Page
{
    public string strNav = "添加员工";
    public Maticsoft.Model.Admin users = new Maticsoft.Model.Admin();

    Maticsoft.BLL.Users UsersBLL = new Maticsoft.BLL.Users();
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
        if (!IsPostBack)
        {


            if (Request.QueryString["id"] != null)//点击修改传值
            {

                Maticsoft.Model.Users model = UsersBLL.GetModel(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.ID != 0)
                {
                    txtName.Value = model.Name.Trim();
                    ddlSex.SelectedValue = model.Sex.Trim();
                    txtCode.Value = model.Code.Trim();
                    txtCardID.Value = model.CardID.Trim();
                    txtPosition.Value = model.Position.Trim();
                    txtSalary.Value = model.Salary.ToString();
                    txtRemark.Value = model.Remark.ToString().Trim();


                }
                strNav = "修改员工";
                btnUpdate.Text = "修改";

            }

        }
    }







    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        decimal _int=0;

        if(!decimal.TryParse(txtSalary.Value.Trim(),out _int ))
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('薪资格式不正确！');</script>");
            return;
        }

        if (btnUpdate.Text == "添加")
        {

            Maticsoft.Model.Users model = new Maticsoft.Model.Users();
            model.Name = txtName.Value.Trim();
            model.Sex = ddlSex.SelectedValue; ;
            model.Code = txtCode.Value.Trim();
            model.CardID = txtCardID.Value.Trim();
            model.Position = txtPosition.Value.Trim();
            model.Salary = Convert.ToDecimal(txtSalary.Value.Trim());
            model.Remark = txtRemark.Value.Trim();


            if (UsersBLL.Add(model) > 0)
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
            Maticsoft.Model.Users model = UsersBLL.GetModel(Convert.ToInt32(Request.QueryString["id"]));



            model.Name = txtName.Value.Trim();
            model.Sex = ddlSex.SelectedValue; ;
            model.Code = txtCode.Value.Trim();
            model.CardID = txtCardID.Value.Trim();
            model.Position = txtPosition.Value.Trim();
            model.Salary = Convert.ToDecimal(txtSalary.Value.Trim());
            model.Remark = txtRemark.Value.Trim();
            if (UsersBLL.Update(model))
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
