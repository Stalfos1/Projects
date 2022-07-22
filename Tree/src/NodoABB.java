/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author David
 */
public class NodoABB {
    private Object info;
    private NodoABB HijoIzq;
    private NodoABB HijoDer;

    public NodoABB(Object info) {
        this.info = info;
        this.HijoDer=null;
        this.HijoIzq=null;
    }

    public Object getInfo() {
        return info;
    }

    public void setInfo(Object info) {
        this.info = info;
    }

    public NodoABB getHijoIzq() {
        return HijoIzq;
    }

    public void setHijoIzq(NodoABB HijoIzq) {
        this.HijoIzq = HijoIzq;
    }

    public NodoABB getHijoDer() {
        return HijoDer;
    }

    public void setHijoDer(NodoABB HijoDer) {
        this.HijoDer = HijoDer;
    }
    
    
    
}