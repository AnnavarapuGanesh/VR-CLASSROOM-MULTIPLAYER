using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public Transform SpwanPlayers;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        

        GameObject player=PhotonNetwork.Instantiate(playerPrefab.name,SpwanPlayers.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}