using UnityEngine;
using System.Collections;
using System.Timers;

public class PlayerChar : MonoBehaviour {

	public GUISkin s_MySkin;		//A skin to allow customnizable User interface
  //  Vector3 v_TargetPos;
    Transform g_Target;		//The transformation of the "seeker"- which is an invisible object that the player follows
    Vector3 v_CurrentPos;
   	public int i_Balance = 100;		//.The inital balance of the player. Making variables public allows the user to edit them within the unity editor
	public int  i_BalanceGain = 10;	//The balance the player will gain when they perform a specific action- again public to edit them within the unity editor
	//public int i_BalanceLost = 10;		//The amount of balance the player loses.
	public int f_playerSpeed = 2;		//The players Speed
	public int f_RotationSpeed = 2;	//The speed at which the player rotates
	Transform t_CurrentTrans;		//Retrieves the current Tranformation of the player object 

	void Start()
    {
        //playerRot = gameObject.transform.rotation.eulerAngles;
        g_Target = GameObject.FindGameObjectWithTag("Seeker").transform;   // Finding the target that the player object will walk towards- using tags should make it safer, incase the name of the object changes
       //	v_TargetPos = g_Target.transform.position; //Retrieving the position of the target that the player will move towards.
		t_CurrentTrans = transform;
    }

    void FixedUpdate()
    {
		
       // v_CurrentPos = transform.position;      //Retrieve the players current position- done every frame to track players position constantly
        //rerieving the position of the target
		i_Balance --;  //continually subtract from the players overall balance during the game
		
		//The Following Code is base on a Unity answer Found online, It makes the player follower a "Seeker object"
        t_CurrentTrans.rotation = Quaternion.Slerp(t_CurrentTrans.rotation,
    	Quaternion.LookRotation(g_Target.position - t_CurrentTrans.position), f_RotationSpeed*Time.deltaTime);
		t_CurrentTrans.position += t_CurrentTrans.forward * f_playerSpeed * Time.deltaTime;
		
		PlayerInput();	//Calls the player input funstion to handle key presses
		BalanceChecks();

    }
	

	void BalanceChecks()
	{
		//If the players balance falls below 0 they will lose the game 
//        if (i_Balance <= 0)
//        {
//            Application.LoadLevel("GameEnd");	//loads the end screen of the mini-game 
//        }
		if (i_Balance >=100)
		{
			i_Balance =100;
		}
		
		if (i_Balance <=0)
		{
			Application.LoadLevel(4);
		}
		
		//simple check of the players z Position, if it is greater than the assigned value they win.
		if(t_CurrentTrans.position.z >=9.013675)
		{
			Application.LoadLevel(3);
		}
	
	
	}
	
	
	
	//Used to detect player input
	void PlayerInput()
	{
		//Checking for key press, if so the player will regain their balance 
		 if (Input.GetKeyUp(KeyCode.RightArrow) ||  Input.GetKeyDown(KeyCode.A))
        {
            i_Balance += i_BalanceGain;	// Adds defined points onto the players balance
        }
			 if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.D))
        	{
            	i_Balance += i_BalanceGain;	// Adds Defined points onto the players balance
        	}
	
	}

	
	
    	//Method which will enable a graphical user interface for the player to see what their current balance is
      void OnGUI()
    {
		
			GUI.skin = s_MySkin;
        	GUI.Box(new Rect(10,10,Screen.width/2,20),"Balance: " +i_Balance+"");		//Creates  a new rectangle which will hold the players balance
		
			//GUI.Box(new Rect(10,10,Screen.width/2,20),"Balance: " +i_Balance+"");		//Creates  a new rectangle which will hold the players balance
		
    }


    


 
    
   
}
