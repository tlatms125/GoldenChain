using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterManager : MonoSingleton<CharacterManager>
{
    //�̱���
    public CharacterData[] characterDatas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public CharacterData GetCharacterData(CharacterName characterName)
    {
        for (int i = 0; i < characterDatas.Length; i++)
        {
            if (characterDatas[i].characterName == characterName) 
            {
                return characterDatas[i]; // 
            }
        }
        return null; 
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

    public string Name //속성 : 변수와 함수를 결합한 형태
    {
        get
        {
            return name;
        }

    }
}
public enum CharacterName
{
    Player,
    immigrationOfficer, //입국심사관
}
