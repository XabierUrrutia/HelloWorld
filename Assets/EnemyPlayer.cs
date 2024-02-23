using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyPlayer{

    public class Enemy : Character{

        public enemy(string name): base(name){
            Character ch = new character(name);
            Debug.Log("Soy un enemigo.");
        }
    }

    public class Player : Character{

        public player(string name):base(name){
            Character ch = new character(name);
            Debug.Log("Soy un personaje.");
        }
    }
}