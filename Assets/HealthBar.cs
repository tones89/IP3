using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

    int maxHealth = 100;
    int currentHealth = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, Screen.width /2 / (currentHealth/maxHealth),20), currentHealth + "/"+ maxHealth);
    }
}
