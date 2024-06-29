/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */
package org.nghiant.deadracer;

import java.util.Random;

/**
 *
 * @author nghia
 */
public class Main {

    public static void main(String[] args) {
        raceWithExciter();
        raceWithExciterAno();
        raceWithExciterLambda();
    }
    
    //cách 3 với LAMBDA EXPRESSION
    public static void raceWithExciterLambda(){
        
        DeadRacer kwa = () -> new Random().nextInt(320);//VIP
        
        System.out.println("Race 4 (Kawasaki): " + kwa.runToDeath());
    }
    
    //cách 2 chơi với interface
    public static void raceWithExciterAno(){
        
        DeadRacer win = new DeadRacer() {
            @Override
            public long runToDeath() {
                return new Random().nextInt(320);
            }
        };//VIP
        
        System.out.println("Race 3 (Winner): " + win.runToDeath());
    }

    //cách 1 với interface
    public static void raceWithExciter() {
        ExciterRacer ex1 = new ExciterRacer();
        //em là exciter cũng là đua thủ
        //Khai Con new Con

        DeadRacer ex2 = new ExciterRacer();
        //em là exciter và  còn là đua thủ
        //Khai Cha new Con

        System.out.println("Race 1: " + ex1.runToDeath());
        System.out.println("Race 2: " + ex2.runToDeath());

    }
}
