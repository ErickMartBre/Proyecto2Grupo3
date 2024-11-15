<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Sistema_de_Seguridad.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login/Signup</title>
    <link rel="stylesheet" href="style/Stylelogin.css">
</head>
<body>
    <form id="form1" runat="server">
        <section class="forms-section">
            <h1 class="section-title">Sistema de Administración de Seguridad</h1>
            <div class="forms">
                <div class="form-wrapper is-active">
                    <!-- Login Section -->
                    <button type="button" class="switcher switcher-login" onclick="toggleForm('login')">
                        Login
                        <span class="underline"></span>
                    </button>
                    <div class="form form-login">
                        <fieldset>
                            <legend>Please, enter your user and password for login.</legend>
                            <div class="input-block">
                                <label for="login-username">Usuario</label>
                                <asp:TextBox ID="Text1" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="login-password">Contraseña</label>
                                <asp:TextBox ID="Password1" runat="server" CssClass="input-field" TextMode="Password" Required="true"></asp:TextBox>
                            </div>
                        </fieldset>
                        <asp:Button ID="Button1" runat="server" CssClass="btn-login" Text="Login" OnClick="Login_Click" />
                    </div>
                </div>
                <div class="form-wrapper">
                    <!-- Signup Section -->
                    <button type="button" class="switcher switcher-signup" onclick="toggleForm('signup')">
                        Sign Up
                        <span class="underline"></span>
                    </button>
                    <div class="form form-signup">
                        <fieldset>
                            <legend>Please, enter your details for sign up.</legend>
                            <div class="input-block">
                                <label for="signup-username">Nombre de usuario</label>
                                <asp:TextBox ID="Text2" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-email">Email</label>
                                <asp:TextBox ID="Email1" runat="server" CssClass="input-field" TextMode="Email" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-firstname">Primer nombre</label>
                                <asp:TextBox ID="Text3" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-secondname">Segundo nombre</label>
                                <asp:TextBox ID="Text4" runat="server" CssClass="input-field"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-firstlastname">Primer apellido</label>
                                <asp:TextBox ID="Text5" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-secondlastname">Segundo apellido</label>
                                <asp:TextBox ID="Text6" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-address">Dirección</label>
                                <asp:TextBox ID="Text7" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-phone">Teléfono</label>
                                <asp:TextBox ID="Text8" runat="server" CssClass="input-field" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-password">Clave</label>
                                <asp:TextBox ID="Password2" runat="server" CssClass="input-field" TextMode="Password" Required="true"></asp:TextBox>
                            </div>
                            <div class="input-block">
                                <label for="signup-password-confirm">Confirmar clave</label>
                                <asp:TextBox ID="Password3" runat="server" CssClass="input-field" TextMode="Password" Required="true"></asp:TextBox>
                            </div>
                        </fieldset>
                        <asp:Button ID="Button2" runat="server" CssClass="btn-signup" Text="Sign Up" OnClick="SignUp_Click" />
                    </div>
                </div>
            </div>
        </section>

        <script src="js/login.js"></script>
    </form>
</body>
</html>
