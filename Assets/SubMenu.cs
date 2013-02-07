using UnityEngine;
using System.Collections;

public class SubMenu : MonoBehaviour {
	
	public bool isQuitButton;
	public bool isInfoButton;
	public bool isEndButton;
		
    void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
    }
	
    void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
	
	
	void OnMouseUp()
	{
		
	
		if(isQuitButton)
		{
			Application.Quit();
		}
		else if (isInfoButton)
		{
			Application.LoadLevel(1);
		}
		else if(isEndButton)
		{
			Application.LoadLevel(0);
		}
		else 
		{
			Application.LoadLevel(2);
		}
		
	}


}
