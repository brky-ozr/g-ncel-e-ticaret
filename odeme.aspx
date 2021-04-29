<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="odeme.aspx.cs" Inherits="E_Ticaret.odeme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Kart Numarası"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="CVV"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ödemeyi tamamla" />
        </p>
        <p>
            &nbsp;&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="height: 19px; width: 1401px">
            &nbsp;</p>
    </form>
</body>
</html>
