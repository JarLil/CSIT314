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
public class Car
{
   protected String carModel, carMake, carColour, carTransmission, subscription, registration;
   protected int carID = 0, carCylinder, OwnerID;
   
   public Car(int carID, String carMake, String carModel, String carColour, String carTransmission, int carCylinder, String subscription, String registration, int ownerID)
   {
       this.carID = carID;
       this.carModel = carModel;
       this.carMake = carMake;
       this.carColour = carColour;
       this.carTransmission = carTransmission;
       this.carCylinder = carCylinder;
       this.subscription = subscription;
       this.registration = registration;
       this.OwnerID = ownerID;
   }
   
   public String getCarModelMake()
    {
        return (carMake + " " + carModel);
    }
    
    public String getMake()
    {
        return carMake;
    }
    
    public String getModel()
    {
        return carModel;
    }
    
    public String printCarRecord()
    {
        return (carID + ", " + carMake + " " + carModel + ", " + carTransmission + ", " + subscription + ", " + registration);
    }
}
