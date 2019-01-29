using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    // Create a public static LevelManager variable that will be set by the Unity Engine (in the Awake function below)
    // to point to the one and only LevelManager object in the Scene. This variable can then be used by any script that
    // needs to to access the one and only LevelManager object by going LevelManager.instance.
    public static LevelManager instance;

	// Okay, what objects does the LevelManager need to be connected to. I'll start you off
    // and say the LevelManager needs to be connected to the SwitchController script on the
    // Switch game object so that it can call the turnOn() and turnOff() functions on it when
    // the user presses the spacebar AND the switch is enabled (which is done by moving the
    // Hero beside the Switch).

	// The SwitchController
	public SwitchController theSwitch;

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // This function will get called when the Player presses the spacebar (have a look at the InputManager
    // script that I have attached to the Hero GameObject). You are going to have to write the code that
    // goes into this function that will (a) if the switch is enabled will turn it on if it is off and
    // push the Vase off the ledge and (b) if the switch is enabled will turn it off if it is on.
	public void flipTheSwitch() {
		
	}

    // The following two functions get called by the SwitchController object when the Hero enters the 
    // trigger box of the Switch. You need to write the code that goes into these functions.
    public void onSwitchTriggerEnter(Collider2D other)
    {

    }

    public void onSwitchTriggerExit(Collider2D other)
    {
        
    }
}
