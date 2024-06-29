/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.nghiant.deadracer;

import java.util.Random;

/**
 *
 * @author nghia
 */
public class ExciterRacer implements DeadRacer{

    @Override
    public long runToDeath() {
        return new Random().nextInt(320);
        //con số ngẫu nhiên từ 0-->320
    }
    
}
