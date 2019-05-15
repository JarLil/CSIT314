/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package group13;

import java.util.Date;

/**
 *
 * @author Jarrod
 */
public class Requests
{
    private Date requestDate;
    private String cfName, clName, cCarMake, cCarModel, cRegistration, Message, Location, Status;
    private int cID, rID;
    
    public Requests(int cID, Date requestDate, String fName, String lName, String carMake, String carModel, String registration, String message, String location, String status, int rID)
    {
        this.cID = cID;
        this.requestDate = requestDate;
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
        return (cID + ", " + requestDate + ", " + cfName + ", " + clName + ", " + cCarMake + ", " + cCarModel + ", " + cRegistration + ", " + Location + ", " + Message + ", " + Status);
    }
}

class CompletedRequests extends Requests
{
    protected Date requestDate, CompleteDate;
    protected String cfName, clName, cCarMake, cCarModel, cRegistration, Message, Location, Status;
    protected int cID, rID; 
    
    
    public CompletedRequests(int cID, Date requestDate, String fName, String lName, String carMake, String carModel, String registration, String message, String location, String status, int rID, Date completeDate)
    {
        super (cID, requestDate, fName, lName, carMake, carModel, registration, message, location, status, rID);
        this.CompleteDate = completeDate;
    }
    
    public String getRequestInfo()
    {
        return (cID + ", " + requestDate + ", " + cfName + ", " + clName + ", " + cCarMake + ", " + cCarModel + ", " + cRegistration + ", " + Location + ", " + Message + ", " + Status + ". " + CompleteDate);
    }
}
