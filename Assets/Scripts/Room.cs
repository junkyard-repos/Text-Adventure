using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Room", menuName = "Text Adventure/Room", order = 0)]
public class Room : ScriptableObject
{
  [TextArea]
  public string description;
  public string roomName;
  // public Exit[] exits;
}

