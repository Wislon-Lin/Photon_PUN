using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetworking : MonoBehaviour
{
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private MonoBehaviour[] scriptsToIgnore;
    PhotonView photonview;
	void Start ()
    {
        photonview = GetComponent<PhotonView>();
        Initialize();
    }
	void Initialize()
    {
      if(photonview.isMine)
        {

        }
      else
        {
            playerCamera.SetActive(false);
            foreach(MonoBehaviour item in scriptsToIgnore)
            {
                item.enabled = false;
            }
        }

    }
	
}
