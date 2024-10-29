using UnityEngine;

public class NPCDialogue : MonoBehaviour, IInteractable
{
    public string npcName;       
    public Dialogue dialogue;    

    public string GetInteractPrompt()
    {
        return $"{npcName} 대화하기 [E]";  
    }

    public void OnInteract()
    {
        CharacterManager.Instance.Player.TalkUI.SetActive(true);
        DialogueManager.Instance.StartDialogue(this); 
    }
}
