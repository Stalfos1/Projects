/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author David
 */
public class ArbolBB {

    
    //AL final implemente el metodo ingeniero 
    private NodoABB raiz;

    public ArbolBB() {
        this.raiz = null;
    }

    public NodoABB getRaiz() {
        return raiz;
    }

    public void setRaiz(NodoABB raiz) {
        this.raiz = raiz;
    }

    public String ingresar(Object elemento) {
        String mensaje = " Nodo ingresado correctamente";
        String cedulaNueva, cedulaArbol;
        Votante votNueva, votArbol;
        NodoABB aux;
        NodoABB nuevo = new NodoABB(elemento);
        int comparacion;

        if (raiz == null) {
            raiz = nuevo;
        } else {
            aux = raiz;
            votNueva = (Votante) nuevo.getInfo();
            cedulaNueva = votNueva.getCedula();
            while (aux != null) {
                votArbol = (Votante) aux.getInfo();
                cedulaArbol = votArbol.getCedula();
                comparacion = cedulaNueva.compareTo(cedulaArbol);

                if (comparacion < 0) {
                    if (aux.getHijoIzq() == null) {
                        aux.setHijoIzq(nuevo);
                        mensaje = "Nodo ingresado al lado izquierdo del ultimo nodo";
                        break;
                    } else {
                        aux = aux.getHijoIzq();
                    }

                } else if (comparacion > 0) {
                    if (aux.getHijoDer() == null) {
                        aux.setHijoDer(nuevo);
                        mensaje = "Nodo ingresado al lado derecho del ultimo nodo";
                        break;
                    } else {
                        aux = aux.getHijoDer();
                    }

                } else {
                    mensaje = "La cedula ya ha sido usada";
                    break;
                }
            }
        }

        return mensaje;
    }

    public String preOrder(NodoABB r) {
        String respuesta = "";
        Votante vot;
        if (r != null) {
            vot = (Votante) r.getInfo();
            respuesta += vot.getCedula() + ";";
            respuesta += preOrder(r.getHijoIzq());
            respuesta += preOrder(r.getHijoDer());
        }

        return respuesta;
    }

    public String inOrder(NodoABB r) {
        String respuesta = "";
        Votante vot;
        if (r != null) {
            respuesta += inOrder(r.getHijoIzq());
            vot = (Votante) r.getInfo();
            respuesta += vot.getCedula() + ";";
            respuesta += inOrder(r.getHijoDer());
        }

        return respuesta;
    }

    public String postOrder(NodoABB r) {
        String respuesta = "";
        Votante vot;
        if (r != null) {
            respuesta += postOrder(r.getHijoIzq());
            respuesta += postOrder(r.getHijoDer());
            vot = (Votante) r.getInfo();
            respuesta += vot.getCedula() + ";";

        }

        return respuesta;
    }

    public String Buscar(NodoABB r, String cedula) {
        String respuesta = "La cedula aun no ha sido usada";
        Object a;
        Votante votar;
        if (r != null) {

            votar = (Votante) r.getInfo();
            if (votar.getCedula().compareTo(cedula) > 0) {

                respuesta = Buscar(r.getHijoIzq(), cedula);

            } else if (votar.getCedula().compareTo(cedula) < 0) {

                respuesta = Buscar(r.getHijoDer(), cedula);
            } else {
                respuesta = "Cedula: " + votar.getCedula() + "\t Nombre: " + votar.getNombre() + "\t Recinto: " + votar.getRecinto() + "\t Provincia: " + votar.getCodProvincia()
                        + "\t Canton: " + votar.getCodCanton() + "\t Parroquia: " + votar.getCodParroquia() + "\t Mesa: " + votar.getNumMesa();
            }
        }

        return respuesta;
    }
    
    
   

    public String numeroNodos(String cedula) {
        String[] arregloCedulas = cedula.split(",");
        Votante votar;
        String resultado = "";
        String cedulaAux;
        NodoABB continuar;
        for (int i = 0; i < arregloCedulas.length; i++) {

            resultado+= Contar(raiz, arregloCedulas[i] )+",";
            //resultado += ContarIntento2(raiz, arregloCedulas[i]) + ",";
        }

        return resultado;
    }

    public int ContarIntento2(NodoABB r, String cedula) {
        int contador = 0;
        Votante votar;

        if (r != null) {
            NodoABB aux = r;

            votar = (Votante) aux.getInfo();

            if (votar.getCedula().compareTo(cedula) > 0) {

                contador += ContarIntento2(aux.getHijoIzq(), cedula);

            } else if (votar.getCedula().compareTo(cedula) < 0) {

                contador += ContarIntento2(aux.getHijoDer(), cedula);
            } else if (votar.getCedula().compareTo(cedula) == 0) {

                
               
                    if (aux.getHijoDer() != null) {
                        contador++;

                    }
                    if (aux.getHijoIzq() != null) {
                        contador++;
                    }
                

            }

        }

        return contador;
    }

    public int Contar(NodoABB r, String cedula) {
        int contador = 0;
        int comparacion;

        Votante votar;
        if (r != null) {
            NodoABB aux = r;

            votar = (Votante) r.getInfo();

            if (votar.getCedula().compareTo(cedula) > 0) {

                contador += Contar(aux.getHijoIzq(), cedula);

            } else if (votar.getCedula().compareTo(cedula) < 0) {

                contador += Contar(aux.getHijoDer(), cedula);
            } else if (votar.getCedula().compareTo(cedula) == 0) {

               
                if(aux.getHijoIzq()!=null){
                    contador++;
                   contador+= ContarpostOrder(aux.getHijoIzq(), contador);
                }
                if(aux.getHijoDer()!=null){
                    contador++;
                    contador += ContarpostOrder(aux.getHijoDer(), contador);
                }

               /* contador += ContarpostOrder(aux.getHijoIzq(), contador);
                contador++;
                contador += ContarpostOrder(aux.getHijoDer(), contador);
                contador++;*/

                

            }
            return contador;

        }
        return contador;

    }

    public int ContarpostOrder(NodoABB r, int contador) {
        contador++;
        if (r != null) {
            ContarpostOrder(r.getHijoIzq(), contador);

            ContarpostOrder(r.getHijoDer(), contador);
            return contador;

        } else {
            contador = 0;
        }

        return contador;
    }

   
    
    // Metodo del examen
    public void CambiarNodo(NodoABB r){
        NodoABB auxiliar;
         Object a;
        Votante votar;
        votar=(Votante) r.getInfo();
      // auxiliar= Buscar(votar.getCedula(), r);
       if(   Buscar ( votar.getCedula(), r   ) !=null){
           auxiliar= postOrderNodo(  Buscar ( votar.getCedula(), r )  );
           
           r=auxiliar;
       }

    }
    
    
     public NodoABB Buscar(String cedula, NodoABB r){
        NodoABB respuesta=null;
        Object a;
        Votante votar;
        if (r != null) {

            votar = (Votante) r.getInfo();
            if (votar.getCedula().compareTo(cedula) > 0) {

                respuesta = Buscar( cedula,r.getHijoIzq());

            } else if (votar.getCedula().compareTo(cedula) < 0) {

                respuesta = Buscar( cedula,r.getHijoDer());
            } else {
                respuesta= r;
            }
        }

        
        
        return respuesta;
    }
    
     public NodoABB postOrderNodo(NodoABB r){
        NodoABB auxiliar;
         String respuesta;
        Votante vot;
        Votante votAux ;
        int contador=0;
        
      vot = (Votante) r.getInfo();
      
        if (r != null) {
           
            
          postOrderNodo(r.getHijoIzq());
          auxiliar= postOrderNodo(r.getHijoDer());
           votAux=(Votante) auxiliar.getInfo();
           
           if(votAux.getCedula().compareTo(vot.getCedula()  )<0  ){
               
               
               return auxiliar;       
           }
           
          
        }
        return r;
    }
     
     
    
    
    
}
