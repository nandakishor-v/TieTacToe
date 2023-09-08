using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void LoadScence()
    {
        GameObject persistantObj = GameObject.FindGameObjectWithTag("music") as GameObject;
       // gameMode = persistantObj.GetComponent<PersistanceScript>().gameMode;
        Destroy(persistantObj);
        SceneManager.LoadScene(1);
    }
   
}
