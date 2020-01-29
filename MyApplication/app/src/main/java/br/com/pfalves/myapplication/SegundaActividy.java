package br.com.pfalves.myapplication;

import android.os.Bundle;
import android.util.Log;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class SegundaActividy extends AppCompatActivity {

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.acitivity_segunda);
    }

    @Override
    protected void onResume() {
        super.onResume();

        Log.d("Segunda Acitividy","OnResume");
    }

    @Override
    protected void onPause() {
        super.onPause();
        Log.d("Tela 2 Greg ","OnPause");
    }
}
