using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<SmallBox> smallBox;
    public int smallBoxCount;
    public int smallBoxCounter=0;

    private List<GameObject> spawnedSmallBox;

    // Start is called before the first frame update
    void Start()
    {
        spawnedSmallBox = new List<GameObject>();
        while(smallBoxCounter<=smallBoxCount)
        {
            float randomPositionx = Random.Range(-8.7f , 8.7f);
            float randomPositiony = Random.Range(-4.8f , 4.8f);
            SpawnSmallBox(randomPositionx, randomPositiony);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnSmallBox(float posx, float posy){
        GameObject newSmallBox = Instantiate(smallBox[Random.Range(0, smallBox.Count)].gameObject, transform);

        newSmallBox.transform.position = new Vector2(posx, posy);
        spawnedSmallBox.Add(newSmallBox);
        smallBoxCounter++;
    }
}
