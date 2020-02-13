package br.com.pfalves.gregory_bebe;

import android.content.Intent;
import android.view.View;
import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;

// A classe extende da AppCompactActivity
public class MainActivity extends AppCompatActivity {

    @Override
    // Ele executa o 'onCreate' da classe "Pai"
    // Depois executa o setContenteView
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    //Metodo para abrir segunda activity na tela
    public void abrirSegundaAcitivity(View view){
        startActivity(new Intent(getBaseContext(),SegundaActivity.class));
    }
}
