using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoisonController : MonoBehaviour
{
    int poison;
    int resetPoison;
    [SerializeField] Text poisonText;
    [SerializeField] GameObject poisonObject;
    private void Start()
    {
        ResetPoison();
        UpdatePoison();
    }
    public void IncreasePoison()
    {
        poison++;
        UpdatePoison();
    }
    public void DecreasePoison()
    {
        poison--;
        UpdatePoison();
    }
    public void ResetPoison()
    {
        poison = resetPoison;
        UpdatePoison();
    }
    public void UpdatePoison()
    {
        poisonText.text = poison.ToString("00");
    }
    public void SetEnabled(bool enabled)
    {
        poisonObject.SetActive(enabled);
    }

}
