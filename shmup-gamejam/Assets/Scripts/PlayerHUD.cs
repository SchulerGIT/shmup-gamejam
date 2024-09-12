using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Shmup
{
    public class PlayerHUD : MonoBehaviour
    {
        [SerializeField] Image healthBar;
        [SerializeField] TextMeshProUGUI scoreText;

        void Update()
        {
            healthBar.fillAmount = GameManager.Instance.Player.GetHealthNormalized();
            scoreText.text = $"Score: {GameManager.Instance.GetScore()}";
        }
    }
}