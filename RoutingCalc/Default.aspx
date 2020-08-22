<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RoutingCalc.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <a href="/calc/sum/10/20">10 + 20</a><br />
        <a href="/calc/sub/10/3">10 - 3</a><br />
        <a href="/calc/mul/10/2">10 * 2</a><br />
        <a href="/calc/div/10/5">10 / 5</a><br />
    </div>
    </form>
</body>
</html>
