<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersAdd.aspx.cs" Inherits="UsersAdd"
    ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/Manage.css" rel="stylesheet" type="text/css" />

    <script src="JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    

    <script language="javascript" type="text/javascript">


        function check() {

            var txtUserName = document.getElementById("txtUserName");
            var txtPwd = document.getElementById("txtPwd");
            var txtRealName = document.getElementById("txtRealName");

            if (document.getElementById("ddlDeptId").value == "--请选择--") {
                alert("请选择部门名称！");
                document.getElementById("ddlDeptId").focus();
                return false;
            }
            if (txtUserName.value == "") {
                alert("带红色 * 号项不能为空！");
                txtUserName.focus();
                return false;
            }
            if (txtPwd.value == "") {
                alert("带红色 * 号项不能为空！");
                txtPwd.focus();
                return false;
            }
            if (txtRealName.value == "") {
                alert("带红色 * 号项不能为空！");
                txtRealName.focus();
                return false;
            }
            if (document.getElementById("ddlRoleId").value == "--请选择--") {
                alert("请选择角色名称！");
                document.getElementById("ddlRoleId").focus();
                return false;
            }




        }


      


    </script>


     

</head>
<body>
    <form id="form1" runat="server">
    <div class="div_All">
        <div class="Body_Title">
            <%=strNav%></div>
    </div>
    <table style="width: 100%">
        <tr>
            <th>
                部门名称：
            </th>
            <td style="text-align: left;">
                <asp:DropDownList ID="ddlDeptId" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <th style="width: 15%">
                用户名：
            </th>
            <td style="text-align: left; width: 85%">
                <input id="txtUserName" type="text" style="width: 300px;" runat="server" /><span  style="color: Red;">*</span>
            </td>
           
        </tr>
         <tr>
            <th>
                密码：
            </th>
            <td style="text-align: left;">
                <input id="txtPwd" runat="server" type="text"   style="width: 300px;"/><span  style="color: Red;">*</span>
            </td>
        </tr>
        <tr>
            <th>
                姓名：
            </th>
            <td style="text-align: left;">
                <input id="txtRealName" type="text" runat="server"  style="width: 300px;" /><span  style="color: Red;">*</span>
            </td>
        </tr>
       
        
        <tr>
            <th>
                联系电话：
            </th>
            <td style="text-align: left;">
                <input id="txtPhone" runat="server" type="text"  style="width: 300px;"  />
            </td>
        </tr>
        
        <tr>
            <th>
                电子邮箱：
            </th>
            <td style="text-align: left;">
                <input id="txtEmail" runat="server" type="text"  style="width: 300px;" />
            </td>
        </tr>
        <tr>
            <th>
                角色名称：
            </th>
            <td style="text-align: left;">
                <asp:DropDownList ID="ddlRoleId" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <th>
                备注：
            </th>
            <td style="text-align: left;">
                <textarea id="txtRemark"  runat="server" style="width: 90%; height: 100px;"></textarea>
            </td>
        </tr>
        
        
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="添加" OnClientClick="return check()"
                    OnClick="btnUpdate_Click" />&nbsp;<input id="BtnBackProList" type="button" value="返回"
                        onclick='javascript:history.go(-1)' />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
