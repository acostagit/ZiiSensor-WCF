<!DOCTYPE html>
<html>
<head>
    <title>ZiiSensor</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="~/Content/style.css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <header>
        <nav class="navbar navbar-inverse navbar-static-top topo-fixo">
            <div class="container">
                <div class="navbar-header">
                    <h1>Gráfico de Temperatura</h1>
                    <div class="topo">
                        <a href="#" class="icone_menu"><i class="material-icons">dehaze</i></a>
                    </div>
                </div>
            </div>
        </nav>
    </header>
    <nav class="menu">
        <ul class="nav" id="side-menu" style="display: block;">
            <li>
                <a href="#"><i class="fa fa-list-alt fa-fw"></i><span class="nav-label">Cliente</span><span class="fa arrow"></span></a>
                <ul class="nav nav-second-level collapse">
                    <li><a href="Cliente.aspx">Novo</a></li>
                    <li><a href="Incluir.aspx">Consultar</a></li>
                </ul>
            </li>
            <li>
                <a href="#"><i class="fa fa-list-alt fa-fw"></i><span class="nav-label">Temperatura</span><span class="fa arrow"></span></a>
                <ul class="nav nav-second-level collapse">
                    <li><a href="diaria.aspx">Diária</a></li>
                    <li><a href="diaria.aspx">Diária</a></li>
                    <li><a href="diaria.aspx">Diária</a></li>
                    <li><a href="diaria.aspx">Diária</a></li>
                </ul>
            </li>
            <li>
                <a href="#"><i class="fa fa-list-alt fa-fw"></i><span class="nav-label">Relatórios</span><span class="fa arrow"></span></a>
                <ul class="nav nav-second-level collapse">
                    <li><a href="Grafico.aspx">Diário</a></li>
                    <li><a href="Grafico.aspx">Diário</a></li>
                    <li><a href="Grafico.aspx">Diário</a></li>
                </ul>
            </li>

            <li>
                <a href="#"><i class="fa fa-user"></i><span class="nav-label">Usuário</span><span class="fa arrow"></span></a>
                <ul class="nav navbar-top-links navbar-right">

                    <li class="dropdown">
                        <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#" aria-expanded="false">
                            <i class="fa fa-user"></i><b class="caret"></b>
                        </a>
                        <ul class="dropdown-menu">
                            <li class="divider"></li>
                            <li>
                                <a href="Conta.aspx">Perfil</a>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <a href="Login.aspx">Sair</a>
                            </li>

                        </ul>
                    </li>
                </ul>
            </li>
        </ul>
    </nav>

    <hr />
    <footer>
        <p>&copy; ZiiSolution - Soluções inteligentes</p>
        <span>São Bernardo do Campo/SP</span>
    </footer>




    <script type="text/javascript" src="~/Scripts/script.js"></script>
    <script src="../Scripts/modernizr-2.6.2.js"></script>
    <script src="../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>

   
</body>
</html>
