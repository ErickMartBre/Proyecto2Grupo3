<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Sistema_de_Seguridad.Details" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalles del Usuario</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        h1 {
            text-align: center;
            color: #333;
        }
        .user-details {
            margin-top: 20px;
        }
        .user-details label {
            display: block;
            font-weight: bold;
            margin-top: 10px;
            color: #555;
        }
        .user-details .value {
            margin-top: 5px;
            padding: 10px;
            background-color: #f9f9f9;
            border: 1px solid #ddd;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Detalles del Usuario</h1>
            <div class="user-details">
                <label>Nombre de Usuario:</label>
                <div class="value"><asp:Label ID="lblNombreUsuario" runat="server" Text=""></asp:Label></div>
                
                <label>Email:</label>
                <div class="value"><asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></div>
                
                <label>Primer Nombre:</label>
                <div class="value"><asp:Label ID="lblPrimerNombre" runat="server" Text=""></asp:Label></div>
                
                <label>Segundo Nombre:</label>
                <div class="value"><asp:Label ID="lblSegundoNombre" runat="server" Text=""></asp:Label></div>
                
                <label>Primer Apellido:</label>
                <div class="value"><asp:Label ID="lblPrimerApellido" runat="server" Text=""></asp:Label></div>
                
                <label>Segundo Apellido:</label>
                <div class="value"><asp:Label ID="lblSegundoApellido" runat="server" Text=""></asp:Label></div>
                
                <label>Dirección:</label>
                <div class="value"><asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label></div>
                
                <label>Teléfono:</label>
                <div class="value"><asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label></div>
                
                <label>Fecha de Registro:</label>
                <div class="value"><asp:Label ID="lblFechaRegistro" runat="server" Text=""></asp:Label></div>
            </div>
        </div>
    </form>
</body>
</html>
