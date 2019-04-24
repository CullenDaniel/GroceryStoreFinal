<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GroceryStoreFinal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grocery Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>

            <asp:Label ID="lblLoyalty" runat="server" Text="Please Enter Loyalty Number Below"></asp:Label>
                <br />
            <asp:TextBox ID="tboxLoyalty" runat="server"></asp:TextBox>
                <br />
                <br />
             <asp:Label ID="lblStore" runat="server" Text="Please Select a store"></asp:Label>
                <br />
            
                <br />
               <asp:ListBox ID="lboxStore" runat="server"></asp:ListBox>
                <br />
                <asp:Button ID="btnLoad" runat="server" Text="load" OnClick="btnLoad_Click"></asp:Button>
                <br />
            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click"></asp:Button>
                <br />
            <asp:Label ID="lblLoyaltyError" runat="server" Text=""></asp:Label>

            </center>
        </div>
    </form>
</body>
</html>
