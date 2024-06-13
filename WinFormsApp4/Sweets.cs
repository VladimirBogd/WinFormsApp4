using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Sweets
    {
        public int Weight = 0; // вес
        protected static Random random = new Random();
        public virtual String GetInfo()
        {
            var str = String.Format("\nВес: {0}г", this.Weight);
            return str;
        }
    }

    public enum ChocosType { milk, dark }
    public class Chocos : Sweets
    {
        public int Cells = 0; // количество долек
        public ChocosType type = ChocosType.milk; // тип шоколада
        public override String GetInfo()
        {
            var str = "Я шоколад";
            str += base.GetInfo();
            str += String.Format("\nКоличество долек: {0}шт", this.Cells);
            str += String.Format("\nТип шоколада: {0}", this.type);
            return str;
        }
        public static Chocos Generate()
        {
            return new Chocos
            {
                Weight = 100 + random.Next() % 150,
                Cells = 12 + random.Next() % 18,
                type = (ChocosType)random.Next(2)
            };
        }
    }
    public enum BakerysType {bun, scone, muffin, biscuit}
    public class Bakerys : Sweets
    {
        public int Calories = 0; // энергетическая ценность
        public BakerysType type = BakerysType.biscuit; // тип выпечки
        public override String GetInfo()
        {
            var str = "Я выпечка";
            str += base.GetInfo();
            str += String.Format("\nЭнергетическая ценность: {0}ккал", this.Calories);
            str += String.Format("\nТип выпечки: {0}", this.type);
            return str;
        }
        public static Bakerys Generate()
        {
            return new Bakerys
            {
                Weight = 50 + random.Next() % 150,
                Calories = 300 + random.Next() % 200,
                type = (BakerysType)random.Next(4)
            };
        }
    }
    public enum FruitsType { pome, stone, citrus, tropical }
    public class Fruits : Sweets
    {
        public int Ripeness = 0; // спелость
        public FruitsType type = FruitsType.citrus; // тип фрукта
        public override String GetInfo()
        {
            var str = "Я фрукт";
            str += base.GetInfo();
            str += String.Format("\nСпелость: {0}%", this.Ripeness);
            str += String.Format("\nТип фрукта: {0}", this.type);
            return str;
        }
        public static Fruits Generate()
        {
            return new Fruits
            {
                Weight = 100 + random.Next() % 200,
                Ripeness = random.Next() % 100,
                type = (FruitsType)random.Next(4)
            };
        }
    }
}