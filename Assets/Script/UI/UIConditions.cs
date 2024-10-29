using UnityEngine;

public class UIConditon : MonoBehaviour
{
    public Condition health;
    public Condition hunger;
    public Condition Stamina;

    private void Start()
    {
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}
