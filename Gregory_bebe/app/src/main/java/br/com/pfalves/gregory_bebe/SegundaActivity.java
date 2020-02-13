package br.com.pfalves.gregory_bebe;
import android.os.Bundle;
import android.os.PersistableBundle;
import androidx.appcompat.app.AppCompatActivity;

// Primerira Classe Criada
public class SegundaActivity extends AppCompatActivity {

    //Pegou o metodo da classe principal e sobrescreveu para as alteracoes serem feitas

    @Override
    public void onCreate(Bundle savedInstanceState, PersistableBundle persistentState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_segunda);
    }
}
