using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Networking : NetworkManager
{

  public bool host = false;
  public string address = "localhost";
  public short port = 7777;

  public override void OnServerConnect(NetworkConnection conn)
  {
    Debug.Log("OnPlayerConnected");
  }

  // Start is called before the first frame update
  void Start()
  {
    this.networkAddress = address;
    this.networkPort = port;
    if (host)
    {
      Debug.Log("Starting Host");
      this.StartHost();
    }
    else
    {
      Debug.Log("Starting Client");
      this.StartClient();
    }
  }
}
