<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="GroceryStoreFinal.ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

<style>

    body{background-color: #787878;}

</style>


<body>
    <form id="form1" runat="server">
        <div>
            <center>

            <asp:Label ID="lblDisplayStore" runat="server" Text=""></asp:Label>
            <br />
            <asp:ListBox ID="lboxItemsSold" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Enter the number of quantity."></asp:Label>         
            <br />
            <asp:TextBox ID="TxtBoxQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn btn-dark" ID="Button1" runat="server" Text="Add Selected Item" OnClick="btnAdd_Click" />              
            <br />
            <br />
            <asp:Button class="btn btn-dark" ID="btnRemove" runat="server" Text="Remove Selected Item" OnClick="btnRemove_Click" />
            <br />
            <br />
            <asp:Button class="btn btn-dark" ID="btnClear" runat="server" Text="Clear all selected Items" OnClick="btnClear_Click" />
            <br />
            <br />
            <asp:ListBox ID="lboxItemsSelected" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Button class="btn btn-dark" ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click"></asp:Button>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

            


            </center>

        </div>
    </form>
</body>
</html>
