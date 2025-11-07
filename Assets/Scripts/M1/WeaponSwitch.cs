using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapons("Sword", 25f, 1f);
            Debug.Log("Sword: Balanced weapon");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapons("Bow", 20f, 1.5f);
            Debug.Log("Bow: Fairly fast long ranged");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Weapons("Staff", 35f, 0.7f);
            Debug.Log("Staff: Slow but powerfull");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Weapons("Dagger", 15f, 2f);
            Debug.Log("Dagger: Small but fast");
        }
    }

    private void Weapons(string name, float damage , float attackSpeed)
    {
        Debug.Log("Equipped: " +  name);
        Debug.Log("Damage: " + damage + "Speed" + attackSpeed);
    }

}
