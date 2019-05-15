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
    
    int UserID, RSA_ID, Rating;
    String Message, Location;
    
    public Reviews(int pUserID, int pRSA_ID, int pRating, String pMessage, String pLocation)
    {
        this.UserID = pUserID;
        this.RSA_ID = pRSA_ID;
        this.Rating = pRating;
        this.Message = pMessage;
        this.Location = pLocation;
    }
    
    public String getReview()
    {
        return ("User#: " + UserID + " was serviced by RSA#: " + RSA_ID + " User Rating: " + Rating + ". Message: " + Message + " @ " + Location);
    }
}
