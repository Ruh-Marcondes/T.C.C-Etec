package br.com.pfalves.myapplication;

import android.content.Intent;
import android.view.View;
import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    // Acitividy são as telas que estão aparecendo
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    public void abrirSegundaAcitivity(View view){
        startActivity(new Intent(getBaseContext(),SegundaActividy.class));
    }
}
