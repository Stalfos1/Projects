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
public class ClaseCola {
//Implemente lo requerido en el form de este package, en el boton "Pila"
    Object[] V;
    int tam, ne, inicio, fin;

    public ClaseCola(int t) {
        tam = t;
        V = new Object[tam];
        ne = 0;
        inicio = 0;
        fin = 0;
    }

    public boolean Llena() {
        if (ne == tam) {
            return true;
        } else {
            return false;
        }
    }

    public boolean Vacia() {
        if (ne == 0) {
            return true;
        } else {
            return false;
        }
    }

    public void Ingresar(Object elem) {
        if (Llena() == false) {
            V[fin++] = elem;
            ne++;
            if (fin == tam) {
                fin = 0;
            }
        }
    }

    public Object Retirar() {
        Object aux = null;
        if (!Vacia()) {
            aux = V[inicio];
            inicio++;
            ne--;
            if (inicio == tam) {
                inicio = 0;
            }
        }
        return aux;
    }

    public int getNumElementos() {
        return ne;
    }
    
       public int getTam(){
        return this.tam;
    }


}
