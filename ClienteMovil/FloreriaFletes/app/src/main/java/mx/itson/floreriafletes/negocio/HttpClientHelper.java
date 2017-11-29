package mx.itson.floreriafletes.negocio;

import android.content.Context;
import android.util.Log;
import org.apache.http.client.ResponseHandler;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpUriRequest;
import org.apache.http.impl.client.BasicResponseHandler;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.params.BasicHttpParams;
import org.apache.http.params.HttpConnectionParams;
import org.apache.http.params.HttpParams;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import mx.itson.floreriafletes.R;

/**
 * Created by kevin on 22/nov/2017.
 */

public class HttpClientHelper {

    public static JSONArray GET(String OperationName, Parametro[] params, Context contexto) throws JSONException {
        String parametros = "?";
        JSONObject resultado = null;
        BasicHttpParams basicHttpParams = new BasicHttpParams();
        HttpConnectionParams.setConnectionTimeout((HttpParams) basicHttpParams, (int) 10000);
        HttpConnectionParams.setSoTimeout((HttpParams) basicHttpParams, (int) 10000);
        HttpConnectionParams.setTcpNoDelay((HttpParams) basicHttpParams, (boolean) true);

        DefaultHttpClient httpClient = new DefaultHttpClient((HttpParams)basicHttpParams);

        // Se concatenan los parámetros que irán por query string
        for(int i = 0; i < params.length; i++){
            Parametro item = params[i];
            parametros += item.getKey() + "=" + item.getValue();

            if(i < params.length - 1){
                parametros += "&";
            }
        }

        try{
            HttpGet request = new HttpGet(contexto.getResources().getString(R.string.url_wcf_usuario) + OperationName + parametros);
            BasicResponseHandler basicResponseHandler = new BasicResponseHandler();
            resultado = new JSONObject((String)httpClient.execute((HttpUriRequest)request, (ResponseHandler)basicResponseHandler));
        }
        catch(Exception ex){
            Log.e("ConsultaDB", "Error al acceder al servicio WCF. Error: " + ex.getMessage());
            throw ex;
        }
        finally {
            return resultado.getJSONArray(OperationName + "Result");
        }
    }


}
