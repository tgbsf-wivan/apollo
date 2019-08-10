using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class OpenAndCloseDoors : NetworkBehaviour
{

  public Transform LeftDoor = null;
  public Transform RightDoor = null;

  private bool are_open = false;

  [Command]
  void CmdToggleDoors()
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

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.D))
    {
      CmdToggleDoors();
    }
  }

}
