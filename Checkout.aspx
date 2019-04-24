<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="GroceryStoreFinal.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:ListBox ID="lboxCart" runat="server"></asp:ListBox>
                <br />
            <asp:Button ID="btnRemove" runat="server" Text="Remove Selected Item" />
                <br />
            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click"></asp:Button>
                <br />
            <asp:Label ID="lblPlacedOrder" runat="server" Text=""></asp:Label>

            </center>
        </div>
    </form>
</body>
</html>
