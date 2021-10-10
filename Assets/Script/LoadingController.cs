using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingController : MonoBehaviour
{
    [SerializeField] private Button _problem1Button;
    [SerializeField] private Button _problem2Button;
    [SerializeField] private Button _problem3Button;
    [SerializeField] private Button _problem4Button;
    [SerializeField] private Button _problem5Button;
    [SerializeField] private Button _problem6Button;
    [SerializeField] private Button _problem7Button;
    [SerializeField] private Button _problem8Button;
    [SerializeField] private Button _problem9Button;

 
    // Start is called before the first frame update
    void Start()
    {
         _problem1Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (1);
        });
        _problem2Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (2);
        });
        _problem3Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (3);
        });
        _problem4Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (4);
        });
        _problem5Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (5);
        });
        _problem6Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (6);
        });
        _problem7Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (7);
        });
        _problem8Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (8);
        });
        _problem9Button.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene (9);
        });
        
        
    }

    private void SetButtonInteractable (bool interactable)
    {
        _problem1Button.interactable = interactable;
        _problem2Button.interactable = interactable;
        _problem3Button.interactable = interactable;
        _problem4Button.interactable = interactable;
        _problem5Button.interactable = interactable;
        _problem6Button.interactable = interactable;
        _problem7Button.interactable = interactable;
        _problem8Button.interactable = interactable;
        _problem9Button.interactable = interactable;
    }
}
