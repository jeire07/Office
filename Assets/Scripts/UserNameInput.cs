using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserNameInput : MonoBehaviour
{
    public TMP_InputField UserName;

    // Start is called before the first frame update
    void Start()
    {
        UserName.onEndEdit.AddListener(OnInputEndEdit);
    }

    void OnInputEndEdit(string input)
    {
        Debug.Log("user's input: " + input);
    }
}
