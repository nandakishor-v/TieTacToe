using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public float duration;

    private void Update()
    {
        if (duration < 0.0f)
        {
            SceneManager.LoadScene("MainScreen");
        }
        else
        {
            duration = duration - Time.deltaTime;
        }
    }
}
