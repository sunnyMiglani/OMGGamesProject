using UnityEngine;
using UnityEngine.Networking;

public class JoinAsClient : MonoBehaviour
{
    public GameSettings Settings;
    //triggers when another object enters its area.
    private void OnTriggerEnter(Collider other)
    {
        //if object is player then load scene
        if (other.gameObject.tag == "Player")
        {
            Join();
        }
    }

    public void Join() {
        Debug.Log("Joined as client");
        string ipAddress = Settings.IpAddress ?? "localhost";
        NetworkManager.singleton.networkAddress = ipAddress;
        NetworkManager.singleton.StartClient(); //Join as client, only changes to online scene if server/host is on
    }
}
