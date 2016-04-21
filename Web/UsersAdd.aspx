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
          
            var txtName = document.getElementById("txtName");
        
            var txtCode = document.getElementById("txtCode");
            var txtCardID = document.getElementById("txtCardID");
            var txtPosition = document.getElementById("txtPosition");
            var txtSalary = document.getElementById("txtSalary");

      
            if (txtName.value == "") {
                alert("带红色 * 号项不能为空！");
                txtName.focus();
                return false;
            }
            if (txtCode.value == "") {
                alert("带红色 * 号项不能为空！");
                txtCode.focus();
                return false;
            }
            if (txtCardID.value == "") {
                alert("带红色 * 号项不能为空！");
                txtCardID.focus();
                return false;
            }
            if (txtPosition.value == "") {
                alert("带红色 * 号项不能为空！");
                txtPosition.focus();
                return false;
            }
            if (txtSalary.value == "") {
                alert("带红色 * 号项不能为空！");
                txtSalary.focus();
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
            <th style="width: 15%">
                姓名：
            </th>
            <td style="text-align: left; width: 85%">
                <input id="txtName" type="text" style="width: 300px;" runat="server" /><span  style="color: Red;">*</span>
            </td>
           
        </tr>
         <tr>
            <th>
                性别：
            </th>
            <td style="text-align: left;">
                <asp:DropDownList ID="ddlSex" runat="server">
                    <asp:ListItem Text="男" Value="男"></asp:ListItem>
                     <asp:ListItem Text="女" Value="女"></asp:ListItem>
                </asp:DropDownList><span  style="color: Red;">*</span>
            </td>
        </tr>
        <tr>
            <th>
                工号：
            </th>
            <td style="text-align: left;">
                <input id="txtCode" type="text" runat="server"  style="width: 300px;" /><span  style="color: Red;">*</span>
            </td>
        </tr>
       
        
        <tr>
            <th>
                身份证号：
            </th>
            <td style="text-align: left;">
                <input id="txtCardID" runat="server" type="text"  style="width: 300px;"  /><span  style="color: Red;">*</span>
            </td>
        </tr>
        
        <tr>
            <th>
                岗位：
            </th>
            <td style="text-align: left;">
                <input id="txtPosition" runat="server" type="text"  style="width: 300px;" /><span  style="color: Red;">*</span>
            </td>
        </tr>
        <tr>
            <th>
                薪资：
            </th>
            <td style="text-align: left;">
                
                 <input id="txtSalary" runat="server" type="text"  style="width: 300px;" /><span  style="color: Red;">*</span>
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
