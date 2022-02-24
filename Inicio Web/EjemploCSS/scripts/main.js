
// window.addEventListener("DOMContentLoaded", ()=>{
//     const dialogo = document.getElementById("dialogo");

//     console.log(dialogo);
// });

// import { Persona } from "./modules/persona.js";
// import { Alumno } from "./modules/persona.js";
// import { Perro } from "./modules/persona.js";
// const p = new Alumno("Jose", "Colmenares", 40, 1111);

// p.saludar = ()=>{

//     console.log(`Soy ${p.apellido}`);

// };

// console.log(p);
// p.saludar();

// console.log(p instanceof Perro);

// let {nombre, apellido, edad} = {...p};

// console.log(nombre);
// console.log(apellido)
// // document.getElementById("articuloModificado").classList.add("cambiarColorArticulo");

// document.getElementById("articuloModificado").setAttribute("class","cambiarColorArticulo2");

// document.getElementById("articuloModificado").classList.remove()

const dialogo = document.getElementById("dialogo");
const btnOpenForm = document.querySelector("#openForm");
const btnCerrarForm = document.querySelector("#btnCerrar");

btnOpenForm.addEventListener("click", handlerOpenForm);
btnCerrarForm.addEventListener("click", function(){

    dialogo.removeAttribute("open");

});





function handlerOpenForm()
{
    dialogo.setAttribute("open","true");
}


// console.log(btnOpenForm);

// console.log(dialogo);






fetch("https://localhost:44318/api/persona/1")
.then(res=> res.ok ?  res.json() : Promise.reject({error : "Error"}))
.then(data=>{


    console.log(data);

});

const formulario = document.getElementById("formulario");

const btnEnviar = document.getElementById("btnEnviar");

btnEnviar.addEventListener("click", ()=>{

    const persona = 
    {
        nombre: formulario.nombre.value,
        apellido:formulario.apellido.value,
        sexo :formulario.sexo.value,
    };

    console.log(persona);


    fetch("https://localhost:44318/api/persona/alta",
    {
        method:"POST",
        body:JSON.stringify(persona),
        headers:{"Content-Type": "application/json; charset=utf-8"}
    }    
    )
    .then(res=> res.ok ?  res.json() : Promise.reject({error : "Error"}))
    .then(data=> console.log(data));

    





});


// function miPromesa(num)
// {
//     return new Promise((res,rej)=>{

//          if(num>10)
//          {
//              res("numero ok");
//          }else
//          {
//              rej("numero no ok");
//          }

//     });
// }

// miPromesa(5).then(data=>console.log(data)).catch(error=>console.log(error))