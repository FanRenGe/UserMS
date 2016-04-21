<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersManage.aspx.cs" Inherits="UsersManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
     <link href="css/Manage.css" rel="stylesheet" type="text/css" />

    <script src="JavaScript/Jquery.js" type="text/javascript"></script>
    <script src="JavaScript/Add.js" type="text/javascript"></script>
    
</head>
<body>
    <form id="form1" runat="server">
   <div class="Body_Title">员工管理</div>
    <div>
    <div style="line-height:30px; padding-left:10px;   text-align:left;  height:30px;">
<input id="Button1"type="button" value="新增" onclick='window.location="UsersAdd.aspx"' />
    </div>
   
        <asp:Repeater ID="RpNews" runat="server">
        <HeaderTemplate>
            <table  class="Admin_Table" >
                <thead>
                    <tr class="Admin_Table_Title">
                        <th >选择</th>
                        <th >姓名</th>
                        <th >性别</th>
                        <th >工号</th>
                        <th >身份证号</th>
                        <th >岗位</th>
                        <th >薪资</th>
                        <th >详细操作</th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td align="center"><input type="checkbox" value='<%#Eval("ID") %>' name="CheckMes" /></td>
             
                <td align="center"><%#Eval("Name")%></td>
                  <td align="center"><%#Eval("Sex")%></td>
                  <td align="center"><%#Eval("Code")%></td>
                  <td align="center"><%#Eval("CardID")%></td>
                   <td align="center"><%#Eval("Position")%></td>
                   <td align="center"><%#Eval("Salary")%></td>
                  <td align="center"><a href="UsersAdd.aspx?id=<%#Eval("ID") %>">修改</a> <asp:LinkButton ID="ibDel" runat="server"   Text="删除"
                                    CommandArgument='<%# Eval("ID") %>' 
               OnClientClick="return confirm('确定删除当前项?')" onclick="ibDel_ItemDeleting" />
                   
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
   
    <div class="Body_Search">
        <div class="page_Left">
            <input id="BtnAllSelect" type="button" value="全选" />&nbsp;<asp:Button ID="BtnAllDel" runat="server" Text="删除选中" onclick="BtnAllDel_Click" 
                />
        </div>
        <div class="page_Right">
            <asp:Label runat="server" ID="PageMes"></asp:Label>
            <asp:LinkButton ID="LBHome" runat="server" CssClass="pageBtn" 
                onclick="LBHome_Click">[首页]</asp:LinkButton>
            <asp:LinkButton ID="LBUp" runat="server" CssClass="pageBtn" 
                onclick="LBUp_Click">[上一页]</asp:LinkButton>
            <asp:LinkButton ID="LBNext" runat="server" CssClass="pageBtn" 
                onclick="LBNext_Click">[下一页]</asp:LinkButton>
            <asp:LinkButton ID="LBEnd" runat="server" CssClass="pageBtn" 
                onclick="LBEnd_Click">[尾页]</asp:LinkButton>
        </div>
    </div>
    </div>
    <asp:HiddenField ID="HSelectID" runat="server" Value=""/>
    <asp:HiddenField ID="HNowPage" runat="server" Value="1"/><!--当前页-->
    <asp:HiddenField ID="HPageSize" runat="server" Value=""/><!--共多少条-->
    <asp:HiddenField ID="HAllPage" runat="server" Value="0"/><!--总共多少页-->
    <asp:HiddenField ID="HCount" runat="server" Value="15"/><!--每页多少条-->
    </form>
</body>
</html>