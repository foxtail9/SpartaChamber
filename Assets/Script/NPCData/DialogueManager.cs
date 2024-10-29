using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }

    public TextMeshProUGUI dialogueText;
    private Dialogue currentDialogue;
    private int currentLineIndex;
    public bool npcTalking = false;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (npcTalking && Input.GetKeyDown(KeyCode.E))
        {
            ShowNextLine();
        }
    }

    public void StartDialogue(NPCDialogue npcDialogue)
    {
        npcTalking = true;
        currentDialogue = npcDialogue.dialogue;
        currentLineIndex = 0;
        CharacterManager.Instance.Player.TalkUI.SetActive(true);  
        ShowNextLine();
    }

    public void ShowNextLine()
    {
        if (currentDialogue != null && currentLineIndex < currentDialogue.dialogueLines.Length)
        {
            dialogueText.text = currentDialogue.dialogueLines[currentLineIndex];
            currentLineIndex++;
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        npcTalking = false;
        CharacterManager.Instance.Player.TalkUI.SetActive(false); 
        dialogueText.text = "";
    }
}
