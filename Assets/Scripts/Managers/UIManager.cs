using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private PlayerStats stats;

    [Header("Bars")]
    [SerializeField] private Image healthbar;
    [SerializeField] private Image manabar;
    [SerializeField] private Image expbar;

    [Header("Text")]
    [SerializeField] private TextMeshProUGUI levelTMP;
    [SerializeField] private TextMeshProUGUI healthTMP;
    [SerializeField] private TextMeshProUGUI manaTMP;
    [SerializeField] private TextMeshProUGUI expTMP;


    private void Update()
    {
        UpdatePlayerUI();
    }

    private void UpdatePlayerUI()
    {
        healthbar.fillAmount = Mathf.Lerp(healthbar.fillAmount,
            stats.Health / stats.MaxHealth, 10f * Time.deltaTime);

        manabar.fillAmount = Mathf.Lerp(manabar.fillAmount,
            stats.Mana / stats.MaxMana, 10f * Time.deltaTime);

        expbar.fillAmount = Mathf.Lerp(expbar.fillAmount,
            stats.CurrentExp / stats.NextLevelExp, 10f * Time.deltaTime);

        levelTMP.text = $"Level {stats.Level}";
        healthTMP.text = $"{stats.Health} / {stats.MaxHealth}";
        manaTMP.text = $"{stats.Mana} / {stats.MaxMana}";
        expTMP.text = $"{stats.CurrentExp} / {stats.NextLevelExp}";
    }
}
