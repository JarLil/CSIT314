/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package group13;

/**
 *
 * @author Jarrod
 */
public class User
{
    protected String fName, lName, email, password;
    protected int cID = 0;
    protected int PhoneNum = 0;
    
    public User(int cID, String pfName, String plName, String pEmail, String pPassword, int pPhoneNum)
    {
       this.cID = cID;
       this.fName = pfName;
       this.lName = plName;
       this.email = pEmail;
       this.password = pPassword;
       this.PhoneNum = pPhoneNum;
    }
    
    public String getFullName()
    {
        return (fName + " " + lName);
    }
    
    public int getID()
    {
        return cID;
    }
            
    public String getEmail()
    {
        return email;
    }
    
    public String getPassword()
    {
        return password;
    }
    
    public String printCustRecord()
    {
        return (cID + ", " + fName + " " + lName + ", " + email + ", " + password);
    }
}
