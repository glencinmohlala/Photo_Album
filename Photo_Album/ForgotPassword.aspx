<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Photo_Album.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Forgot Password<br />
            <br />
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp; Create New Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCreatePassw" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;Confirm New Password:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtConfirmPassw" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        &nbsp;<asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click1" Text="Back" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
