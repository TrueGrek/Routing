﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RoutingCalcAsp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%//Так удобней. Если изменить саму ссылку в Global, ничего не изменится %>
 <asp:HyperLink 
            ID="SumLink" 
            runat="server" 
            Text="10 + 20"
            NavigateUrl="<%$RouteUrl:operation=sum, x=10, y=20, routename=Calculator %>">
        </asp:HyperLink>
        <br />
        <asp:HyperLink 
            ID="SubLink" 
            runat="server" 
            Text="10 - 2"
            NavigateUrl="<%$RouteUrl:operation=sub, x=10, y=2, routename=Calculator %>">
        </asp:HyperLink>
        <br />
    </div>
    </form>
</body>
</html>
