using UnityEngine;
using System.Collections;


public class Cam : MonoBehaviour {
 
  
    // Update is called once per frame
    void Update()
    {


        GameObject g_Terrain = GameObject.Find("Terrain");

       // iTween.ShakeRotation(g_Player, new Vector3(0.0f, 0.5f, 0.0f), 1);
        iTween.ShakePosition(g_Terrain, new Vector3(0.0f,0.1f,0.0f), Time.deltaTime * 1);
	}
}
