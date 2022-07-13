using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public float exp;
    public int age;
    public string playerName;
    public Text expTex, ageTex, playerNameTex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetFloat("Exp",exp);
            PlayerPrefs.SetInt("Age",age);
            PlayerPrefs.SetString("PlayerName",playerName);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (PlayerPrefs.HasKey("Exp"))
            {
                expTex.text = PlayerPrefs.GetFloat("Exp").ToString();
            }
            else
            {
                Debug.Log("不包含这个Key");
            }
            
            ageTex.text = PlayerPrefs.GetInt("Age").ToString();
            playerNameTex.text = PlayerPrefs.GetString("PlayerName");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPrefs.DeleteKey("Exp");
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
