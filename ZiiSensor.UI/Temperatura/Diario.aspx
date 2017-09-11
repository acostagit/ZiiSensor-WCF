<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Diario.aspx.cs" Inherits="ZiiSensor.UI.Temperatura.Diario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            //google.load("visualization", "1", { packages: ["corechart"] });

            ////$.get("http://localhost:58227/TemperaturaServico.svc/ObterTodos", function (data) {
            ////    alert(data);
            ////});
        

            getDadosAjax();



        });



       // google.load("visualization", "1", { packages: ["corechart"] });

        //var url = 'http://localhost:58227/TemperaturaServico.svc/ObterTodos';

        ////function test() {
        ////    $.get("http://localhost:58227/TemperaturaServico.svc/ObterTodos", function (data) {
        ////        alert(data);
        ////    });
        ////}

        function getDadosAjax() {
            //test();

            $.support.cors = true;

            $(function () {
                $.ajax({
                    type: 'GET',
                    dataType: 'jsonp',
                    contentType: 'text/plain',
                    //url: 'http://localhost:58227/TemperaturaServico.svc/ObterTodos',
                    url: '../Default.aspx/GeraGraficoSemanal',
                    data: '{}',
                    crossDomain: true,
                    success:
                        function (data, status) {
                            //var data = response.d;
                            console.log(data);
                            alert(response);
                            //alert(xmlHttpRequest.responseText);
                            //drawchart(response);
                          //  gerarGrafico(response);
                            //desenharGrafico();
                        },
                    error: function (xhr, ajaxOptions, thrownError) {
                        alert(xhr.status);
                        alert(thrownError);
                    }
                    ////error: function (xmlHttpRequest, status, err) {
                    ////    alert(xmlHttpRequest.responseJSON);
                    ////    //alert("Erro ao carregar dados! Tente novamente.");
                    ////}
                });
            })
        }

        function gerarGrafico(dataValues) {

            var data = new google.visualization.DataTable();

            data.addColumn('string', 'DataHora');
            data.addColumn('number', 'o C');

            data.addRows(3);

            var dadosDoGrafico = JSON.parse(dataValues);

            for (var i = 0; i < dadosDoGrafico.length; i++) {
                data.setValue(i, 0, dadosDoGrafico[i].DataHora.substring(11, dadosDoGrafico[i].DataHora.length, dadosDoGrafico[i].DataHora));
                data.setValue(i, 1, dadosDoGrafico[i].TemperaturaAtual);
            }

            var options = {
                hAxis: {
                    title: 'Hora'
                },
                title: 'Temperatura diária',
                height: 400,
                width: 800,
                position: "top",
                fontsize: "14px",
                chartArea: { center: 200 },
                vAxis: {
                    title: 'Temperatura'
                }
            };

            var chart = new google.visualization.LineChart(document.getElementById('chartdiv'));
            chart.draw(data, options);

        }


    </script>

    <div class="panel panel-default" style="padding-left: 320px;">
        <div class="panel-heading">Gráfico diário</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-lg-10" id="graficoDiario">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
