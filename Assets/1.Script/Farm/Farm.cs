using UnityEngine;

public class Farm : MonoBehaviour
{
    public FarmingFieldInteraction[] farmingFields;
    public FarmingFieldInteraction target;

    private void Start()
    {
        farmingFields = GetComponentsInChildren<FarmingFieldInteraction>();
    }
    private void Update()
    {
        //플레이어 해당밭안에 있는지 감지(선작업 해야하는 기능)

        if(Input.GetKeyDown(KeyCode.F))
        {      
            target = FindField(Player.Instance.transform.position);
            if(target == null)
            return;

            target.Interact(null);
            


        }
    }
    FarmingFieldInteraction FindField(Vector2 pos)
    {
        float minDistance = float.MaxValue;
        int idx = -1;

        for(int i =0;i< farmingFields.Length; i++)
        {
            float dis = Vector2.SqrMagnitude(pos - (Vector2)farmingFields[i].transform.position);

            if(dis < minDistance)
            {
                idx = i;
                minDistance = dis;
            }
        }

        if (idx < 0)
            return null;

        if(Vector2.Distance (farmingFields[idx].transform.position, Player.Instance.transform.position) > 1f)
        return null;

        return farmingFields[idx];
    }
}
