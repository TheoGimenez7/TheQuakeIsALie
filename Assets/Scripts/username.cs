using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class username : MonoBehaviour {

    public InputField name;
    public GameObject player;

    public void setget()
    {
        player.GetComponent<Player>().username = name.text;
    }

}
