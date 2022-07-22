/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cola;

/**
 *
 * @author David
 */
public class ClasePila {
    
    private Object[] A; //arreglo del tipo object en el cual vamos a guardar los elementos de la pila
    private int tamanio;// capacidad maxima de la pila
    private int numElemento;// numero de elementos ingresados en la pila

    public ClasePila(int tamanio) {
        this.tamanio = tamanio; //inicializando el tamaño de la pila
        this.numElemento = 0;//al crear una pila su número de elementos es cero
        A = new Object[this.tamanio];//tamaño para el arreglo reservado en la memoria ram
    }

    public boolean Vacia() {
        if (this.numElemento == 0) {
            return true;
        } else {
            return false;
        }
    }

    public boolean Llena() {
        if (this.tamanio == this.numElemento) {
            return true;
        }
        return false;
    }

    public String Apilar(Object elemento) {
        String r = "Elemento apilado correctamente ";
        if (Llena()) {
            r = "La pila se encuentra llena, no se puede apilar un nuevo elemento ";
        } else {
            A[numElemento] = elemento;
            this.numElemento++;
        }
        return r;
    }
    
    public Object Desapilar(){
        Object auxiliar=null;
        if (!Vacia()){ //si la pila no esta vacía al momento de ingresar al if
            this.numElemento--;
            auxiliar=A[this.numElemento];
            A[this.numElemento]=null;
        }
        return auxiliar;
    }
    
    public Object Cima(){
        Object r=null;
        if (!Vacia()){
            return A[this.numElemento-1];
        }
        return r;
    }
    
  
    public int getNumElemento(){
        return this.numElemento;
    }
    
    public int getTamanio(){
        return this.tamanio;
    }
    
    
}
