/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author David
 */
public class Votante {
    private String cedula;
    private String nombre;
    private int codProvincia;
    private int codParroquia;
    private int codCanton;
    private String recinto;
    private int numMesa;

    public Votante(String cedula, String nombre, int codProvincia, int codParroquia, int codCanton, String recinto, int numMesa) {
        this.cedula = cedula;
        this.nombre = nombre;
        this.codProvincia = codProvincia;
        this.codParroquia = codParroquia;
        this.codCanton = codCanton;
        this.recinto = recinto;
        this.numMesa = numMesa;
    }

    public String getCedula() {
        return cedula;
    }

    public void setCedula(String cedula) {
        this.cedula = cedula;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCodProvincia() {
        return codProvincia;
    }

    public void setCodProvincia(int codProvincia) {
        this.codProvincia = codProvincia;
    }

    public int getCodParroquia() {
        return codParroquia;
    }

    public void setCodParroquia(int codParroquia) {
        this.codParroquia = codParroquia;
    }

    public int getCodCanton() {
        return codCanton;
    }

    public void setCodCanton(int codCanton) {
        this.codCanton = codCanton;
    }

    public String getRecinto() {
        return recinto;
    }

    public void setRecinto(String recinto) {
        this.recinto = recinto;
    }

    public int getNumMesa() {
        return numMesa;
    }

    public void setNumMesa(int numMesa) {
        this.numMesa = numMesa;
    }



    
}
