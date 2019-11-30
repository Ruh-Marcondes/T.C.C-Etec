package com.company;

import com.company.Funções.VisaoAfim.Afim;

import javax.swing.*;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner alan = new Scanner(System.in);
        int opc = 0;
        opc = Integer.parseInt(alan.nextLine());
        switch (opc) {
            case 1:
                JFrame tela = new JFrame();
                tela.setContentPane(new Afim().getFafim());
                tela.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
                tela.setTitle("Gregory");
                tela.setVisible(true);
                tela.pack();
        }
                System.out.println(" '-' x_ -_- ");
        }
    }

