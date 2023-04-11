using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class DataManager : MonoBehaviour
{

    public static DataManager Instance;
    public MainManager mainManagerScript;

    public TMP_InputField playerInput;
    public string playerName;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInput != null)
        {
            EnterName();
        }
    }
    
    public void EnterName()
    {
        playerName = playerInput.text;
    }

    public void NameRemain()
    {
        DataManager.Instance.playerName = playerName;
    }
}
