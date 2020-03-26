<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connecting.aspx.cs" Inherits="DataAccess.Connecting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Connection</title>
    <style type="text/css">
        .error {
            color: red;
        }
        .border {
            border: solid silver 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h3>ASP.NET DB Connection</h3>
        <div>
            <h4>Default Connection</h4>
            <div id="resultDiv" runat="server" />
            <div id="connectionDiv" border="1" runat="server"></div>
            <div id="errorDiv" class="error" runat="server"/>

            <div class="border">
                <p>
                    <span>User ID</span>
                    <asp:TextBox ID="userId" runat="server" />
                </p>
                <p>
                    <span>Password</span>
                    <asp:TextBox ID="pwd" runat="server" TextMode="Password"/> 
                </p>
                <p>
                    <span>DB Name</span>
                    <asp:TextBox ID="dbName" runat="server" />
                </p>
                <p>                    
                     <asp:Button ID="send" Text="Connect" runat="server" />
                </p>                
            </div>
        </div>

    </form>
</body>
</html>
