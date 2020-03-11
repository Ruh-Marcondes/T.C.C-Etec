package br.com.greg.TelasIniciais;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import br.com.greg.Materias.Funções.AfimAcitivity;
import br.com.greg.Materias.ConjuntosAcityvity;
import br.com.greg.R;

public class MateriaMatematicaActivity extends AppCompatActivity {
    public  static  String m = "Ñ Terminado";
    @Override
    protected void onCreate(final Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_materias_math);

        Button btn = (Button) findViewById(R.id.btn1); // Função Afim
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(getBaseContext(),AfimAcitivity.class));
            }
        });

       btn = (Button) findViewById(R.id.btn2); // Função quadratico
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getApplicationContext(),m,Toast.LENGTH_SHORT).show();
            }
        });
        btn = (Button) findViewById(R.id.btn3); // Função exponencial
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getApplicationContext(),m,Toast.LENGTH_SHORT).show();
            }
        });
        btn = (Button) findViewById(R.id.btn4); // Conjuntos Numericos
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(getBaseContext(),ConjuntosAcityvity.class));
            }
        });
        btn = (Button) findViewById(R.id.btn5); // Ainda ñ sei
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getApplicationContext(),m,Toast.LENGTH_SHORT).show();
            }
        });

    }

}
