using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null; 
    public static GameManager Instance 
    { 
        get 
        { 
            if (_instance == null) 
            { 
                _instance = FindObjectOfType<GameManager> (); 
            } 
            return _instance; 
        } 
    } 

    public List<SmallBox> smallBox;
    private int smallBoxCount;
    private int smallBoxCounter=0;
    public Text ScoreText; 

    public int score;

    private List<GameObject> spawnedSmallBox;

    // Start is called before the first frame update
    void Start()
    {
        spawnedSmallBox = new List<GameObject>();
        smallBoxCount= Random.Range(5, 10);
        while(smallBoxCounter<=smallBoxCount)
        {
            float randomPositionx = Random.Range(-8.5f , 8.5f);
            float randomPositiony = Random.Range(-4.5f , 4.5f);
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

    public void AddScore(){
        score +=1;
        ScoreText.text= $"Score {score.ToString("0")}";
    }
}
