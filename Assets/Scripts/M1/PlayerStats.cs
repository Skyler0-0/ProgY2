using JetBrains.Annotations;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "DragonSlayer";
    public int level = 1;
    public string characterClass = "Warrior";
    //add your own stats here
    public int armorLevel = 1;
    public int weaponLevel = 1;

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 25;
    public int defense = 15;
    //add your own stats here
    public int strength = 17;
    public int stamina = 25;


    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    //add your own stats here
    public float distanceWalked = 15f;
    public int timesDied = 5;


    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Iron Sword";
    //add your own stats here
    public bool inventoryFull = false;
    public int inventorySlotsOpen = 34;

    void Start()
    {
        DisplayCharacterSheet();
    }

    void Update()
    {
        // Input om stats te updaten
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Level UP!
            level++;
            maxHealth += 20;
            health = maxHealth; // Full heal bij level up
            attack += 5;
            defense += 3;
            mana += 10;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Use Health Potion
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayCharacterSheet();
        }
        //Reset Stats here when R is pressed!

    }

    private void DisplayCharacterSheet()
    {
        //Display Character Sheet
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Level: " + level);
        Debug.Log("Armor Level: " + armorLevel);
        Debug.Log("Weapon Level: " + weaponLevel);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Strengt: " + strength + "| Stamina: " + stamina);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("Times Died: " + timesDied);
        Debug.Log("Distance Walked" + distanceWalked);
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Inventory Full?" + inventoryFull + "How Many Slots Left" + inventorySlotsOpen);
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}