/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.nghiant.deadracer;

/**
 *
 * @author nghia
 */

//loại Interface mà chỉ có duy nhất 1 hàm abstract, hàm ko có code
// thì INTERFACE NÀY ĐC GỌI LÀ: FUNCTIONAL INTERFACE
// Và Interface này BÀ CON VỚI LAMBDA EXPRESSION

@FunctionalInterface
public interface DeadRacer {
    
    public long runToDeath();

   
}
//MUỐN CHƠI VS INTERFACE, CÓ NHỮNG CÁCH SAU:

//1. TẠO 1 CLASS RỜI/CONCREATE CLASS MÀ IMPLEMENT CÁI INTEREFACE
//      PHẢI VIẾT CODE CHO HÀM ABSTRACT

//  Vì interface ko chứa code (nếu chứa code thì đó phải là hàm static 
//  hoặc hàm non-static nhưng có thêm keyword default trước trên hàm

//2. DÙNG ANONYMOUS CLASS
//  làm biếng tạo 1 class rời
//  ta vẫn implement code nhưng ko thèm tạo class rời
//  TẠO CLASS KIỂU TAKE-AWAY, ON-THE-GO
// vừa tạo class vừa implement

//3. NẾU ĐC INTERFACE MÀ LẠI LÀ FUNCTIONAL, TỨC LÀ CHỈ CÓ 1 HÀM DUY NHẤT
//  TA ĐC ỦY QUYỀN DÙNG LAMBDA EXPRESSION

//  LAMBDA EXPRESSION LÀ: ANONYMOUS METHODE
//      HÀM MÀ KO THÈM ĐẶT TÊN

//LÀM BIẾNG ĐẶT TÊN CLASS --> ANONYMOUS CLASS