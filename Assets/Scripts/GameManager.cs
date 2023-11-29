using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public string timeString;

    private float currentSec;

    public static GameManager GameCtrl;

    // Start is called before the first frame update
    void Start()
    {
        // current time, seconds
        currentSec = Time.time;

        // result
        Debug.Log("current time: " + MakeTimeStr(currentSec));
    }

    // Update is called once per frame
    void Update()
    {
        currentSec += Time.deltaTime;

        timeString = MakeTimeStr(currentSec);
    }

    string MakeTimeStr(float currentSec)
    {
        // convert to DateTime format
        System.DateTime currentTime = System.DateTime.MinValue.AddSeconds(currentSec);

        // convert to String
        timeString = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

        return timeString;
    }
}
