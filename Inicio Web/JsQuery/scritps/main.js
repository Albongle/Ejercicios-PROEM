const elemento = $("#contenedor");
const elemento2 = document.querySelector("#contenedor2");


elemento.append("<h1>Hola Mundo desde JQuery</h1>");



elemento2.innerHTML = "<h1>Hola Mundo desde JS Puro</h1>"


const h = document.createElement("h1");
h.textContent = "Hola 2";


elemento2.appendChild(h);


console.log(elemento2);
console.log(elemento);