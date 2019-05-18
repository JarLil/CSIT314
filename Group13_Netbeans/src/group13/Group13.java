/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package group13;

import java.util.ArrayList;

/**
 *
 * @author Jarrod
 */
public class Group13 {    
    /**
     * @param args the command line arguments
     */
    
    public static int UserIndex = 0; //Tracks userID
    public static int CarIndex = 0; //Tracks CarID
    public static int RequestIndex = 0; //Tracks requestID
    public static int RSAIndex = 0; //Tracks rsaID
    public static int ReviewIndex = 0;
    
    public static void main(String[] args) {
        // TODO code application logic here
        new LoginPage().setVisible(true);
    }
    
}
