using Photon.Pun;
using UnityEngine;

namespace Arena_Game.Arena_Scripts
{
    public class RoomManager : MonoBehaviourPunCallbacks
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Connecting...");

            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            base.OnConnectedToMaster();
            Debug.Log("Connected to Server");

            PhotonNetwork.JoinLobby();
        }

        public override void OnJoinedLobby()
        {
            base.OnJoinedLobby();

            PhotonNetwork.JoinOrCreateRoom("test", null, null);
            
            Debug.Log("We're connected and in a room now");
        }
        
    
    }
}
