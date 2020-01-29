package br.com.pfalves.myapplication;

public class Afim {
    public static double a, b, x, y;

    // Metodos dos calculos '-'
    public static double calcy(double a, double b, double x) {
        y = (a * x) + b;
        return y;
    }

    public static double calca(double y, double b, double x) {
        a = (y - b) / x;
        return a;
    }

    public static double calb(double a, double x, double y) {
        b = (a * x) - y;
        return b;
    }

    public static double calcx(double a, double b, double y) {
        x = ((y - b) / a);
        return x;
    }

    public void raiz() {
        double r;
        r = (b * -1) / a;
    }
}