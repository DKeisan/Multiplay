using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonobitEngine;

public class MUNtest : MonobitEngine.MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MonobitNetwork.ConnectServer("TEST");

        MonobitNetwork.autoJoinLobby = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnJoinedLobby()
    {
        Debug.Log("ロビー接続");

        RoomSettings settings = new RoomSettings();
        settings.maxPlayers = 10;
        settings.isVisible = true;
        settings.isOpen = true;

        MonobitNetwork.JoinOrCreateRoom("room", settings, null);

    }
    public void OnJoinedRoom()
    {
        Debug.Log("ルーム接続");
        Vector3 startPos = new Vector3(0.0f, 0.0f, 0.0f);
        MonobitEngineBase.MonobitNetwork.Instantiate("Player", startPos, Quaternion.identity, 0);
    }

}
