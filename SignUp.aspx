<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="LoginValidation.SignUp" %>

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
        <h1>Sign Up to check your Emoji of your Zodiac!!!</h1>
        <asp:Table runat="server">
            
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
                <asp:TableCell>
            <asp:Button ID="Button1" runat="server" Text="Sign Up" 
                             onclick="Button1_Click" />
                    </asp:TableCell>
                <asp:TableCell>
            <asp:Button ID="Button2" runat="server" Text="Sign In" 
                             onclick="Button2_Click" />
                    </asp:TableCell>
                </asp:TableRow>
        </asp:Table>
    </div>
    
    </form>
</body>
</html>
