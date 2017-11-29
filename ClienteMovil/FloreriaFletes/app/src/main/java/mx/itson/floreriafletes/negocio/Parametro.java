package mx.itson.floreriafletes.negocio;

/**
 * Created by kevin on 22/nov/2017.
 */

//Sirve para gestionar los parámetros que se enviarán a las llamadas Json
public class Parametro {

    private String key;
    private String value;

    //Constructor
    public Parametro(String llave, String valor){
        this.setKey(llave);
        this.setValue(valor);
    }


    public String getKey() {
        return key;
    }

    public void setKey(String key) {
        this.key = key;
    }

    public String getValue() {
        return value;
    }

    public void setValue(String value) {
        this.value = value;
    }
}
