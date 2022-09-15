using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image heathbarSprite;

    public void UpdateHeathBar(float maxHeath, float currentHealth)
    {
        heathbarSprite.fillAmount = currentHealth / maxHeath;
    }
}
