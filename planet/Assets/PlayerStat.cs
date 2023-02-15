using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerGold : MonoBehaviour
{
   [SerializeField]
    private float startgold = 20;     
    private float currentGold;      

    public float Startgold => startgold;
    public float CurrentGold => currentGold;

    [SerializeField]
    private float maxHP = 20;     // 최대 체력
    private float currentHP;      // 현재 체력

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    void Update()
    {
        
    }

    private void Awake()
    {
        currentGold = startgold;
        currentHP = maxHP;
    }

    public void TakeGold(int gold)
    {

        currentGold += gold;
        Debug.Log("gold : " + currentGold);

   
        if (currentGold <= 0)
        {

        }
    }

    public void TakeDamage(int damage)
    {
        // 현재 체력을 damage만큼 감소
        currentHP -= damage;
        Debug.Log("HP : " + currentHP);

        // 체력이 0이 되면 게임오버
        if (currentHP <= 0)
        {
        }
    }
}