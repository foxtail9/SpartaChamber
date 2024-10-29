using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue/NPCDialogue")]
public class Dialogue : ScriptableObject
{
    [TextArea(2, 5)]
    public string[] dialogueLines; 
}
