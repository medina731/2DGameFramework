using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.worlds
{
    public class WorldObject
    {

        /// <summary>
        /// Her er mine properties, der er Navn, Lootable og Removeable, de er allesammen sat til med bade get og set.
        /// </summary>
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        /// <summary>
        /// så her har vi vores konstruktor, der initialisere en ny instans af worldobject. Den har default values som et tomt navn, og både removeabke og lootable er sat til false.
        /// </summary>
        public WorldObject()
        {
            Name = string.Empty;
            Lootable = false;
            Removeable = false;
        }

        /// <summary>
        /// returnere en string der repræsentere world objectet, med ets navn, lootable status og dens removable status.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Lootable)}={Lootable.ToString()}, {nameof(Removeable)}={Removeable.ToString()}}}";
        }
    }
}
