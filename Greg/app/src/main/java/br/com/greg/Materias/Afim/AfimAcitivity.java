package br.com.greg.Materias.Afim;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import br.com.greg.R;

public class AfimAcitivity  extends AppCompatActivity {
    int click = 0;

    @Override
    protected void onCreate(final Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_afim);

        Button btn = (Button) findViewById(R.id.btn6);
        final TextView txt = (TextView) findViewById(R.id.definicao);
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (click == 0) {
                    txt.setText("A função afim, também chamada de função polinomial do 1º grau,  é uma função f : ℝ→ℝ, definida como f(x) = ax + b, sendo a e b números reais. ");
                    click = 1;
                } else {
                    click = 0;
                    txt.setText(" ");
                }
            }
        });

    }
}
