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
    [Header("Prefabs")]
    public List<SmallBox> smallBox;
    public List<Projectile> projectile;
    [Header("UI")]
    public UIGameOver GameOverUI;

    private int smallBoxCount;
    public Text ScoreText; 
    public float SmallBoxDelay= 3.0f;
    public float ProjectileDelay= 5.0f;

    private float _projectileDelayCounter;
    private int smallBoxCounter=0;

    private int score;

    private List<GameObject> spawnedSmallBox;
    private List<GameObject> spawnedProjectile;
    
    

    public bool IsGameOver { get { return isGameOver; } }

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnedSmallBox = new List<GameObject>();
        spawnedProjectile = new List<GameObject>();
        smallBoxCount= Random.Range(5, 10);
        while(smallBoxCounter<=smallBoxCount)
        {
            SpawnSmallBox();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.unscaledDeltaTime;
        _projectileDelayCounter -= deltaTime;
        

        if(_projectileDelayCounter < 0f)
        {
            SpawnProjectile();
            _projectileDelayCounter = SmallBoxDelay;
        }

        
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
        Invoke("SpawnSmallBox", 3.0f);
    }

    public void SpawnProjectile(){
        float rand_num= Random.Range(0,2f);
        float posy;
        float posx;
        float rotate;
        if(rand_num<=1.0f){
            posx = Random.Range(-8.0f , 8.0f);
            posy = 4.2f;
            float rand_pos= Random.Range(0,2f);
            rotate = -90;
            if(rand_pos<=1.0f){
                posy= -posy;
                rotate= -rotate;
            }
        }else{
            posy = Random.Range(-4.2f , 4.2f);
            posx = 8.0f;
            float rand_pos= Random.Range(0,2f);
            rotate = 180;
            if(rand_pos<=1.0f){
                posx= -posx;
                rotate = 0;
            }
        }
        GameObject newProjectile = Instantiate(projectile[Random.Range(0, projectile.Count)].gameObject, transform);
        newProjectile.transform.position = new Vector2(posx, posy);
        newProjectile.transform.eulerAngles = new Vector3 (0, 0, rotate);
        spawnedProjectile.Add(newProjectile);
    }

    public void GameOver()
    {
        isGameOver = true;
        GameOverUI.Show();
    }
}
