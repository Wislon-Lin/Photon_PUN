using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : Photon.MonoBehaviour
{
    public GameObject player;
    [SerializeField ]private GameObject lobbyCamera;
	void Start ()
    {
        PhotonNetwork.ConnectUsingSettings("1.0");	
	}
	void OnJoinedLobby() //建立房間
    {
        PhotonNetwork.JoinOrCreateRoom("Room",new RoomOptions() {MaxPlayers = 2 },TypedLobby.Default);
    }
    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player",player.transform.position,Quaternion.identity,0);
        lobbyCamera.SetActive(false);
    }
	
}
