export class Persona{

    constructor(nombre, apellido, edad){
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    }


}

export class Alumno  extends Persona{

    constructor(nombre, apellido, edad, legajo){
        super(nombre,apellido,edad);
        this.legajo = legajo;
    }
}

export class Perro{

    constructor(nombre){
        this.nombre = nombre;
    }
}



