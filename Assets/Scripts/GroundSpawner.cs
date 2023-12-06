using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundtile;
    Vector3 nextspawnpoint;
    
    public void spawntile()
    {
        GameObject temp = Instantiate(groundtile, nextspawnpoint, Quaternion.identity);
        nextspawnpoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            spawntile();
        }
        
        

    }


}
