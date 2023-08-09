using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameScript : MonoBehaviour
{
    public string gameMode;
    public GameObject cross, nought;
    public TextMeshProUGUI Instructions;
    public enum Seed { EMPTY, CROSS, NOUGHT };
    public Seed Turn;
    private void Awake()
    {
        // to get the Game mode information from the previous scene
        /*GameObject persistantObj = GameObject.FindGameObjectWithTag("PersistantObj") as GameObject;
        gameMode = persistantObj.GetComponent<PersistanceScript>().gameMode;
        Destroy(persistantObj);*/
        // here turn is player 1 which is cross
        Turn = Seed.CROSS;
        // Set initial instruction
        Instructions.text = "Turn: Player 1";
    }
    public void Spawn(GameObject emptycell, int id)
    {
        // conditions to spawn cross or nought
        if (Turn == Seed.CROSS)
        {
             Instantiate(cross, emptycell.transform.position, Quaternion.identity);
            Turn = Seed.NOUGHT;
            Instructions.text = "Turn: Player 2";

        }
       else if (Turn == Seed.NOUGHT)
        {
            Instantiate(nought, emptycell.transform.position, Quaternion.identity);
            Turn = Seed.CROSS;
            Instructions.text = "Turn: Player 1";
        }
        Destroy(emptycell);

    }
}

