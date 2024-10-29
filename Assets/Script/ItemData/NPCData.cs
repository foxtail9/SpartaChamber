using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCType
{
    Nomal
}

[CreateAssetMenu(fileName = "NPC", menuName = "New NPC")]
public class NPCData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public NPCType npctype;
}
