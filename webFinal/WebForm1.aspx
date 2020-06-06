<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webFinal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #main{
            width:1200px;
            margin:20px auto;
            text-align:center;
        }
        .yt{
            font-size:150px;
            color:rebeccapurple;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <asp:Button ID="Button1" runat="server" Text="Şansını dene!" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_YT" runat="server" Text="" CssClass="yt"></asp:Label>

            <br /><br />
            <asp:Label ID="lbl_yazi" runat="server"></asp:Label>
            <asp:Label ID="lbl_tura" runat="server"></asp:Label>
            <asp:Label ID="lbl_top" runat="server"></asp:Label>

             
            <asp:Label ID="lbl_deger" runat="server" Text=""></asp:Label>

            <br /><br />
      
        </div>
    </form>
</body>
</html>
