// Also see : https://docs.unity3d.com/ScriptReference/ScriptableObject.html

using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Sample")]
public class ScriptableObjectExample : ScriptableObject
{
  privte void Awake() {}
  
  privte void OneEnable() {}
  
  privte void OnDisable() {}
  
  privte void OnDestroy() {}
}
