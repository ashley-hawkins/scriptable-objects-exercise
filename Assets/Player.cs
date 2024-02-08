using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    PlayerData playerData;
    [SerializeField]
    TMPro.TextMeshProUGUI infoLabel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (playerData.Lives >= 0)
        {
            infoLabel.text = $"Health: {playerData.Health}\nLives: {playerData.Lives}";
        }
        else
        {
            infoLabel.text = "You are completely dead.";
        }
    }
}
