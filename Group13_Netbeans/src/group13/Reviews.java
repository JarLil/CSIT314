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
public class Reviews {
    
    int UserID, RSA_ID, Rating, reqID;
    String Message, Location;
    
    public Reviews(int reqID, int pUserID, int pRSA_ID, int pRating, String pMessage, String pLocation)
    {
        this.reqID = reqID;
        this.UserID = pUserID; //Users' ID
        this.RSA_ID = pRSA_ID; //RSA's ID
        this.Rating = pRating; //Rating out of 10
        this.Message = pMessage; //the review message the user provides about the RSA
        this.Location = pLocation; //Location of the request
    }
    
    public String getReview()
    {
        return ("User#: " + UserID + " was serviced by RSA#: " + RSA_ID + " User Rating: " + Rating + ". Message: " + Message + " @ " + Location);
    }
}
