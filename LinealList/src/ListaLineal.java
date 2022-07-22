/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author David
 */
public class ListaLineal {

    private Nodo inicio;
    private Nodo ultimo;

    public ListaLineal(Nodo inicio) {
        this.inicio = null;

    }

    public ListaLineal(Nodo inicio, Nodo ultimo) {
        this.inicio = inicio;
        this.ultimo = ultimo;
    }

    public Nodo getInicio() {
        return inicio;
    }

    public void setInicio(Nodo inicio) {
        this.inicio = inicio;
    }

    public String ingresarInicio(Object elemento) {
        String r = "El nodo se ha ingresado correctamente";
        Nodo nuevo = new Nodo(elemento);
        if (inicio == null) {
            inicio = nuevo;
        } else {
            nuevo.setSig(inicio);
            inicio = nuevo;
        }

        return r;
    }

    public String ingresarFinal(Object elemento) {
        String r = "Nodo ingresado al final correctamente";
        Nodo nuevo = new Nodo(elemento);
        Nodo aux;
        if (inicio == null) {
            inicio = nuevo;
        } else {
            aux = inicio;
            while (aux.getSig() != null) {
                aux = aux.getSig();
            }
            aux.setSig(nuevo);
        }
        return r;
    }

    public String ingresarPrueba(Nodo nuevo, double precio) {

        String r = "Nodo ingresado correctamente ";

        Nodo aux;
        Producto producto;

        if (inicio == null) {
            inicio = nuevo;
        } else {
            aux = inicio;
            producto = (Producto) aux.getInfo();
            while (aux.getSig() != null) {

                if (producto.getPrecio() > precio) {

                    aux = aux.getSig();
                    producto = (Producto) aux.getInfo();
                    ingresarPrueba(aux, producto.getPrecio());
                } else {
                    aux.setSig(aux);
                }

            }

            aux.setSig(nuevo);
        }

        return r;
    }

    public Nodo retirarPrimero() {
        //String r;
        Nodo nuevo;
        if (inicio == null) {
            return null;
        } else {
            nuevo = inicio;
            inicio = inicio.getSig();
            return nuevo;

        }

        //  return r;
    }

    public int contarNodo() {

        int contador = 0;
        if (inicio != null) {
            Nodo aux = inicio;
            contador++;
            while (aux.getSig() != null) {
                aux = aux.getSig();
                contador++;
            }
        }
        return contador;
    }
    // Deber contar el nummero de nodos y eliminar el primer nodo de la lista

    //Metodo lista circular
    public int ContarNodosCircular(Nodo p) {
        int contador = 0;
        Nodo auxiliar;

        if (ultimo != null) {

            auxiliar = ultimo.getSig();
            Nodo aux = auxiliar;
            while (aux.getSig() != ultimo) {

                if (auxiliar != p) {

                    contador++;
                    return contador;

                }
                aux = aux.getSig();
            }

        }

        return contador;

    }

}
