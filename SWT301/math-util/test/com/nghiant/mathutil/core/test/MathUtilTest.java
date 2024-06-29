/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nghiant.mathutil.core.test;

import com.nghiant.mathutil.core.MathUtility;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author nghia
 */
public class MathUtilTest {
 
    @Test
    public void testFactorialGivenRightAgrument0ReturnsWell(){
        long expected = 1;//hy vọng 0! trả về 1
        long actual;     //actual = mấy, chờ hàm chạy mới biết
        actual = MathUtility.getFactorial(0);
        assertEquals(expected, actual);
    }
    
    @Test
    public void testFactorialGivenRightAgrumentReturnsWell(){
        assertEquals(1, MathUtility.getFactorial(1));// hy vọng trả về 1
        assertEquals(2, MathUtility.getFactorial(2));// hy vọng trả về 2
        assertEquals(6, MathUtility.getFactorial(3));// hy vọng trả về 6
        assertEquals(24, MathUtility.getFactorial(4));// hy vọng trả về 24
        assertEquals(120, MathUtility.getFactorial(5));// hy vọng trả về 120

    }
    //ta còn cần test exception nữa, đưa data cả chờn, bị vả mặt Exception 
    
    @Test(expected = IllegalArgumentException.class)
    public void testFactorialGivenWrongArgumetThrowException(){
        MathUtility.getFactorial(-5);
        
        //ta cần 1 lệnh asert() có ngoại lệ như kì vọng hay ko
        //hiện nay mới gọi lệnh chứ chưa so sánh, chưa assert()
        
        //JUnit 4: ko có hàm so sánh ngoại lệ, mà phải dùng kĩ thuật
        //Annotation
        //JUnit 5: có hàm so sánh ngoại lệ, nhưng dùng lệnh Lambda Expression
        
        //TA CAP LẠI CÓ NGOẠI LỆ TRONG TÌNH HUỐNG NÀY
        //HY VỌNG THẤY NGOẠI LỆ
        //NẾU THỰC TẾ NHƯ KÌ VỌNG, TEST PASSED
        //                  MÀU XANH
        
    }
    // theo thiết kế, hàm getF(nhận vào n âm) thì ném ra ngoại lệ
    // trong tình huống ta đưa -5 cho hàm THÌ TA HY VỌNG
    // NHẬN VỀ NGOẠI LỆ
    //CÓ NGOẠI LỆ XẢY R VỚI -5, CHỨNG TỎ HÀM ĐÚNG VỚI ÂM 5
    //CÓ NGOẠI LỆ VỚI -5, THỰC TẾ LÀ CÓ; THÌ PHẢI MÀU XANH

    //THẤY NGOẠI LỆ MỪNG RƠI NƯỚC MẮT
    
    
    //MÀU XANH: XANH KHI TẤT CẢ CÁC TEST CASE ĐỀU XANH
    //          TỨC LÀ MỌI BỘ/CẶP SO SÁNH EXPECTED PHẢI == ACTUAL
    
    //MÀU ĐỎ: CHỈ CẦN 1 CẶP EXPECTED != ACTUAL, HAY LÀ CHỈ CẦN 1 CASE
    //          SAI, TẤT CẢ COI NHƯ SAI
    
}
