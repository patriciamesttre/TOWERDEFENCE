using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField] private int vida;

   private int bonus;

    public int GetVida()
    {
        return vida;
    }

    public void PerdeVida()
    {
        vida--;
    }

    public int GetBonus()
    {
        return bonus;
    }

    public void AumentaVida()
    {
        vida++;
    }

    public void AumentaBonus()
    {
        bonus++;
        if(bonus >= 3)
        {
            AumentaVida();
            ZerarBonus();
        }
    }

    public void ZerarBonus()
    {
        bonus = 0;
    }
}
