﻿using System.Collections;
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
        if (EstaVivo()) {
            vida--;
        }
      
    }

    public bool EstaVivo()
    {
        return vida > 0;
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
