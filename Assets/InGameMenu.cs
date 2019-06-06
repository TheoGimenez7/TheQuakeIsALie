using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour {

    public static bool isOn = false;

    [SerializeField]
    private GameObject IngameMenu;

    [SerializeField]
    private GameObject scoreboard;


    // Use this for initialization
    private void Start () {
        InGameMenu.isOn = false;

    }
	
	// Update is called once per frame
	private void Update ()
    {
		if(Input.GetKeyDown(KeyCode.M))
        {
            ToggleIngameMenu();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("3");
            scoreboard.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            Debug.Log("10");
            scoreboard.SetActive(false);
        }

    }

    public void ToggleIngameMenu()
    {
        IngameMenu.SetActive(!IngameMenu.activeSelf);
        InGameMenu.isOn = IngameMenu.activeSelf;    
    }

}
