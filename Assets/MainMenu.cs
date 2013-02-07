using UnityEngine;
using System.Collections;
using System;


public class Menu : MonoBehaviour
{
	public Texture t_BackgroundTexture;
	public GUISkin s_MySkin;
	
	
	float f_ScreenWidth;
	float f_ScreenHeight;
	
	
    void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
    }
    void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
	
	void OnGUI()
	{
		
		f_ScreenHeight = Screen.height;
		f_ScreenWidth = Screen.width;
		GUI.DrawTexture(new Rect(0,0,f_ScreenWidth,f_ScreenHeight),t_BackgroundTexture);
		
		
		
			
	}

}
//