<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ClientsideEncryption.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/aes.js" type="text/javascript"></script>
    <link href="Styles/StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>AES Encryption</title>
    <script type="text/javascript">

        function SubmitsEncry() {

            debugger;
            var txtUserName = document.getElementById("<%=txtUserName.ClientID %>").value.trim();
            var txtpassword = document.getElementById("<%=txtpassword.ClientID %>").value.trim();

            if (txtUserName == "") {
                alert('Please enter UserName');
                return false;
            }
            else if (txtpassword == "") {
                alert('Please enter Password');
                return false;
            }
            else {
                var key = CryptoJS.enc.Utf8.parse('8080808080808080');
                var iv = CryptoJS.enc.Utf8.parse('8080808080808080');

                var encryptedlogin = CryptoJS.AES.encrypt(CryptoJS.enc.Utf8.parse(txtUserName), key,
                {
                    keySize: 128 / 8,
                    iv: iv,
                    mode: CryptoJS.mode.CBC,
                    padding: CryptoJS.pad.Pkcs7
                });

                document.getElementById("<%=HDusername.ClientID %>").value = encryptedlogin;

                var encryptedpassword = CryptoJS.AES.encrypt(CryptoJS.enc.Utf8.parse(txtpassword), key,
                {
                    keySize: 128 / 8,
                    iv: iv,
                    mode: CryptoJS.mode.CBC,
                    padding: CryptoJS.pad.Pkcs7
                });

                document.getElementById("<%=HDPassword.ClientID %>").value = encryptedpassword;

                alert('encrypted Username :' + encryptedlogin);
                alert('encrypted password :' + encryptedpassword);
            }
        }
    </script>
</head>
<body>
    <form id="Form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <fieldset style="width:200px;">
        <legend>Login</legend>
        <div class='container'>
            <asp:Label ID="Name" runat="server" Text="UserName:" CssClass="lbl" />
            <br />
            <asp:TextBox ID="txtUserName" Height="22px" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HDusername" runat="server" />
        </div>
        <div class='container'>
            <asp:Label ID="lblPwd" runat="server" Text="Password:" CssClass="lbl" />
            <br />
            <asp:TextBox ID="txtpassword" Height="22px" runat="server" TextMode="Password"></asp:TextBox>
            <asp:HiddenField ID="HDPassword" runat="server" />
        </div>
        <div class='container'>
            <asp:Button ID="btnlogin" OnClientClick="return SubmitsEncry();" runat="server" Text="Sign In"
                OnClick="btnlogin_Click" />
        </div>
    </fieldset>
    </form>
</body>
</html>
