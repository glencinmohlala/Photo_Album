<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadPhoto.aspx.cs" Inherits="Photo_Album.uploadPhoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #00FFFF">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWelcome" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Choose the picture you want to upload:&nbsp; 
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;<asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" style="height: 26px" Width="150px" />
            &nbsp;<br />
            <br />
&nbsp; <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Search for photos using the photo ID:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearch" runat="server" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server" style="margin-left: 35px" Width="370px">
            </asp:GridView>
&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="150px" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnShare" runat="server" Text="Share" Width="150px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDownload" runat="server" OnClick="btnDownload_Click" Text="Download" Width="150px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View" Width="150px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnShowAll" runat="server" OnClick="btnShowAll_Click" Text="Show Data" Width="149px" />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="#66FFFF" BorderStyle="Groove" ForeColor="Aqua">
                Terms &amp; Conditions</asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
