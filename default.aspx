<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GroceryStoreFinal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grocery Store</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</head>

<style>

    body{background-color: #787878;}

</style>

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
                <br />
                <asp:Button class="btn btn-dark" ID="btnLoad" runat="server" Text="load stores" OnClick="btnLoad_Click"></asp:Button>
                <br />
                <br />
               <asp:Button class="btn btn-dark" ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click"></asp:Button>
                <br />
               <asp:Label ID="lblLoyaltyError" runat="server" Text=""></asp:Label>

            </center>
        </div>
    </form>
</body>
</html>
