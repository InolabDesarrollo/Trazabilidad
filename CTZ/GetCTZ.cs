using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CTZ
{
    public partial class GetCTZ : Form
    {
        private Functions ft = new Functions();
        private string IdCarta;

        public GetCTZ(string idcarta)
        {
            //Funcion para crear un archivo html( con flechas dinamicas) con el formato de las cartas de trazabilidad
            try
            {
                InitializeComponent();
                IdCarta = idcarta;
                string query = "select equipo.identificacion as 'Identificación',equipo.NoSerie as 'No. De Serie',certificado.certificado as 'Certificado',certificado.IntervaloDeMedida,certificado.ProximaCalibracion,cartatrazabilidad.idcartatrazabilidad as 'Carta De Trazabilidad',cartatrazabilidad.iddetalleinstrumento,detalleinstrumento.IdInstrumento from cartatrazabilidad" +
                                " inner join detalleequipo on detalleequipo.idcertificado = cartatrazabilidad.idcertificado" +
                                " inner join equipo on equipo.idequipo = detalleequipo.idequipo" +
                                " inner join certificado on certificado.idcertificado = detalleequipo.idcertificado" +
                                " inner join detalleinstrumento on DetalleInstrumento.IdDetalleInstrumento=CartaTrazabilidad.IdDetalleInstrumento" +
                                " where cartatrazabilidad.idcartatrazabilidad = " + IdCarta + ";";
                SqlDataReader read = ft.GetRead(query);
                //Query recursivo para obtener todos los instrumentos asociados con el certificado necesarios para crear la carta de trazabilidad
                string queryInstru = "with cte as(" +

                                " select instrumento.*,Laboratorio.Nombre,detalleinstrumento.IdLaboratorio as idl,DetalleInstrumento.IdMarcaE,DetalleInstrumento.IdModeloE,DetalleInstrumento.IdProcedimiento from instrumento " +
                                " inner join DetalleInstrumento on DetalleInstrumento.IdInstrumento = Instrumento.IdInstrumento" +

                                " inner join laboratorio on laboratorio.idlaboratorio = detalleinstrumento.idlaboratorio" +

                                " where instrumento.IdInstrumento = " + read.GetValue(read.GetOrdinal("IdInstrumento")).ToString() +

                                "  union all" +

                                " select i.*,k.Nombre,j.IdLaboratorio,j.IdMarcaE,j.IdModeloE,j.IdProcedimiento" +
                                " from instrumento as i" +

                                " inner join DetalleInstrumento as j on j.IdInstrumento = i.IdInstrumento" +

                                " inner join laboratorio as k on k.idlaboratorio = j.idlaboratorio" +
                                ",cte where cte.idinstrumentofk = i.idinstrumento" +
                            " ) " +
                            "select* from cte";
                SqlDataReader read1 = ft.GetRead(queryInstru);
                string t1 = getHtml(read, queryInstru);//Construcción del string html
                System.IO.Directory.CreateDirectory(@"C:\Users\Public\Documents\CTZ");
                File.Copy(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "StampAlone.png"), Path.Combine(@"C:\Users\Public\Documents\CTZ\", "StampAlone.png"), true);

                string file = @"C:\Users\Public\Documents\CTZ\file.html";

                if (File.Exists(file))
                {
                    File.Delete(file);
                    File.WriteAllText(file, t1);
                }
                else
                {
                    File.WriteAllText(file, t1);
                }
                ProcessStartInfo sInfo = new ProcessStartInfo(file);
                Process.Start(sInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private string getHtml(SqlDataReader read, string query)
        {
            string instrus = "";
            List<string> squares = new List<string>();//Colección de instrumentos
            SqlConnection conn = new SqlConnection(ft.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (
                    !ft.IsValid(reader.GetValue(11).ToString())
                    )
                {
                    SqlConnection conn1 = new SqlConnection(ft.connectionString);
                    conn1.Open();
                    string sql = "declare @idmarca as int;" +
                                    " set @idmarca = (select idmarcae from ModeloE where IdModeloE = " + reader.GetValue(12) + ")" +
                                    " select modeloe.Descripcion as Modelo,marcae.Nombre as Marca, Procedimiento.Descripcion from DetalleInstrumento" +
                                    " inner join MarcaE on MarcaE.IdMarcaE = @idmarca" +
                                    " inner join ModeloE on ModeloE.IdModeloE = DetalleInstrumento.IdModeloE" +
                                    " inner join Procedimiento on Procedimiento.IdProcedimiento = DetalleInstrumento.IdProcedimiento" +
                                    " where DetalleInstrumento.IdModeloE = " + reader.GetValue(12) + "; ";
                    SqlCommand cmd1 = new SqlCommand(sql, conn1);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        instrus = "<div id = 'd2' class='cenam'>" +

                            "<p>" + reader.GetValue(9) + "</p>" +
                            "<P>" + reader.GetValue(1) + "</P>" +
                            "<p>Marca: " + reader1.GetValue(1).ToString() + "</p>" +
                            "<p>Modelo: " + reader1.GetValue(0).ToString() + "</p>" +
                            "<p>Intervalo de medida: " + reader.GetValue(8) + "</p>" +
                            "<p>Incertidumbre: ±" + reader.GetValue(5) + " °C</p>" +
                            "<p>Certificado: " + reader.GetValue(2) + "</p>" +
                            "<p id='vigencia'>Vigencia: " + ft.ToDate(reader.GetValue(7).ToString()).AddYears(1).ToString("MMM yyyy", CultureInfo.CreateSpecificCulture("es-MX")) + "</p>" +
                            "<p id='proc'>" + reader1.GetValue(2) + "</p>" +

                        "</div>";
                        squares.Add(instrus);
                    }
                    conn1.Close();
                }
                else
                {
                    SqlConnection conn1 = new SqlConnection(ft.connectionString);
                    conn1.Open();
                    string sql = "select nombre from MarcaE where IdMarcaE= " + reader.GetValue(11) + ";";
                    SqlCommand cmd1 = new SqlCommand(sql, conn1);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        instrus = "<div id = 'd1' class='cenam'>" +

                           "<p>" + reader.GetValue(9) + "</p>" +
                           "<p>" + reader.GetValue(1) + "</p>" +
                           "<p>Marca: " + reader1.GetValue(0) + "</p>" +
                           "<p>Serie: " + reader.GetValue(4) + "</p>" +
                           "<p>Certificado: " + reader.GetValue(2) + "</p>" +
                           "<p id='vigencia'>Vigencia: " + ft.ToDate(reader.GetValue(7).ToString()).AddYears(1).ToString("MMM yyyy", CultureInfo.CreateSpecificCulture("es-MX")) + "</p>" +
                       "</div>";
                        squares.Add(instrus);
                    }
                    conn1.Close();
                }
                instrus = "";
            }
            conn.Close();
            //La escritur del HTML es estática, se programó solo para los sensores elitech, sin embargo la idea es que se escribiera de forma dinamica sin importar la cantidad de elementos en la colección squares
            string source = @"
<html>
    <head>

        <style>
            connection .line .arrow {
                top: -5px;
                height: 0px;
                width: 0px;
                position: absolute;
                border-bottom: 6px solid transparent;
                border-top: 6px solid transparent;
                background-clip: border-box;
                }
                connection .line .arrow-fw {
                border-right: 12px solid black;
                }

                connection .line .arrow-bw {
                left: 100%;
                border-left: 12px solid black;
                transform: translateX(-12px);
                }

                connection .line .text {
                position: absolute;
                top: 100%;
                left: 50%;
                transform: translate(-50%, -100%);
                }

                connection .line {
                position:absolute;
                height:2px;

                background-color: black;
                }

        </style>
        <script >
                                (()=>{
                    function getNumberOrDef(val, def) {
                        return typeof val === 'number' && !isNaN(val) ? val : def;
                    }

                    function isVisible(element) {
                        return element && element.style.visibility !== 'hidden';
                    }

                    function inside(minX, minY, maxX, maxY, x1, y1) {
                        return minX <= x1 && x1 <= maxX && minY <= y1 && y1 <= maxY;
                    }

                    function intersectionPoint (x1, y1, x2, y2, minX, minY, maxX, maxY) {
                        var min = Math.min, max = Math.max;
                        var good = inside.bind(null, min(x1, x2), min(y1, y2), max(x1, x2), max(y1, y2));

                        if ((x1 <= minX && x2 <= minX) || (y1 <= minY && y2 <= minY) || (x1 >= maxX && x2 >= maxX) || (y1 >= maxY && y2 >= maxY) || (inside(minX, minY, maxX, maxY, x1, y1) && inside(minX, minY, maxX, maxY, x2, y2)))
                        return null;

                        var m = (y2 - y1) / (x2 - x1);
                        var y = m * (minX - x1) + y1;
                        if (minY < y && y < maxY && good(minX, y)) return {x: minX, y:y};

                        y = m * (maxX - x1) + y1;
                        if (minY < y && y < maxY && good(maxX, y)) return {x: maxX, y:y};

                        var x = (minY - y1) / m + x1;
                        if (minX < x && x < maxX && good(x, minY)) return {x: x, y:minY};

                        x = (maxY - y1) / m + x1;
                        if (minX < x && x < maxX && good(x, maxY)) return {x: x, y:maxY};

                        return null;
                    }

                    function adjustLine(from, to, line, trafo){
                        var color = trafo && trafo.color || 'black';
                        var W = trafo && trafo.width || 2;

                        var fromB = parseFloat(from.style.top) ? null : from.getBoundingClientRect();
                        var toB = parseFloat(to.style.top) ? null : to.getBoundingClientRect();
                        var fromBStartY = (fromB ? window.scrollY + fromB.top : parseFloat(from.style.top));
                        var fromBStartX = (fromB ? window.scrollX + fromB.left : parseFloat(from.style.left));
                        var toBStartY = (toB ? window.scrollY + toB.top : parseFloat(to.style.top));
                        var toBStartX = (toB ? window.scrollX + toB.left : parseFloat(to.style.left));
                        var fromBWidth = (fromB ? fromB.width : parseFloat(from.style.width) || from.offsetWidth);
                        var fromBHeight = (fromB ? fromB.height : parseFloat(from.style.height) || from.offsetHeight);
                        var toBWidth = (toB ? toB.width : parseFloat(to.style.width) || to.offsetWidth);
                        var toBHeight = (toB ? toB.height : parseFloat(to.style.height) || to.offsetHeight);

                        var fT = fromBStartY + fromBHeight * getNumberOrDef(trafo && trafo.fromY, getNumberOrDef(trafo, 0.5));
                        var tT = toBStartY + toBHeight * getNumberOrDef(trafo && trafo.toY, getNumberOrDef(trafo, 0.5));
                        var fL = fromBStartX + fromBWidth * getNumberOrDef(trafo && trafo.fromX, getNumberOrDef(trafo, 0.5));
                        var tL = toBStartX + toBWidth * getNumberOrDef(trafo && trafo.toX, getNumberOrDef(trafo, 0.5));

                        var CA   = Math.abs(tT - fT);
                        var CO   = Math.abs(tL - fL);
                        var H    = Math.sqrt(CA*CA + CO*CO);
                        var ANG  = 180 / Math.PI * Math.acos( CO/H );

                        if((fT >= tT || fL >= tL) && (tT >= fT || tL >= fL)) {
                        ANG *= -1;
                        }

                        if (trafo && trafo.onlyVisible) {
                        var arrangeFrom = intersectionPoint(fL, fT, tL, tT, fromBStartX, fromBStartY, fromBStartX + fromBWidth, fromBStartY + fromBHeight);
                        var arrangeTo = intersectionPoint(fL, fT, tL, tT, toBStartX, toBStartY, toBStartX + toBWidth, toBStartY + toBHeight);

                        if (arrangeFrom) {
                            fL = arrangeFrom.x;
                            fT = arrangeFrom.y;
                        }
                        if (arrangeTo) {
                            tL = arrangeTo.x;
                            tT = arrangeTo.y;
                        }
                        CA   = Math.abs(tT - fT);
                        CO   = Math.abs(tL - fL);
                        H    = Math.sqrt(CA*CA + CO*CO);
                        }

                        var top  = (tT+fT)/2 - W/2;
                        var left = (tL+fL)/2 - H/2;

                        var arrows  = [...line.getElementsByClassName('arrow')];

                        var needSwap = (fL > tL || (fL == tL && fT < tT));
                        var arrowFw = needSwap && isVisible(arrows[0]) && arrows[0] || !needSwap && isVisible(arrows[1]) && arrows[1];
                        var arrowBw = !needSwap && isVisible(arrows[0]) && arrows[0] || needSwap && isVisible(arrows[1]) && arrows[1];
                        if (arrowFw) {
                        arrowFw.classList.remove('arrow-bw');
                        arrowFw.classList.add('arrow-fw');
                        arrowFw.style.borderRightColor = color;
                        arrowFw.style.top = W/2-6 + 'px';
                        }
                        if (arrowBw) {
                        arrowBw.classList.remove('arrow-fw');
                        arrowBw.classList.add('arrow-bw');
                        arrowBw.style.borderLeftColor = color;
                        arrowBw.style.top = W/2-6 + 'px';
                        }
                        line.style.display = 'none';
                        line.style['-webkit-transform'] = 'rotate('+ ANG +'deg)';
                        line.style['-moz-transform'] = 'rotate('+ ANG +'deg)';
                        line.style['-ms-transform'] = 'rotate('+ ANG +'deg)';
                        line.style['-o-transform'] = 'rotate('+ ANG +'deg)';
                        line.style['-transform'] = 'rotate('+ ANG +'deg)';
                        line.style.top    = top+'px';
                        line.style.left   = left+'px';
                        line.style.width  = H + 'px';
                        line.style.height = W + 'px';
                        line.style.background = 'linear-gradient(to right, ' +
                        (arrowFw ? 'transparent' : color) +' 11px, ' +
                        color + ' 11px ' + (H - 11) + 'px, ' +
                        (arrowBw ? 'transparent' : color) + ' ' + (H - 11) + 'px 100%)';
                        line.style.display = 'initial';
                    }

                    function repaintConnection(connectionElement) {
                        var fromQ = connectionElement.getAttribute('from');
                        var fromE = document.querySelector(fromQ);
                        var toQ = connectionElement.getAttribute('to');
                        var toE = document.querySelector(toQ);
                        connectedObserver.observe(fromE, {attributes:true});
                        connectedObserver.observe(toE, {attributes:true});

                        var lineE = connectionElement.getElementsByClassName('line')[0];
                        if (!lineE) {
                        lineE = document.createElement('div');
                        lineE.classList.add('line');
                        connectionElement.appendChild(lineE);
                        }
                        var needTail = connectionElement.hasAttribute('tail');
                        var needHead = connectionElement.hasAttribute('head');
                        var arrows = lineE.getElementsByClassName('arrow');
                        var tail = arrows[0];
                        var head = arrows[1];
                        if (!tail && (needHead || needTail)) {
                        tail = document.createElement('div');
                        tail.classList.add('arrow');
                        lineE.appendChild(tail);
                        }

                        if (!head && needHead) {
                        head = document.createElement('div');
                        head.classList.add('arrow');
                        lineE.appendChild(head);
                        }

                        tail && (tail.style.visibility = needTail ? 'visible' : 'hidden');
                        head && (head.style.visibility = needHead ? 'visible' : 'hidden');

                        var textE = lineE.getElementsByClassName('text')[0];
                        var textMessage = connectionElement.getAttribute('text');

                        if (!textE && textMessage) {
                        textE = document.createElement('div');
                        textE.classList.add('text');
                        lineE.appendChild(textE);
                        }
                        if (textE && textE.innerText != textMessage) {
                        textE.innerText = textMessage;
                        }

                        adjustLine(fromE, toE, lineE, {
                        color: connectionElement.getAttribute('color'),
                        onlyVisible: connectionElement.hasAttribute('onlyVisible'),
                        fromX: parseFloat(connectionElement.getAttribute('fromX')),
                        fromY: parseFloat(connectionElement.getAttribute('fromY')),
                        toX: parseFloat(connectionElement.getAttribute('toX')),
                        toY: parseFloat(connectionElement.getAttribute('toY')),
                        width: parseFloat(connectionElement.getAttribute('width'))
                        });
                    }

                    function repaintWithoutObserve(tag) {
                        connectionObserver.observe(tag, {attributeFilter: []});
                        repaintConnection(tag);
                        connectionObserver.observe(tag, {attributes:true, childList:true, subtree: true});
                    }

                    function createOne(newElement) {
                        connectionElements.push(newElement);
                        repaintConnection(newElement);
                        connectionObserver.observe(newElement, {attributes:true, childList:true, subtree: true});
                    }

                    function create() {
                        bodyObserver.observe(document.body, {childList:true, subtree: true});
                        [...document.body.getElementsByTagName('connection')].forEach(createOne);
                    }

                    function removeConnection(tag) {
                        for(var i = connectionElements.length - 1; i >= 0; i--)
                        if(connectionElements[i] === tag)
                            connectionElements.splice(i, 1);

                        connectionObserver.observe(tag, {attributeFilter: []});
                    }

                    function changedConnectedTag(changes) {
                        changes.forEach(e => {
                        var changedElem = e.target;
                        var wasConnection = false;
                        for (var i = 0; i < connectionElements.length; ++i) {
                            var fromE = document.querySelector(connectionElements[i].getAttribute('from'));
                            if (fromE === changedElem) {
                            wasConnection = true;
                            repaintWithoutObserve(connectionElements[i]);
                            continue;
                            }
                            var toE = document.querySelector(connectionElements[i].getAttribute('to'));
                            if (toE === changedElem) {
                            wasConnection = true;
                            repaintWithoutObserve(connectionElements[i]);
                            }
                        }
                        if (!wasConnection) {
                            connectionObserver.observe(changedElem, {attributeFilter: []});
                        }
                        });
                    }

                    function changedConnectionTag(changes) {
                        changes.forEach(e => {
                        var conn = e.target;
                        if (conn.tagName.toLowerCase() !== 'connection' && e.attributeName === 'class')
                            ;
                        while (conn && conn.tagName.toLowerCase() !== 'connection')
                            conn = conn.parentElement;
                        if (!conn) return;
                        repaintWithoutObserve(conn);
                        });
                    }

                    function bodyNewElement(changes) {
                        changes.forEach(e => {
                        e.removedNodes.forEach(n => {
                            if (n.tagName && n.tagName.toLowerCase() === 'connection')
                            removeConnection(n);
                        });
                        e.addedNodes.forEach(n => {
                            if (n.tagName && n.tagName.toLowerCase() === 'connection')
                            createOne(n);
                        });
                        });
                    }

                    var connectionElements = [];
                    var MutationObserver = window.MutationObserver ||
                        window.WebKitMutationObserver || window.MozMutationObserver;
                    var bodyObserver = new MutationObserver(bodyNewElement);
                    var connectionObserver = new MutationObserver(changedConnectionTag);
                    var connectedObserver = new MutationObserver(changedConnectedTag);
                    document.body && create() || window.addEventListener('load', create);
                    })();

        </script>
        <meta charset='UTF-8' lang='mx-es'>
        <style>
            html{
                width:21.6cm;
                height:27.9cm;
            }
            body{
                width:21.6cm;
                height:27.9cm;

                margin-top: 0.5rem;
                margin-left: 0.5rem;
                margin-right: 0.5rem;
                margin-bottom: 0.5rem;
                display: flex;
                align-items: center;
                flex-direction: column;
                justify-content: space-between;
            }
            footer{
                display:flex;
                flex-direction: column;
                align-self: flex-end;
                align-items: center;
                margin-left: 1cm;
                margin-right: 1cm;
                margin-bottom: 1cm;
                bottom:0;
                left:0rem;
                height: 2cm;
            }
            header{
                width: 100%;
                display:flex;
                justify-content: space-between;
                align-items: center;
                border-bottom: 2px solid  #4472C4;
                height: 10%;
                margin-left: 4cm;
                margin-right: 4cm;
            }
            #divHeadL{
                display: flex;
                flex-direction: row;
                text-align: left;
                margin-left: 2cm;
                align-items: flex-end;
            }
            #logo{
                padding-right: 5mm;
                border-right: 1px solid #4472C4;;
            }
            #divHeadL #logo img{
                width:4cm;
            }

            section{
                display:flex;
                flex-direction: column;
                justify-content: stretch;
                align-items: center;
                width: 100%;
                height: 100%;
            }
            #title{
                top:0;
                left:0;
                margin-top: 0.2cm;
            }

            #divHeadR{
                text-align: right;
                color: #4472C4;
                margin-right: 1cm;
                font: bold;
            }
            #divHeadR span #ide{
                color:#4472C4;
            }
            #divHeadR span b{
                color:grey
            }

            h4{
                text-align: center;
            }
            #fNota{
                text-align: justify;
                margin: 5px;
                }
            #pie{
                border-top: 2px solid #4472C4;
                display:flex;
                justify-content: space-between;
                align-items:stretch;
                width: 100%;
                margin-bottom: 50mm;
            }
            #pie span{
                margin: 7px;
                font-size: 11pt;
                color:#4472C4;
            }

            #tExterna{
                display: flex;

                flex-direction: column;
                width: 100%;
                border-bottom: 1px dashed #4472C4;
                align-items: center;
            }
            #tinterna{
                display: flex;

                flex-direction: column;
                width: 100%;

                align-items: center;
            }
            .cenam{
               text-align: center;
                border: 2px solid #4472C4;
                margin:0.85cm;
                width: auto;
                padding: 2.5mm;
            }

            .cenam p{
                font-size: 10pt;
                margin: 2px;
            }
            .cenam h4{
                margin: 2px;
            }
            #te{
                width: 100%;
               text-align: right;
               margin: 7px;
               color:#4472C4;
            }
            #te span{
                margin: 2mm;
            }
            #nota{
                font-size: 10pt;
                margin-bottom: 0.5cm;
            }

            #doc{
                display: flex;
                flex-direction: column;
                padding-left: 5mm;
                justify-items: self-end;
            }
            #doc h2{
                margin:0;
                color:#4472C4;
            }
            #doc p{
                margin:0;
                color:grey;
            }
            #proc{
                position: absolute;
                margin-top: 3.21%;

                font: bolder;
                text-align: left;
            }
            #vigencia{
                position: absolute;
                margin-top:1.45%;

                text-align: left;
                margin-left: -2%;;
            }

            #d3 #vigencia{
                font-weight: bold;
            }

            #stamp{
                position:absolute;
                width: 3cm;
                height: 3cm;
                margin-left: 7.32cm;
                margin-top: 4.5cm;
            }
        </style>
    </head>
    <body>
        <header>
            <div id='divHeadL'>
                <div id='logo'><img src='http://www.inolab.com/images/logoInolab.jpg' alt=''></div>
                <div id='doc'>
                    <h2>Carta de Trazabilidad</h2>
                    <p><b>Sistema de Calidad IES</b></p>
                </div>
            </div>
            <div id='divHeadR' >
                <span id='identificacion'><b>Equipo: </b> <b id='ide'>" + read.GetValue(read.GetOrdinal("Identificación")).ToString() + "</b></span>" +
                       "</div>" +

                   "</header>" +
                   "<section>" +
                       "<img src='StampAlone.png' id='stamp'>" +
                       "<div id = 'title'><h3> CALIBRACIÓN DE TEMPERATURA</h3></div>" +

                              "<div id = 'tExterna'>" +

                                   "<div id = 'cnm' class='cenam'>" +
                               "<h4>CENAM</h4>" +
                               "<p>PATRÓN NACIONAL DE TEMPERATURA</p>" +
                           "</div>" +
                           "<connection from = '#cnm' to= '#d1' color= '#4472C4' fromY= '1' toY= '1' tail onlyVisible></connection>" +//Configuración de las flechas
                           squares[1] +
                           "<connection from = '#d1' to= '#d2' color= '#4472C4' fromY= '1' toY= '1' tail onlyVisible></connection>" +
                           "<div id = 'te'>" +
                               "<span id= 'identificacion'><b> TRAZABILIDAD EXTERNA</b></span>" +
                           "</div>" +
                       "</div>" +
                       "<div id = 'tInterna'>" +
                           "<div id= 'te'>" +
                               "<span id= 'identificacion'><b> TRAZABILIDAD INTERNA</b></span>" +
                           "</div>" +
                          squares[0] +
                           "<connection from = '#d2' to= '#d3' color= '#4472C4' fromY= '1' toY= '1' tail onlyVisible></connection>" +
                           "<div id = 'd3' class='cenam'>" +

                               "<p>INOLAB ESPECIALISTAS DE SERVICIO S.A.DE C.V.</p>" +
                               "<P>SENSOR DE TEMPERATURA</P>" +
                               "<p>Marca: Elitech</p>" +
                               "<p>Modelo: TemLog20</p>" +
                               "<p>Intervalo de medida: " + read.GetValue(read.GetOrdinal("IntervaloDeMedida")).ToString() + "</p>" +
                               "<p>Incertidumbre: ±0,13 °C</p>" +
                               "<p>Certificado: " + read.GetValue(read.GetOrdinal("Certificado")).ToString() + "</p>" +
                               "<p id='vigencia'>Vigencia: " + ft.ToDate(read.GetValue(read.GetOrdinal("ProximaCalibracion")).ToString()).ToString("dd MMM yyyy", CultureInfo.CreateSpecificCulture("es-MX")) + "</p>" +
                           "</div>" +

                       "</div>" +
                   "</section>" +
                   "<footer>" +
                       "<div id = 'fNota'>" +
                           "<span id= 'nota'>" +
                               "<p>" +
                                   "<b> Nota: </b>La incertidumbre expandida reportada en este documento considera un factor de cobertura k= 2 con un nivel de confianza de aproximadamente 95%." +
                               "</p>" +
                           "</span>" +
                       "</div>" +
                       "<div id = 'pie'>" +
                           "<span id= 'i1'> INO - FI - 071 </span>" +
                           "<span id= 'i2'> REVISIÓN 0.0</span>" +
                           "<span id = 'i3'> PÁGINA 1 de 1</span>" +
                       "</div>" +
                   "</footer>" +
               "</body>" +
           "</html>";
            return source;
        }
    }
}