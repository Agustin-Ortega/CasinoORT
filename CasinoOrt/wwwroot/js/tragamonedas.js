
/* tragamonedas */


//function play2() {
//    var credito = Math.floor(Math.random() * 4) + 9;
//    var imagenes = ["1.png", "2.png", "4.png", "5.png", "7.png", "8.png"];
//    var premios = [3, 2, 3, 7, 2, 8];
//    var numeros_actuales = [];
//    inicio();
//}

//window.onload = inicio;
//var credito = Math.floor(Math.random() * 4) + 9;
//var imagenes = ["1.png", "2.png", "4.png", "5.png", "7.png", "8.png"];
//var premios = [3, 2, 3, 7, 2, 8];
//var numeros_actuales = [];

//function inicio() {
//    document.getElementById("tirar").onclick = lanzar_inicio;
//    document.getElementById("cruz").onclick = cerrar;
//    actualizar();
//}

//function lanzar_inicio() {
//    if (credito > 0) {
//        numeros_actuales = [];
//        for (let k = 0; k < document.getElementsByClassName("ventana").length; k++) {
//            numeros_actuales.push(escoger_numero());
//            mostrar_imagen(k, numeros_actuales[k]);
//        }
//        comparar();
//    }
//}

//function escoger_numero() {
//    var azar = Math.floor(Math.random() * imagenes.length);
//    return azar;
//}

//function mostrar_imagen(num, im) {
//    document.getElementsByClassName("imagen")[num].getElementsByTagName("img")[0].src = "/css/img/formas/" + imagenes[im];
//}

//function comparar() {
//    if (numeros_actuales[0] == numeros_actuales[1] && numeros_actuales[1] == numeros_actuales[2]) {
//        // tenemos premio
//        let p = premios[numeros_actuales[0]];
//        let mensaje = `Has ganado ${p}`;
//        mostrar_mensaje(mensaje);
//        credito += premios[numeros_actuales[0]];
//    }
//    // le saca una moneda
//    credito--;
//    actualizar();
//}

//function actualizar() {
//    document.getElementById("dinero").innerHTML = credito;
//    if (credito < 1) {
//        mostrar_mensaje("<b>GAME OVER </b> <div class = 'subtitulo'> No te queda mas dinero </div>");
//    }
//}

//function mostrar_mensaje(mensaje) {
//    document.getElementById("velo").style.display = "flex";
//    document.getElementById("mensaje").innerHTML = mensaje;
//}

//function cerrar() {
//    document.getElementById("velo").style.display = "none";
//}
