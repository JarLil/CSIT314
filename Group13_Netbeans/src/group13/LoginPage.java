/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package group13;

import java.io.*;
import java.text.*;
import java.util.*;

/**
 *
 * @author Jarrod
 */
public class LoginPage extends javax.swing.JFrame
{
    public static ArrayList<User> UserArray = new ArrayList<>();
    public static ArrayList<RoadSide_Assistant> AssistantArray = new ArrayList<>();
    public static ArrayList<Car> CarArray = new ArrayList<>();
    public static ArrayList<Requests> CurrentRequests = new ArrayList<>();
    public static ArrayList<CompletedRequests> CompletedRequests = new ArrayList<>();
    public static ArrayList<Reviews> ReviewArray = new ArrayList<>();
    
    public static int LoginID = -1;
    
    /**
     * Creates new form MainPage
     */
    public LoginPage() {
        initComponents();
        LoadData();
        IncorrectLabel.setVisible(false);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        UserEmail = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        UserPassword = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        IncorrectLabel = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        UserEmail.setName("UserEmail"); // NOI18N

        jLabel1.setText("Username:");

        jLabel2.setText("Log In");

        jLabel3.setText("Password :");

        UserPassword.setName("UserPassword"); // NOI18N

        jLabel4.setText("Havent got an account yet? Sign up Here");

        jButton1.setText("Log In");
        jButton1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton1MouseClicked(evt);
            }
        });

        IncorrectLabel.setText("Incorrect username or password");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(32, 32, 32)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addComponent(jLabel3))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(UserEmail, javax.swing.GroupLayout.PREFERRED_SIZE, 122, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(UserPassword, javax.swing.GroupLayout.PREFERRED_SIZE, 122, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(47, 47, 47))
            .addGroup(layout.createSequentialGroup()
                .addGap(120, 120, 120)
                .addComponent(jLabel2)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(21, 21, 21)
                        .addComponent(jLabel4))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(87, 87, 87)
                        .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 132, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(54, 54, 54)
                        .addComponent(IncorrectLabel)))
                .addContainerGap(47, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel2)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(UserEmail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(UserPassword, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 12, Short.MAX_VALUE)
                .addComponent(IncorrectLabel)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel4)
                .addGap(18, 18, 18)
                .addComponent(jButton1)
                .addContainerGap())
        );

        UserEmail.getAccessibleContext().setAccessibleName("UserEmail");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton1MouseClicked
        // TODO add your handling code here:
        
        //USERTYPE: 1 = USER, 2 = RSA
        int userType = 0;
        
        
        //Login
        for (User u : UserArray)
        {
            String usersEmail = UserEmail.getText();
            String usersPassword = UserPassword.getText();

            if ((u.getEmail().equals(usersEmail)) && u.getPassword().equals(usersPassword))
            {
                userType = 1; //USER
                LoginID = u.getID();
            }
        }
        for (RoadSide_Assistant RSA : AssistantArray)
        {
            String usersEmail = UserEmail.getText();
            String usersPassword = UserPassword.getText();
            
            if ((RSA.getEmail().equals(usersEmail)) && (RSA.getPassword().equals(usersPassword)))
            {
                userType = 2; //RSA
            }
        }
        
        if (userType != 0)
        {
           Login(userType); 
        }
        else
        {
            IncorrectLabel.setVisible(true);
        }
        
    }//GEN-LAST:event_jButton1MouseClicked

    public void LoadData()
    {
        String fileNameU = "Users.txt";
        
        try
        {
           BufferedReader fin = new BufferedReader(new FileReader(fileNameU));
           
           String st;
           while ((st = fin.readLine()) != null)
           {
               if (st.isEmpty())
                {
                    break;
                }
               String[] line = st.split(",");
               // int cID, String pfName, String plName, String pEmail, String pPassword
               UserArray.add(new User(Integer.parseInt(line[0]), line[1], line[2], line[3], line[4], Integer.parseInt(line[5])));
               Group13.UserIndex++;
            }
        }
        catch (IOException e)
        {
            System.out.println("Error reading Users.txt: " + e);
        }
        
        System.out.println(UserArray.size());
        
        String fileNameR = "RSA.txt";
        
        try
        {
            BufferedReader fin = new BufferedReader(new FileReader(fileNameR));
            String st;
            
            while ((st = fin.readLine()) != null)
            {
                if (st.isEmpty())
                {
                    break;
                }
                String[] line = st.split(",");
                
                // int rID, String fName, String lname, String emil, String password
                AssistantArray.add(new RoadSide_Assistant(Integer.parseInt(line[0]), line[1], line[2], line[3], line[4], Integer.parseInt(line[5]), Boolean.parseBoolean(line[6])));
                Group13.RSAIndex++;
            }
            
        }
        catch (IOException e)
        {
            System.out.println("Error reading RSA.txt: " + e);
        }
        
        //Requests (Current)
        
        String fileNameReq = "Requests.txt";
        
        try
        {
            BufferedReader fin = new BufferedReader(new FileReader(fileNameReq));
            String st;
            
            while ((st = fin.readLine()) != null)
            {
                if (st.isEmpty())
                {
                    break;
                }
                String[] line = st.split(",");
                
                Date date1;
                
                String string1 = line[2];
                DateFormat format = new SimpleDateFormat("dd/MM/yyyy", Locale.ENGLISH);
                try
                {
                    date1 = format.parse(string1);
                }
                catch (ParseException e)
                {
                    System.out.println("Error: " + e);
                    date1 = new Date("01/01/1900");
                }
                
                //ReqID, userID, requestDate, userfName, userlName, carMake, carModel, registration, message, location, status, rID
                CurrentRequests.add(new Requests(Integer.parseInt(line[0]), Integer.parseInt(line[1]), date1, line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10], Integer.parseInt(line[11])));
                Group13.RequestIndex++;
            }
            
        }
        catch (IOException e)
        {
            System.out.println("Error reading Requests.txt: " + e);
        }
        
        //Requests (Completed)
        
        String fileNameCompReq = "CompletedRequests.txt";
        
        try
        {
            BufferedReader fin = new BufferedReader(new FileReader(fileNameCompReq));
            String st;
            
            while ((st = fin.readLine()) != null)
            {
                if (st.isEmpty())
                {
                    break;
                }
                String[] line = st.split(",");
                
                Date date1;
                
                String string1 = line[2];
                
                DateFormat format = new SimpleDateFormat("dd/MM/yyyy", Locale.ENGLISH);
                try
                {
                    date1 = format.parse(string1);
                }
                catch (ParseException e)
                {
                    System.out.println("Error: " + e);
                    date1 = new Date("01/01/1900");
                }
                
                // int cID, String requestDate, String fName, String lName, String carMake, String carModel, String registration, String message, String location, String status, int rID, String completeDate
                CompletedRequests.add(new CompletedRequests(Integer.parseInt(line[0]), Integer.parseInt(line[1]), date1, line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10], Integer.parseInt(line[11])));
                Group13.RequestIndex++;
            }
        }
        catch (IOException e)
        {
            System.out.println("Error reading CompletedRequests.txt: " + e);
        }
        
        //Cars
        
        String fileNameCar = "Car.txt";
        
        try
        {
            BufferedReader fin = new BufferedReader(new FileReader(fileNameCar));
            String st;
            
            while ((st = fin.readLine()) != null)
            {
                if (st.isEmpty())
                {
                    break;
                }
                String[] line = st.split(",");
                
                // int carID, String carMake, String carModel, String carColour, String carTransmission, int carCylinder, String subscription, String registration, int ownerID
                CarArray.add(new Car(Integer.parseInt(line[0]), line[1], line[2], line[3], line[4], Integer.parseInt(line[5]), line[6], line[7], Integer.parseInt(line[8])));
                Group13.CarIndex++;
            }
            
        }
        catch (IOException e)
        {
            System.out.println("Error reading Car.txt: " + e);
        }
        
        //Reviews
        
        String fileNameReview = "ReviewRating.txt";
        
        try
        {
            BufferedReader fin = new BufferedReader(new FileReader(fileNameReview));
            String st;
            
            while ((st = fin.readLine()) != null)
            {
                if (st.isEmpty())
                {
                    break;
                }
                String[] line = st.split(",");
                
                // int carID, String carMake, String carModel, String carColour, String carTransmission, int carCylinder, String subscription, String registration, int ownerID
                ReviewArray.add(new Reviews(Integer.parseInt(line[0]), Integer.parseInt(line[1]), Integer.parseInt(line[2]), Integer.parseInt(line[3]), line[4], line[5]));
                Group13.ReviewIndex++;
            }
        }
        catch (IOException e)
        {
            System.out.println("Error reading ReviewRating.txt: " + e);
        }  
    }
    
    public static void Login(int userType)
    {
        if (userType == 1)
        {
            new UserMainPage().setVisible(true);
        }
        else if (userType == 2)
        {
            new RSAMainPage().setVisible(true);
        }
    }
    
    public static void Register()
    {
        //Start register page
        new RegisterPage().setVisible(true);
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(LoginPage.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(LoginPage.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(LoginPage.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(LoginPage.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new LoginPage().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel IncorrectLabel;
    private javax.swing.JTextField UserEmail;
    private javax.swing.JTextField UserPassword;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    // End of variables declaration//GEN-END:variables
}