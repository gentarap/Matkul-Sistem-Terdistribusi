<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="P2ASPNET_22SA11A116.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td align="right"> Masukan Patch Untuk Menyiapkan File:
                    </td>
                    <td>
                        <asp:TextBox ID="txtpath" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:FileUpload ID="fileupload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" />
                    </td>
                </tr>
                <tr>
                    <td valign="tip">Isi Pesan :

                    </td>
                    <td>
                        <asp:TextBox ID="textBoxContents" runat="server" TabIndex="0" Height="100px"
                            TextMode="MultiLine" Width="250px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>