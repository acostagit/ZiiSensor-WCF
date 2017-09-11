﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZiiSensor.UI.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</head>
<body style="background-color: #0026ff">
    <div class="container-fluid">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-5 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">ZiiSolution | Login</div>
                    <div style="float: right; font-size: 80%; position: relative; top: -10px"><a href="#">Esqueceu a senha?</a></div>
                </div>

                <div style="padding-top: 60px" class="panel-body">

                    <div style="display: none" id="login-alert" class="alert alert-danger col-sm-12"></div>

                    <form id="loginform" runat="server">

                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox ID="txtLogin" CssClass="form-control" Width="300px" runat="server"></asp:TextBox>
                            <%--<input id="login-username" type="text" class="form-control" name="username" value="" placeholder="Usuário" />--%>
                        </div>

                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox ID="txtSenha" CssClass="form-control" Width="300" runat="server"></asp:TextBox>
                            <%--<input id="login-password" type="password" class="form-control" name="password" placeholder="Senha" />--%>
                        </div>



                        <div class="input-group">
                            <div class="checkbox">
                                <label>
                                    <input id="login-remember" type="checkbox" name="remember" value="1" />
                                    Lembrar
                                </label>
                            </div>
                        </div>


                        <div style="margin-top: 10px" class="form-group">
                            <!-- Button -->

                            <div class="col-sm-12 controls">
                                <!--<a id="btn-fblogin" href="#" class="btn btn-primary">Login com Facebook</a>-->

                                <asp:Button ID="btnLogin" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click" />

                            </div>
                        </div>


                        <div class="form-group">
                            <div class="col-md-12 control">
                                <div style="border-top: 1px solid#888; padding-top: 15px; font-size: 85%">
                                    Não tem uma conta! 
                                        <a href="#" onclick="$('#loginbox').hide(); $('#signupbox').show()">Crie uma agora.
                                        </a>
                                </div>
                            </div>
                        </div>
                    </form>



                </div>
            </div>
        </div>
    </div>
</body>
</html>
