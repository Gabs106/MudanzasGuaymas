package mx.itson.floreriafletes;

import android.content.Context;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Build;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONObject;
import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;

import mx.itson.floreriafletes.entidades.Usuario;
import mx.itson.floreriafletes.negocio.HttpClientHelper;
import mx.itson.floreriafletes.negocio.Parametro;


public class Clientes extends Fragment {

    List<Usuario> listaUsuarios = new ArrayList<>();
    View view;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        // Inflate the layout for this fragment
        view = inflater.inflate(R.layout.fragment_clientes, container, false);

        //ConsultarClientes();

        CargarClientesDePrueba();

        return view;
    }

    private void CargarClientesDePrueba(){
        Usuario cliente1 = new Usuario("Kevin", "Ruiz", "6222284088", "kevin_nax@hotmail.com");
        Usuario cliente2 = new Usuario("Gabriel", "Partida", "6221234512", "gabs@gmail.com");
        Usuario cliente3 = new Usuario("Luis", "Carrillo", "6221314533", "luisp@gmail.com");
        listaUsuarios.add(cliente1);
        listaUsuarios.add(cliente2);
        listaUsuarios.add(cliente3);
        CargarClientes();
    }

    private void ConsultarClientes(){
        //Sin parametros
        Parametro[] datos = new Parametro[0];

        TareaAsync tarea = new TareaAsync();
        tarea.setDatos(datos);
        tarea.setMetodo(getResources().getString(R.string.metodo_obtener_usuarios));

        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.HONEYCOMB){
            tarea.executeOnExecutor(AsyncTask.SERIAL_EXECUTOR);
        }else{
            tarea.execute();
        }
    }

    private void CargarClientes(){
        AdaptadorClientes adaptadorClientes = new AdaptadorClientes(getActivity(), listaUsuarios);
        ListView listaClientes = (ListView) view.findViewById(R.id.listUsuarios);
        listaClientes.setAdapter(adaptadorClientes);
    }

    //Esta clase realiza la operación asincrona en un hilo diferente al principal
    public class TareaAsync extends AsyncTask<Object, Object, Object>{

        //Variable que almacena los parametros WCF
        public Parametro[] datos;

        //Variable que contiene el nombre del metodo a llamar
        public String metodo;

        public Parametro[] getDatos(){
            return datos;
        }

        public void setDatos(Parametro[] datos){
            this.datos = datos;
        }

        public String getMetodo(){
            return metodo;
        }

        public void setMetodo(String metodo){
            this.metodo = metodo;
        }

        protected Object doInBackground(Object... params) {
            List<Object> lista = new ArrayList<>();

            try{
                JSONArray listaResultado = HttpClientHelper.GET(getMetodo(), getDatos(), getActivity());

                for(int i = 0; i < listaResultado.length(); i++){
                    JSONObject item = listaResultado.getJSONObject(i);
                    if(!item.getString("Tipo").equals("admin")) {
                        Usuario registro = new Usuario(item.getString("Nombre"), item.getString("Apellido"), item.getString("Telefono"), item.getString("Email"));
                        registro.setId(item.getInt("Id"));
                        lista.add(registro);
                    }
                }
            }catch(Exception ex){
                Log.e("Consulta de Clientes", ex.getMessage());
            }finally{
                return lista;
            }
        }

        public void onPreExecute(){

        }

        //Cuando finaliza la consulta, se ejecuta lo siguiente
        public void onPostExecute(Object result){
            processFinish(result);
            super.onPostExecute(result);
        }

        public void processFinish(Object result){
            listaUsuarios = (List<Usuario>) result;
            CargarClientes();
        }

    }

    //Adaptador que obtiene los resultados del servicio y los convierte para ser mostrados en la lista
    class AdaptadorClientes extends ArrayAdapter<Usuario>{

        AdaptadorClientes(Context context, List<Usuario> datos){
            super(context, R.layout.item_usuarios, datos);
        }

        public View getView(int position, View convertView, ViewGroup parent){
            View item = convertView;
            ClientesHolder holder;

            if(item == null){
                LayoutInflater inflater = LayoutInflater.from(getContext());
                item = inflater.inflate(R.layout.item_usuarios, null);

                //Mapeo de items de la lista con los controles del layout
                holder = new ClientesHolder();
                holder.nombre = (TextView) item.findViewById(R.id.txtNombre);
                holder.telefono = (TextView) item.findViewById(R.id.txtTelefono);
                holder.correo = (TextView) item.findViewById(R.id.txtCorreo);
                item.setTag(holder);
            }else{
                holder = (ClientesHolder)item.getTag();
            }

            final Usuario registro = listaUsuarios.get(position);
            holder.nombre.setText(registro.getNombre() + " " + registro.getApellido());
            holder.telefono.setText(registro.getTelefono());
            holder.correo.setText(registro.getEmail());

            return(item);
        }

    }

    //Sirve para crear los controles de cada item
    static class ClientesHolder{
        TextView nombre;
        TextView telefono;
        TextView correo;
    }

}
