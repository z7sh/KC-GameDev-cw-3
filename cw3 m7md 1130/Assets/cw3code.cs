using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3code : MonoBehaviour
{
    // hero stuf
    string heroName = "Mohamad";
    int heroPower = 70;
    // vailine stuff
    string villainName = "Mozan";
    int villainPower = 1000000;
    float playerSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        setSpeed(2);
        if (villainPower < heroPower)
        {
            print("hero is stronger");
        }
        else if(villainPower > heroPower)
        {
            print("vilain is sronger");
        }
        else
        {
            print("both are equal");
        }
        
    }
    void setSpeed(float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
    





}
