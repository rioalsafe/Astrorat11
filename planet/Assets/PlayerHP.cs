using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 20;     // �ִ� ü��
    private float currentHP;      // ���� ü��

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    void Update()
    {
        
    }

    private void Awake()
    {
        currentHP = maxHP;          // ���� ü���� �ִ� ü�°� ���� ����
    }

    public void TakeDamage(int damage)
    {
        // ���� ü���� damage��ŭ ����
        currentHP -= damage;
        Debug.Log("HP : " + currentHP);

        // ü���� 0�� �Ǹ� ���ӿ���
        if (currentHP <= 0)
        {
        }
    }
}