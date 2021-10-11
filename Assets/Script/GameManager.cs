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
    public Text ScoreText; 
    public float SaveDelay= 3.0f;

    private int smallBoxCounter=0;

    private int score;

    private List<GameObject> spawnedSmallBox;

    // Start is called before the first frame update
    void Start()
    {
        spawnedSmallBox = new List<GameObject>();
        smallBoxCount= Random.Range(5, 10);
        while(smallBoxCounter<=smallBoxCount)
        {
            SpawnSmallBox();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnSmallBox(){
        float posx = Random.Range(-8.5f , 8.5f);
        float posy = Random.Range(-4.5f , 4.5f);
        Vector2 rand_pos = new Vector2(posx, posy);

        RaycastHit2D hit = Physics2D.Raycast(rand_pos, Vector2.up, 0f);
        if (hit.collider != null)
        {
            SpawnSmallBox();
        }

        GameObject newSmallBox = Instantiate(smallBox[Random.Range(0, smallBox.Count)].gameObject, transform);

        newSmallBox.transform.position = new Vector2(posx, posy);
        spawnedSmallBox.Add(newSmallBox);
        smallBoxCounter++;
    }

    public void AddScore(){
        score +=1;
        smallBoxCounter-=1;
        ScoreText.text= $"Score {score.ToString("0")}";
        Invoke("SpawnSmallBox",3.0f);
    }
}
