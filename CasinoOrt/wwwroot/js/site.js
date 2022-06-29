// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var mesaSuma = 0;
var usuarioSuma = 0;

var mesaCantAs = 0;
var usuarioCantAs = 0;

var cartaOculta;
var mazo;

var canHit = true; //allows the player (you) to draw while yourSum <= 21


 //document.getElementById("botonBK").addEventListener("click", play);


function play() {
    buildDeck();
    shuffleDeck();
    startGame();
   /* document.getElementById("usuario-cartas").append("       MIS CARTAS");*/
}

//window.onload = function () {
//    buildDeck();
//    shuffleDeck();
//    startGame();
//    document.getElementById("usuario-cartas").append("       MIS CARTAS");

//}
//    /*onload de tragamonedas*/

    //var credito = Math.floor(Math.random() * 4) + 9;
    //var imagenes = ["1.png", "2.png", "4.png", "5.png", "7.png", "8.png"];
    //var premios = [3, 2, 3, 7, 2, 8];
    //var numeros_actuales = [];


function buildDeck() {
    let valores = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];
    let simbolos = ["C", "D", "H", "S"];
    mazo = [];

    for (let i = 0; i < simbolos.length; i++) {
        for (let j = 0; j < valores.length; j++) {
            mazo.push(valores[j] + "-" + simbolos[i]); //A-C -> K-C, A-D -> K-D
        }
    }
    // console.log(deck);
}

function shuffleDeck() {
    for (let i = 0; i < mazo.length; i++) {
        /*  let j = Math.floor(Math.random() * mazo.length); // (0-1) * 52 => (0-51.9999) */

        let j = Math.floor(Math.random() * mazo.length + 1);

        let temp = mazo[i];
        mazo[i] = mazo[j];
        mazo[j] = temp;
    }
    console.log(mazo);
}





function startGame() {
    cartaOculta = mazo.pop();
    mesaSuma += valorCarta(cartaOculta);
    mesaCantAs += chequearAs(cartaOculta);
    // console.log(hidden);
    // console.log(dealerSum);
    while (mesaSuma < 17) {
        //<img src="./cards/4-C.png">
        // creo una variable de tipo img
        let nuevaCarta = document.createElement("img");
        // saco una carta del mazo
        let card = mazo.pop();
        // le asigno a la variable la carta q saque
        nuevaCarta.src = "/css/img/cartas/" + card + ".png";
        mesaSuma += valorCarta(card);
        mesaCantAs += chequearAs(card);
        // adjuntamos la nueva carta al id "mesa-cartas"
        document.getElementById("mesa-cartas").append(nuevaCarta);
    }
    // repartimos cartas hasta q la suma sea de por lo menos 17 a la mesa
    console.log(mesaSuma);

    // repartimos 2 cartas al usuario
    for (let i = 0; i < 2; i++) {
        let cardImg = document.createElement("img");
        let card = mazo.pop();
        cardImg.src = "/css/img/cartas/" + card + ".png";
        usuarioSuma += valorCarta(card);
        usuarioCantAs += chequearAs(card);
        // adjuntamos la nueva carta al id "usuario-cartas"
        document.getElementById("usuario-cartas").append(cardImg);
    }

    console.log(usuarioSuma);
    document.getElementById("hit").addEventListener("click", pedir);
    document.getElementById("stay").addEventListener("click", quedarse);

}




function pedir() {
    if (!canHit) {
        return;
    }

    //  le damos una nueva carta
    let cardImg = document.createElement("img");
    let card = mazo.pop();
    cardImg.src = "/css/img/cartas/" + card + ".png";
    usuarioSuma += valorCarta(card);
    usuarioCantAs += chequearAs(card);
    document.getElementById("usuario-cartas").append(cardImg);

    if (reduceAce(usuarioSuma, usuarioCantAs) > 21) { //A, J, 8 -> 1 + 10 + 8
        canHit = false;
    }

}

function quedarse() {
    mesaSuma = reduceAce(mesaSuma, mesaCantAs);
    usuarioSuma = reduceAce(usuarioSuma, usuarioCantAs);

    canHit = false;
    // mostramos la carta oculta de la mesa 
    document.getElementById("hidden").src = "/css/img/cartas/" + cartaOculta + ".png";

    let message = "";
    if (usuarioSuma > 21) {
        message = "Te pasaste! Gana la casa";
    }
    else if (mesaSuma > 21) {
        message = "Gana el jugador";
    }
    //both you and dealer <= 21
    else if (usuarioSuma == mesaSuma) {
        message = "Empate!";
    }
    else if (usuarioSuma > mesaSuma) {
        message = "Por poco. Gana el jugador!";
    }
    else if (usuarioSuma < mesaSuma) {
        message = "Estuviste cerca. Gana la Casa!";
    }

    // mostramos la suma total de numeros de cada jugador
    document.getElementById("mesa-suma").innerText = mesaSuma;
    document.getElementById("usuario-suma").innerText = usuarioSuma;
    // mensaje del resultado
    document.getElementById("results").innerText = message;
}

function valorCarta(card) {
    let data = card.split("-"); // "4-C" -> ["4", "C"]
    let value = data[0];

    // preguntamos si la primera pos no es un digito, por ende seria una A J Q K 

    if (isNaN(value)) {
        if (value == "A") {
            return 11;
        }
        return 10;
    }
    return parseInt(value);
}


// si es un A retorna el valor de as como un 1 
function chequearAs(card) {
    if (card[0] == "A") {
        return 1;
    }
    return 0;
}

function reduceAce(playerSum, playerAceCount) {
    while (playerSum > 21 && playerAceCount > 0) {
        playerSum -= 10;
        playerAceCount -= 1;
    }
    return playerSum;
}


/* tragamonedas */

var credito = 0;
var imagenes = [];
var premios = [];
var numeros_actuales = [];

function play2() {
     credito = Math.floor(Math.random() * 4) + 9;
     imagenes = ["1.png", "2.png", "4.png", "5.png", "7.png", "8.png"];
     premios = [3, 2, 3, 7, 2, 8];
     numeros_actuales = [];
    inicio();
}

//window.onload = inicio;
//var credito = Math.floor(Math.random() * 4) + 9;
//var imagenes = ["1.png", "2.png", "4.png", "5.png", "7.png", "8.png"];
//var premios = [3, 2, 3, 7, 2, 8];
//var numeros_actuales = [];

function inicio() {
    document.getElementById("tirar").onclick = lanzar_inicio;
    document.getElementById("cruz").onclick = cerrar;
    actualizar();
}

function lanzar_inicio() {
    if (credito > 0) {
        numeros_actuales = [];
        for (let k = 0; k < document.getElementsByClassName("ventana").length; k++) {
            numeros_actuales.push(escoger_numero());
            mostrar_imagen(k, numeros_actuales[k]);
        }
        comparar();
    }
}

function escoger_numero() {
    var azar = Math.floor(Math.random() * imagenes.length);
    return azar;
}

function mostrar_imagen(num, im) {
    document.getElementsByClassName("imagen")[num].getElementsByTagName("img")[0].src = "/css/img/formas/" + imagenes[im];
}

function comparar() {
    if (numeros_actuales[0] == numeros_actuales[1] && numeros_actuales[1] == numeros_actuales[2]) {
        // tenemos premio
        let p = premios[numeros_actuales[0]];
        let mensaje = `Has ganado ${p}`;
        mostrar_mensaje(mensaje);
        credito += premios[numeros_actuales[0]];
    }
    // le saca una moneda
    credito--;
    actualizar();
}

function actualizar() {
    document.getElementById("dinero").innerHTML = credito;
    if (credito < 1) {
        mostrar_mensaje("<b>GAME OVER </b> <div class = 'subtitulo'> No te queda mas dinero </div>");
    }
}

function mostrar_mensaje(mensaje) {
    document.getElementById("velo").style.display = "flex";
    document.getElementById("mensaje").innerHTML = mensaje;
}

function cerrar() {
    document.getElementById("velo").style.display = "none";
}
