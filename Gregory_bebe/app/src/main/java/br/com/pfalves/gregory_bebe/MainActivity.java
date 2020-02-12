package br.com.pfalves.gregory_bebe;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;

// A classe extende da AppCompactActivity
public class MainActivity extends AppCompatActivity {

    @Override
    // Ele executa o 'onCreate' da classe "Paid"
    // Depois executa o setContenteView
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
}
