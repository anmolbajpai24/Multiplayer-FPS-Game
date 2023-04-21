using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Photon.Pun;

public class Rooms : MonoBehaviourPunCallbacks
{
    public InputField create;
    public InputField join;

    

    //public Button createButton;
    //public Button joinButton;
    
    

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    // Start is called before the first frame update
    void Start()
    {
     //   var root = GetComponent<UIDocument>().rootVisualElement;

       // createButton = root.Q<Button>("create-button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
