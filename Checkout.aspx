<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="GroceryStoreFinal.Checkout" %>

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

            <asp:Label ID="lblYouSelected" runat="server" Text="You have selected the following items."></asp:Label>
                <br />
            <asp:Label ID="lblDisplayOrder" runat="server" Text=""></asp:Label>
                         
            <asp:Button class="btn btn-dark" ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click"></asp:Button>
                <br />
            <asp:Label ID="lblPlacedOrder" runat="server" Text=""></asp:Label>

            </center>
        </div>
    </form>
</body>
</html>
