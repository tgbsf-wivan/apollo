
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Networking))]
[CanEditMultipleObjects]
public class NetworkingEditor : Editor
{

  SerializedProperty isHost;
  SerializedProperty address;
  SerializedProperty port;

  void OnEnable()
  {
    isHost = serializedObject.FindProperty("host");
    address = serializedObject.FindProperty("address");
    port = serializedObject.FindProperty("port");
  }

  public override void OnInspectorGUI()
  {
    serializedObject.Update();
    EditorGUILayout.PropertyField(isHost);
    EditorGUILayout.PropertyField(address);
    EditorGUILayout.PropertyField(port);
    serializedObject.ApplyModifiedProperties();
  }

}


