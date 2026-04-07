using Mandatory2DGameFramework.model.Cretures;
using Mandatory2DGameFramework.XML_Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.worlds
{

    /// <summary>
    /// Klassen repræsentere vores spille verden, med størrelse, sværheds level, og kollektioner af world objects and væsner.
    /// </summary>
    public class World
    {
        /// <summary>
        /// her er properties, som er MaxX (sætter x-koordinaterne for spilleverdens grid), MaxY (definere maximum Y-kooordinaterne af spille verdens grid),
        /// difficulty ( definere sværhedsgraden for det level i spilleverden), alle 3 properties er i get og set.
        /// </summary>
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public string Difficulty { get; set; } //tilføjet sværhedsgraden


        /// <summary>
        /// world objekterne
        /// </summary>
        private List<WorldObject> _worldObjects;
        /// <summary>
        /// world creatures
        /// </summary>
        private List<Creature> _creatures;


        
        /// <summary>
        /// initialisere en ny instans af world klassen, ved at bruge de values givet fra GameConfiguration objekt.
        /// Det sætter str og sværhedsgraden for verden,og initialisere kollektionerne for world objects pg creatures.
        /// </summary>
        /// <param name="configuration"></param>
        public World(GameConfiguration configuration)
        {
            MaxX = configuration.MaxX;
            MaxY = configuration.MaxY;
            Difficulty = configuration.Difficulty;


            _worldObjects = new List<WorldObject>();
            _creatures = new List<Creature>();
        }

        //Example of LSP test, where we can use the base class Creature to create instances of derived classes (Elf, Fairy, Siren)
        //and interact with them through the base class interface.
        public void TestLSP()
        {
            Creature c1 = new Elf();
            Creature c2 = new Fairy();
            Creature c3 = new Siren();

            Console.WriteLine(c1.Name);
            Console.WriteLine(c2.Name);
            Console.WriteLine(c3.Name);

            CreatureFight fight1 = new CreatureFight(c1);
            CreatureFight fight2 = new CreatureFight(c2);
            
            int hit = fight1.Hit();
                fight2.ReceiveHit(hit);

            Console.WriteLine($"{c1.Name} hits {c2.Name}. {c2.Name} HP is now {c2.HitPoint}");


        }


        /// <summary>
        /// returnere en string repræsentation af verden, med MaxX og MaxY.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{{{nameof(MaxX)}={MaxX.ToString()}, {nameof(MaxY)}={MaxY.ToString()}}}";
        }
    }
}
