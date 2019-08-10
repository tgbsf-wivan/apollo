using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{

  public float TranslationSpeed = 10.0f;
  public float RotationSpeed = 10.0f;

  void MoveForward()
  {
    transform.Translate(Vector3.forward * TranslationSpeed * Time.deltaTime);
  }

  void MoveBackward()
  {
    transform.Translate(Vector3.back * TranslationSpeed * Time.deltaTime);
  }

  void MoveUp()
  {
    transform.Translate(Vector3.up * TranslationSpeed * Time.deltaTime);
  }

  void MoveDown()
  {
    transform.Translate(Vector3.down * TranslationSpeed * Time.deltaTime);
  }

  void RotateLeft()
  {
    transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);
  }

  void RotateRight()
  {
    transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      MoveForward();
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      MoveBackward();
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      RotateLeft();
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      RotateRight();
    }
  }


}
