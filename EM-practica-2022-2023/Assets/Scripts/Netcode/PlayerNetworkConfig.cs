using Unity.Netcode;
using UnityEngine;
using UnityEngine.Serialization;

namespace Netcode
{
    public class PlayerNetworkConfig : NetworkBehaviour
    {
        public GameObject characterPrefab;
        public bool isReady = false;
        public string name;

        public override void OnNetworkSpawn()
        {
            if (!IsOwner) return;
            if(isReady) InstantiateCharacterServerRpc(OwnerClientId);
        }
    
        [ServerRpc]
        public void InstantiateCharacterServerRpc(ulong id)
        {
            GameObject characterGameObject = Instantiate(characterPrefab);
            characterGameObject.GetComponent<NetworkObject>().SpawnWithOwnership(id);
            characterGameObject.transform.SetParent(transform, false);
        }
    }
}
