<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="GroceryStoreFinal.ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>

            <asp:Label ID="lblDisplayStore" runat="server" Text=""></asp:Label>
            <br />
            <asp:ListBox ID="lboxItemsSold" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add Selected Item" OnClick="btnAdd_Click" />
            <br />
            <asp:Button ID="btnRemove" runat="server" Text="Remove Selected Item" OnClick="btnRemove_Click" />
            <br />
            <asp:Button ID="btnClear" runat="server" Text="Clear all selected Items" OnClick="btnClear_Click" />
            <br />
            <asp:ListBox ID="lboxItemsSelected" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click"></asp:Button>
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            
            </center>
        </div>
    </form>
</body>
</html>