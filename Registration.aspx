<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mala3ebnaa Registration Form</title>

    <link href="Style.css" rel="stylesheet" />
    
    <style>
        @import url('https://fonts.googleapis.com/family=Bitter|Crete+Round|Pacifico');
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <div class="container">
                <div class="inner1">
                    <span>Sign In with Social Network</span><br />
                    <br />
                    <a href="#" class="fb"><b>Log in with Facebook</b></a>
                    <br /><br /><br /><br /><br />
                    <a href="#" class="tw"><b>Log in with Twitter</b></a>
                    <br /><br /><br /><br /><br />
                    <a href="#" class="gl"><b>Log in with Gmail</b></a>
                    <br /><br /><br /><br /><br /><br />
                </div>
                <div class="inner2">
                    <h3>Sign Up</h3>

                    <asp:TextBox ID="txturname" placeholder="Username" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtemail" placeholder="Email" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtpasswd" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtcops" placeholder="Retype Password" TextMode="Password" runat="server"></asp:TextBox>

                    <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Sign Up" />
                </div>
            </div>
        </section>
    </form>
</body>
</html>
