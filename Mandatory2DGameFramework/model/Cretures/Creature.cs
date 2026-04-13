using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Strategy;



namespace Mandatory2DGameFramework.model.Cretures
{
  
    
        public abstract class Creature
        {
            public string Name { get; set; }
            public int HitPoint { get; protected set; }

          public AttackItem? Attack { get; set; }
         public DefenceItem? Defence { get; set; }


        // STRATEGY
        public IMovementStrategy? MovementStrategy { get; set; }

            // OBSERVER
            private readonly List<ICreatureObserver> observers = new();

            protected Creature(string name, int hitPoint = 100)
            {
                Name = name;
                HitPoint = hitPoint;
            }

            // OBSERVER: tilføj/fjern
            public void AddObserver(ICreatureObserver observer) => observers.Add(observer);
            public void RemoveObserver(ICreatureObserver observer) => observers.Remove(observer);

            // OBSERVER: notify
            public void NotifyHit(int damage)
            {
                foreach (var o in observers)
                    o.OnCreatureHit(this, damage);
            }

            public void NotifyDeath()
            {
                foreach (var o in observers)
                    o.OnCreatureDeath(this);
            }

            // TEMPLATE METHOD
            protected void TakeTurn()
            {
                Move();          // ← STRATEGY bliver brugt her
                DecideAction();
                ExecuteAction();
            }


        public void ApplyDamage(int damage)
        {
            HitPoint -= damage;

            if (HitPoint < 0)
                HitPoint = 0;

            NotifyHit(damage);

            if (HitPoint == 0)
                NotifyDeath();
        }


        // STRATEGY-BASERET MOVE
        protected virtual void Move()
            {
                MovementStrategy?.Move(Name);
            }

            protected abstract void DecideAction();
            protected abstract void ExecuteAction();
        }
 }


