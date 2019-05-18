/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package group13;

import java.text.*;
import java.util.*;

/**
 *
 * @author Jarrod
 */
public class Requests
{
    private final Date requestDate; //TODAYS DATE
    private final String cfName, clName, cCarMake, cCarModel, cRegistration, Message, Location;
    private final String Status; //PENDING / IN-PROGRESS / COMPLETED. if COMPLETED -> Move to CompletedRequests Array
    private final int cID, rID, reqID; //UserID, RSAID, reqID
    
    public Requests(int preqID, int cID, Date prequestDate, String fName, String lName, String carMake, String carModel, String registration, String message, String location, String status, int rID)
    {
        this.reqID = preqID;
        this.cID = cID;
        this.requestDate = prequestDate;
        this.cfName = fName;
        this.clName = lName;
        this.cCarMake = carMake;
        this.cCarModel = carModel;
        this.cRegistration = registration;
        this.Message = message;
        this.Location = location;
        this.Status = status;
        this.rID = rID;
    }
    
    public String getRequestInfo()
    {
        return (requestDate + ", " + cCarMake + ", " + cCarModel + ", " + cRegistration + ", " + Location + '\n' + Message);
    }
    
    public int getCustID()
    {
        return cID;
    }
}

class CompletedRequests extends Requests
{
    protected Date requestDate; //TODAYS DATE
    protected String cfName, clName, cCarMake, cCarModel, cRegistration, Message, Location;
    protected String Status; //PAID/PENDING
    protected int cID, rID, reqID; //CustomerID, RSAID
    
    
    public CompletedRequests(int preqID, int cID, Date requestDate, String fName, String lName, String carMake, String carModel, String registration, String message, String location, String status, int rID)
    {
        super (preqID, cID, requestDate, fName, lName, carMake, carModel, registration, message, location, status, rID);
    }
    
    @Override
    public String getRequestInfo()
    {
        return (cID + ", " + requestDate + ", " + cfName + ", " + clName + ", " + cCarMake + ", " + cCarModel + ", " + cRegistration + ", " + Location + ", " + Message + ", " + Status);
    }
    public int getCustID()
    {
        return cID;
    }
    
}
