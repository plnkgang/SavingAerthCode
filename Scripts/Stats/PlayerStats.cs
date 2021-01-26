using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats 
{
    #region Singleton

    public static PlayerStats instance;

    private void Awake()
    {
        instance = this;
        currentHealth = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);
    }

    #endregion

    public int healsCount;

    public int killsCount;

    public HealthBar playerHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(10);
        }

        if (killsCount == 21)
        {
            LevelLoader.instance.LoadNextLevel("2ndLevel");
        }
    }

    void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null)
        {
            armor.AddModifier(newItem.armorModifier);
            damage.AddModifier(newItem.damageModifier);
        }

        if (oldItem != null)
        {
            armor.RemoveModifier(oldItem.armorModifier);
            damage.RemoveModifier(oldItem.damageModifier);
        }
    }

    public void Heal(int heal)
    {
        healsCount--;
        if (healsCount > -1)
        {
            currentHealth += heal;
            Debug.Log(transform.name + " heals " + heal);

            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            }

            playerHealthBar.SetHealth(currentHealth);
        }
        else
        {
            healsCount = 0;
            Debug.Log("No more heals available :(");
        }
    }

    public override void Die()
    {
        base.Die();
        PlayerManager.instance.KillPlayer();
    }
}
