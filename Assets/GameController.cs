using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject[] playerList;
    [SerializeField] Dropdown gameSelection;
    // Start is called before the first frame update
    private void Start()
    {
        SelectGame();
    }
    public void SelectGame()
    {
        for (int i = 0; i < playerList.Length; i++)
        {
            if(gameSelection.value == 0)
            {
                playerList[i].GetComponent<HealthController>().SetMTG20();
            }
            else if(gameSelection.value == 1)
            {
                playerList[i].GetComponent<HealthController>().SetMTG40();
            }
            else if(gameSelection.value == 2)
            {
                playerList[i].GetComponent<HealthController>().SetHeroRealms();
            }
        }
    }
}
