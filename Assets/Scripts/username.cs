using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class username : MonoBehaviour {

    [SerializeField]
    private GameObject IngameMenu;

    public InputField prenom;
    public GameObject player;

    public void setget()
    {
        player.name = prenom.text;
        player.GetComponent<Player>().username = prenom.text;
        IngameMenu.SetActive(!IngameMenu.activeSelf);
        InGameMenu.isOn = IngameMenu.activeSelf;

    }



}
