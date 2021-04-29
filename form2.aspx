<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="E_Ticaret.form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta name="viewport" content="width=device=width, initial-scale=1, shrivk-to-fit=no" />
  <%--  <link href="css\mdb.min.css" rel="stylesheet" />--%>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>

<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table class="table table-bordered">
            <tr>
               
                <td>
                    <asp:Label ID="Label3" runat="server" Text="KULLANICI ADI"></asp:Label>
                </td>
                <td>  
                     <asp:TextBox ID="TextBox1" runat="server" Width="186px"></asp:TextBox>
                </td>
               
            </tr>
                 <tr>
                
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ŞİFRE"></asp:Label>
                </td>
                <td>  
                     <asp:TextBox ID="TextBox2" runat="server" Width="223px"></asp:TextBox>
                </td>
               
            </tr>
                 <tr>
                
                <td>üye ol</td>
                <td>
                   <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="üye ol" />
                </td>
               
               
            </tr>

           <%-- <br />
            <asp:Label ID="Label1" runat="server" Text="KULLANICI ADI"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="186px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ŞİFRE"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="223px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="üye ol" />
            <br />--%>
            </table>
        </div>
    </form>
</body>
</html>
