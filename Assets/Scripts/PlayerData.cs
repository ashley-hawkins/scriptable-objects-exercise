using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObject Exercise/PlayerData")]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    private string m_PlayerName = "Change Me";
    public string PlayerName { get { return m_PlayerName; } }

    [SerializeField]
    private int maxHealth = 100;

    [SerializeField]
    private int initialHealth = 100;

    private int m_Health;
    public int Health
    {
        get { return m_Health; }
        set
        {
            if (value > maxHealth)
            {
                m_Health = maxHealth;
            }
            else
            {
                m_Health = value;
            }

            if (m_Health <= 0)
            {
                Lives -= 1;
                m_Health = initialHealth;
            }
        }
    }

    [SerializeField]
    private int initialLives = 2;

    public int Lives { get; set; }

    // Called to initialise the data, this would probably be called when the game starts.
    public void Init()
    {
        Health = initialHealth;
        Lives = initialLives;
    }

    private void Awake()
    {
        Init();
    }
}