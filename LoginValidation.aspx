<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginValidation.aspx.cs" Inherits="LoginValidation.LoginValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Sample Registration Page</title>
    <style type="text/css">
        .style1
        {
            width: 1055px;
            height: 500px;
            background-image:url("images/blue.png");
            background-size:100%;
            background-repeat:no-repeat;
            background-position:center;
            padding-left:600px;
            padding-top:250px;
        }
    </style>
</head>
<body>
    <form id="form1" class="style1" runat="server">
    <div>
        <h1>Log In to check your Emoji of your Zodiac!!!</h1>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>Full Name:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Username:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Password:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TxtPassword" runat="server"
                                 TextMode="Password"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Re Password:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TxtRePassword" runat="server"
                                 TextMode="Password"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Address:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Age:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Gender:</asp:TableCell>
                <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server"
                                  AppendDataBoundItems="true">
                <asp:ListItem Value="-1">Select</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
            <asp:Button ID="Sign" runat="server" Text="Sign Up" 
                             onclick="Sign_In" />
                    </asp:TableCell>
                <asp:TableCell>
            <asp:Button ID="log" runat="server" Text="Log In" 
                             onclick="Log_In" />
                    </asp:TableCell>
                </asp:TableRow>
        </asp:Table>
    </div>
    
    </form>
</body>
</html>