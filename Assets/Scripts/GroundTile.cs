using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundspawner;
    // Start is called before the first frame update
    void Start()
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner>();
        spawnobstacle();    
    }

    private void OnTriggerExit(Collider other)
    {
        groundspawner.spawntile();
        Destroy(gameObject, 2);
    }

    
    public GameObject obstaclePrefab;
    public GameObject coinPrefab;

    void spawnobstacle()
    {
        //random point za obstacle
        int obstaclespawnindex = Random.Range(2, 5);
        
        Transform obstaclespawnPoint = transform.GetChild(obstaclespawnindex).transform;
        //spawn
        Instantiate(obstaclePrefab, obstaclespawnPoint.position, Quaternion.identity, transform);
        //random point za coin
        int coinspawnindex = Random.Range(4, 9);
        Transform coinspawnPoint = transform.GetChild(coinspawnindex).transform;

        //spawn
        if (coinspawnindex != obstaclespawnindex)
        { 
            Instantiate(coinPrefab, coinspawnPoint.position, Quaternion.Euler(0, 0, 90), transform); 
        }
    }

}
