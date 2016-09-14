<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br class="auto-style1" />
        <br class="auto-style1" />
        <span class="auto-style1">Num1: </span>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
        <br class="auto-style1" />
        <span class="auto-style1">NUm2:</span><asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1"></asp:TextBox>
        <br class="auto-style1" />
        <span class="auto-style1">Resultado: </span>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1"></asp:Label>
        <br />
        <br />
        <br class="auto-style1" />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" OnClick="Button1_Click" Text="Somar" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
