<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EVPRAK5_1_22SA11A116.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="#6699FF" BorderColor="Black" ForeColor="#000066" Height="293px" Width="789px">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#CC00CC" ForeColor="Black" OnClick="Button1_Click" Text="Tampilkan Daftar Supplier" />
        </div>
    </form>
</body>
</html>
