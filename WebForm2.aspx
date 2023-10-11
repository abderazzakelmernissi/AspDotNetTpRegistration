<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AspTpInscri.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    <form id="form1" runat="server">
    <div style="height: 329px">
    
        <asp:Label ID="Label3" runat="server" Text="nom"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="*" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="prenom"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Pass word"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="*" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Configuration Pw"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" Text="*" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label11" runat="server" Text="question"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:Label ID="Label12" runat="server" Text="*" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label13" runat="server" Text="reponse"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Label ID="Label14" runat="server" Text="*" Visible="False"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="s'inscrire" Width="132px" />
    
    </div>
    </form>
</body>
</html>
