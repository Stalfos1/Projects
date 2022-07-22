/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author David
 */
public class Producto {
    private String codigo;
    private String producto;
    private int cantidad;
    private double precio;
    private int minimo;

    public Producto(String codigo, String producto, int cantidad, double precio, int minimo) {
        this.codigo = codigo;
        this.producto = producto;
        this.cantidad = cantidad;
        this.precio = precio;
        this.minimo = minimo;
    }

    public int getMinimo() {
        return minimo;
    }

    public void setMinimo(int minimo) {
        this.minimo = minimo;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getProducto() {
        return producto;
    }

    public void setProducto(String producto) {
        this.producto = producto;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCanditdad(int canditdad) {
        this.cantidad = canditdad;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }
    
    
    
}
