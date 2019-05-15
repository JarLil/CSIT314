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
public class RoadSide_Assistant
{
    protected String fName, lName, email, password;
    protected int rID=0;
    
    public RoadSide_Assistant(int rID, String fName, String lname, String pEmail, String pPassword)
    {
        this.rID = rID;
        this.fName = fName;
        this.lName = lname;
        this.email = pEmail;
        this.password = pPassword;
    }
    
    public String getFullName()
    {
        return (fName + " " + lName);
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
        return (rID + ", " + fName + " " + lName + ", " + email);
    }
}

