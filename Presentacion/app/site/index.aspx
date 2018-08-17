<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.app.site.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login MySite</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
</head>
<body style="background-color: black">
    <nav>
        <br/>
    </nav>
    <header>
        <div style="background-image: url('https://ps.w.org/brute-force-login-protection/assets/banner-772x250.png?rev=938424')"
         class="container text-warning col-sm-8">
            <h1>Login</h1>
            
            <form  id="frm_login" runat="server">
             <div class="row">
                 <br/>
                 <br/>
                <div class="col-sm-6">
                    <asp:Label class="form-control-sm" ID="lbl_username" runat="server">Username:</asp:Label>
                    <br/>
                    <asp:TextBox class="form-control-sm" ID="txt_username" runat="server" placeholder="Your User ..."/>
                    <br/>
                    <asp:Label class="form-control-sm" ID="lbl_pass" runat="server">Password:</asp:Label>
                    <br/>
                    <asp:TextBox class="form-control-sm" ID="txt_pass" TextMode="Password" runat="server" placeholder="Your Pass ..."/>                
                    <br/>
                    <br/>
                    <asp:Button class="btn btn-success" ID="btn_login" runat="server" Text="LOGIN" OnClick="btn_login_Click"/>                    
                    <br/>
                    <br/>
                </div>
                 <div class="col-sm-6">
                        <asp:Label class="alert alert-danger alert-link" ID="lbl_message_error" runat="server" Text=" "/>
                 </div>                
                 <br/>
             </div>
            </form>
            
        </div>
    </header>

    
</body>
</html>
