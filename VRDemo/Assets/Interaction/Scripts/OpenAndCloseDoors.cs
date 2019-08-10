using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class OpenAndCloseDoors : NetworkBehaviour
{

  public class Command : MessageBase
  {
    public static short id { get { return 1000; } }
  }


  public Transform LeftDoor = null;
  public Transform RightDoor = null;

  private bool are_open = false;

  void ToggleDoors(NetworkMessage netMessage)
  {
    if (are_open)
    {
      LeftDoor.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
      RightDoor.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
      are_open = false;
    }
    else
    {
      LeftDoor.localRotation = Quaternion.Euler(0.0f, -60.0f, 0.0f);
      RightDoor.localRotation = Quaternion.Euler(0.0f, 60.0f, 0.0f);
      are_open = true;
    }
  }

  void Start()
  {
    if (isServer)
    {
      NetworkServer.RegisterHandler(Command.id, ToggleDoors);
    }
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.D))
    {
      if (isClient)
      {
        NetworkManager.singleton.client.Send(Command.id, new Command());
      }
    }
  }

}
