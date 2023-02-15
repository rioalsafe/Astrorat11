using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHP : MonoBehaviour
{
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
        currentHP = maxHP;          // 현재 체력을 최대 체력과 같게 설정
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