using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Player))]
public class GameManager : NetworkBehaviour
{

    private const string PLAYER_ID_PREFIX = "Player ";
    private static Dictionary<string, Player> players = new Dictionary<string, Player>();


    public override void OnStartClient()
    {
        base.OnStartClient();

        string _netID = GetComponent<NetworkIdentity>().netId.ToString();
        Player _player = GetComponent<Player>();
        RegisterPlayer(_netID, _player);
    }

    public static void RegisterPlayer(string _netID, Player _player)
    {
        string _playerID = PLAYER_ID_PREFIX + _netID;
        players.Add(_playerID, _player);
        _player.transform.name = _playerID;
    }

    private void OnDisable()
    {
        UnRegisterPlayer(transform.name);
    }

    public static void UnRegisterPlayer(string _playerID)
    {
        players.Remove(_playerID);
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(200, 200, 200, 500));
    }
}
