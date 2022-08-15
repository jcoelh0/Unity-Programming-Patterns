using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class Flyweight
    {
        //Data for each individual object
        private float health;

        //This is the data that's being shared among all objects so you have to inject it in the constructor
        //private Data data;

        [SerializeField]
        private GameObject gameObject;

        public Flyweight(GameObject gameObject)
        {
            this.gameObject = gameObject;
            this.gameObject.transform.position = new Vector3(Random.Range(0f, 10f), 0, 0);

            health = Random.Range(10f, 100f);

            //this.data = data;
        }
    }
}
