using Photon.Pun;
using UnityEngine;

namespace Arena_Game.Arena_Scripts
{
    public class RoomManager : MonoBehaviourPunCallbacks
    {

        [SerializeField] private GameObject player;

        [SerializeField] private Transform spawnPoint;
        
        private void Start()
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

        public override void OnJoinedRoom()
        {
            base.OnJoinedRoom();
            
            Debug.Log("We're connected and in a room");

            var _player = PhotonNetwork.Instantiate(this.player.name, spawnPoint.position, Quaternion.identity);
        }
        
    
    }
}
