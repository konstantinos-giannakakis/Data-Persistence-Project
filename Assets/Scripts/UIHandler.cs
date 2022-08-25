using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public string UsernameInput;

    void Start()
    {
        UsernameInput = GameObject.Find("InputField").GetComponent<InputField>().text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }
    public void SaveName(InputField userField)
    {
        MenuManager.Instance.SaveName(UsernameInput = userField.text);
        Debug.Log(UsernameInput);
    }
}
