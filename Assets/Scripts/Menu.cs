using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class Menu : MonoBehaviour
{
    public Text BestScoretext;
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        if (PersistenceGameManager.Instance != null)
            BestScoretext.text = $"Best Score : {PersistenceGameManager.Instance.BestPlayerName} : {PersistenceGameManager.Instance.BestScore}";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewNameEntered(string name)
    {
        PersistenceGameManager.Instance.PlayerName = name;
    }

    public void StartNew()
    {
        string name = inputField.GetComponent<TMP_InputField>().text;
        NewNameEntered(name);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        PersistenceGameManager.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
