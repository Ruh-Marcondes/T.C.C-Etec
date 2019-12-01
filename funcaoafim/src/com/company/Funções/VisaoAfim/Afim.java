package com.company.Funções.VisaoAfim;

import javax.swing.*;
import java.awt.event.*;

// Falta mostrar
public class Afim {
    public static double x, a, b, y;
    private JPanel Fafim;
    private JTextField textField_fx;
    private JTextField textField_a;
    private JTextField textField_x;
    private JTextField textField_b;
    private JButton definiçãoButton;
    private JLabel funçãolabel;
    private JButton calcularButton;
    private JButton limparButton;
    private JLabel labeldefinicao;
    private JLabel LabelResposta;
    private JLabel labelraiz;
    private JLabel Labeldefinicao2;

    // Objetos do JFrame
    public Afim() {
        definiçãoButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
             labeldefinicao.setText("A função afim, também chamada de função do 1º grau,  é uma função ");
             Labeldefinicao2.setText("f : ℝ→ℝ, definida como f(x) = ax + b, sendo a e b números reais.");
            }
        });
        calcularButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                LabelResposta.setText(" ");
                receber();
                raiz();
            }
        });
        labeldefinicao.addMouseWheelListener(new MouseWheelListener() {
            @Override
            public void mouseWheelMoved(MouseWheelEvent e) {
                labeldefinicao.setText(" ");
            }
        });
        definiçãoButton.addComponentListener(new ComponentAdapter() {
        });
        limparButton.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                textField_a.setText(" ");
                textField_b.setText(" ");
                textField_x.setText(" ");
                textField_fx.setText(" ");
                LabelResposta.setText(" ");
                labelraiz.setText(" ");
            }
        });
    }

    public JPanel getFafim() {
        return Fafim;
    }

    // Metódos dos calculos
    // receber
    public void receber(){
        verificaa();
        verificab();
        verificax();
        verificay();
        // Ñ sei pq mas prescisa disso
        verificaa();
        verificab();
        verificax();
        verificay();

    }


        // Metodos para verificar onde está o null
    public void verificaa() {
        String t = textField_a.getText();
        if (t.isEmpty()){
            a = 0;
            calca(y,b,x);
            LabelResposta.setText("a = "+ a);
            System.out.println(a);
        }else {
            a =  Double.parseDouble(textField_a.getText());
        }
    }
    public void verificab(){
        String t = textField_b.getText();
        if (t.isEmpty()){
            b = 0;
            calb(a,x,y);
            LabelResposta.setText("b = "+ b);
        }else {
            b =  Double.parseDouble(textField_b.getText());
        }
    }
        public void verificax(){
            String t = textField_x.getText();
            if (t.isEmpty()){
                x = 0;
                calcx(a,b,y);
                LabelResposta.setText("x = "+ x);
            }else {
                x =  Double.parseDouble(textField_x.getText());
            }
        }
        public void verificay(){
            String t = textField_fx.getText();
            if (t.isEmpty()){
                y = 0;
                calcy(a,b,x);
                LabelResposta.setText("f(x) = "+ y);
            }else {
                y =  Double.parseDouble(textField_fx.getText());
            }
        }
    // Metodos dos calculos '-'
    public static double calcy(double a, double b, double x){
        y = (a*x) + b;
        return  y;
    }
    public static double calca(double y, double b, double x){
        a = (y-b)/x;
        return  a;
    }
    public static double calb(double a,double x,double y){
        b = (a*x) - y;
        return b;
    }
    public static double calcx(double a, double b, double y){
        x = ((y-b)/a);
        return x;
    }

    public void raiz(){
        double r;
        r = (b*-1)/a;
        labelraiz.setText("A raiz da função é: "+ r);

    }
}

