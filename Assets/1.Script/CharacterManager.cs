using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterManager : MonoBehaviour
{
    //ΩÃ±€≈Ê
    public CharacterData[] characterDatas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class CharacterData
{
    public CharacterName characterName;
    [SerializeField] private string name;

    public string Name
    {
        get { return name; }

    }
}
public enum CharacterName
{
    Player,
    Npc1,
}
