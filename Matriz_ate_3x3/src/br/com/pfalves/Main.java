package br.com.pfalves;

import java.util.Scanner;

public class Main {
/*Everybody in the word knows
* I'm a little twisted, TWISTED - '-' */

    //matriz intermediiaria
    public static int l[] = new int[2];
    // criando a matriz

    public static Scanner sc = new Scanner(System.in);
    //Variaveis globais
    public static  double secundaria,principal,somaR,somaL,determinante;

    // Função principal
    public static void main(String[] args) {
        //variaveis
        String m;
        String n[] = new String[2];
        int a;
        // pedindo a ordem

        do{
        System.out.print("\t\t'-' x_  -_- \nDefina a ordem da matriz - exemplo 2x2: " );
        m = sc.nextLine();
        m = m.replace(" ","");

        // separando a ordem da matriz
        n = m.split("x");

        // convertendo valor string para int;
        l[0] = Integer.parseInt(n[0]);
        l[1] = Integer.parseInt(n[1]);

        M= new int [l[0]][l[1]]; // altera o valor da ordem da matriz
        // verificando se as matrizes tem a mesma ordem

        if(l[0] != l[1] || l[0] > 4){
            System.out.println("\t A matriz  Invalida   ");
        }else{
            if(l[0]==1){
                entratadados();
                System.out.println("A determinante é : "+M[0][0]);
            }else {
                if (l[0] == 2) {
                    entratadados();
                    imprimirM();
                    M2();
                } else {

                    if (l[0] == 3) {
                        entratadados();
                        imprimirM();
                        M3();
                        imprimedet();
                    } else {
                        entratadados();
                        imprimirM();
                        Mn();
                        imprimedet();
                    }
                }
            }

        }
            System.out.println();
            System.out.println("Nova matriz? ");
            System.out.println("0 .... não");
            System.out.println("1 .... sim");
            a = Integer.parseInt(sc.nextLine());
        }while(a == 1);
        System.out.println("\t>>>>>>>>>>> Fim <<<<<<<<<<<<  \n\t\t -_-  x_ '-' ");
    }

    // Metódos
    public static int M[][] = new int[l[0]][l[1]];

    public static void imprimirM(){
        System.out.println();
        System.out.println("M=");
        for (int i = 0; i < l[0]; i++) {
            System.out.print("\t\t|");
            for (int j = 0; j < l[1]; j++) {
                System.out.printf("%3d", M[i][j]);
            }
            System.out.println("|");
        }
    }  // ok
    public static void entratadados() {
        // incerindo dados na matriz M

        for (int i = 0; i < l[0]; i++) {
            for (int j = 0; j < l[1] ; j++) {
                System.out.println("Insira o elemento m[ " + (i + 1) + " ] [ " + (j + 1) + " ]");
                M[i][j] = Integer.parseInt(sc.nextLine());
            }
        }
    } // ok

    public static void M2(){

        // diagonal principal
        secundaria = M[0][0]; //m11
        principal = M[1][1]; // m22
        somaL = secundaria*principal;
        //diagonal secundaria
        secundaria = M[0][1]; // m12
        principal = M[1][0]; // m21
        //
        somaR= principal*secundaria*-1;
        determinante= somaR + somaL;
        // resultado print
        System.out.println();
        System.out.println("Det M = "+determinante);
    } // ok
    public static double M3(){
        // Diagonal principal
        principal = M[0][0] * M[1][1] * M[2][2];    //  1° m11 m22 M33
        secundaria = M[0][1] * M[1][2] * M[2][0];  // 2°  m12 m23 M1
        somaL = M[0][2] * M[1][0] * M[2][1];      // 3° m13 m21 M2
        somaL += secundaria + principal ;
        somaR = somaL;

        //Diagonal secunaria
        principal = M[0][2] * M[1][1] * M[2][0]* -1; // 1° secundaria  m11 m22 M33
        secundaria = M[0][0] * M[1][2] * M[2][1]* -1; //  2°  m12 m23 M1
        somaR = M[0][1] * M[1][0] * M[2][2]* -1; //  3° m13 m21 M2
        somaR += secundaria + principal ;
      //  System.out.println(principal+" "+secundaria+" "+somaR);
        determinante = somaR+somaL;
        return determinante;
    } // ok

    public static double Mn(){
        int vet[]= new int [l[0]];
        for (int i = 1; i <l[0] ; i++) {
            vet[i-1] =  M[i][0] * cofator(i);
        }
        somaL  = 0;
        for (int i = 0; i <l[0] ; i++) {
            somaL += vet[i];
        }
        determinante = somaL;
        return determinante;
    }
    public static int cofator(int i){
        int det = 0;
        for (int j = 0; j < l[0] ; j++) {
            det += (-1)^(i+1) * det_resto();// determinante do que restas
        }
        return det;
    }

    public static int resto = 0;
    private static int det_resto(){
        int D[][] = new int[l[0]-1][l[1]-1];
        // só ta calculando o cofator do 1 elemento
        for (int i = 0; i < l[0] -1 ; i++) {
            for (int j = 0; j < l[1] -1; j++) {
                D[i][j] = M[i][j];
                System.out.print(M[i+1][j+1]+"\t");
                M3();
            }
            System.out.println("\n ");
        }
        System.out.println(">>>>>>>>>>>>>>> \n");
        return resto;
    }

    public static void imprimedet(){
        System.out.println("\t A determinante da matriz ["+ l[0] + " x " + l[1] + "] é: "+ determinante);
    }
}


