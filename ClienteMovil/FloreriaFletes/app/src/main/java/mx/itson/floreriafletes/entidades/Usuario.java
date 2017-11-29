package mx.itson.floreriafletes.entidades;

/**
 * Created by kevin on 21/nov/2017.
 */

public class Usuario {
    private int Id;
    private String Nombre;
    private String Apellido;
    private String Telefono;
    private String Email;

    public Usuario(String nombre, String apellido, String telefono, String email){
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Telefono = telefono;
        this.Email = email;
    }

    public int getId() {return Id;}

    public void setId(int id) {this.Id = id;}

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        this.Nombre = nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void setApellido(String apellido) {
        this.Apellido = apellido;
    }

    public String getTelefono() {
        return Telefono;
    }

    public void setTelefono(String telefono) {
        this.Telefono = telefono;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        this.Email = email;
    }
}
