using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    public int weaponId;
    
    private enum WeaponIds
    {
        Gun = 1,
        Knife = 2,
        MachineGun = 3
    }

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    void Update()
    {
        switch (weaponId)
        {
            case 1:
            case 2:
            case 3:
                Debug.Log("You have chosen " + (WeaponIds) weaponId);
                break;
            default:
                Debug.Log("Invalid Weapon Id please choose an ID of 1, 2, or 3");
                break;
        }
    }
}
