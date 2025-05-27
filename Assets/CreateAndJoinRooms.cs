using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField Createinput;
    public TMP_InputField Joininput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(Createinput.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(Joininput.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene"); 
    }
}
