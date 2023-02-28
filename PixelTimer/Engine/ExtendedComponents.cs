using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public enum SchedulableType 
    {
        LightBulb = 0,
        DayLightBussines = 1,
        NightBussines = 2
    }

    public interface ISchedulableObject
    {
        public bool IsOn { get; set; }

        public void SwitchTo(bool switchTo);
        public bool GetStatus();
        public SchedulableType GetSchedulableType();
        public string GetName();
        public int[] GetTimes();
    }

    public class SchedulableObject : ISchedulableObject
    {

        internal string name;
        internal SchedulableType currentType;
        internal bool isOn;
        internal int startHour, closeHour;


        public bool IsOn { get { return isOn; } set { this.isOn = value; } }

        public int GetOpen() 
        {
            return startHour;
        }
        public int GetClose() 
        {
            return closeHour;
        }

        public bool GetStatus()
        {
            return isOn;
        }

        public void SwitchTo(bool switchTo)
        {
            this.isOn = switchTo;
        }

        public SchedulableType GetSchedulableType()
        {
            return currentType;
        }

        public string GetName()
        {
            return this.name;
        }

        public int[] GetTimes() 
        {
            return new int[] { startHour, closeHour };
        }

    }

    public class LightBulb:SchedulableObject
    {
        public LightBulb() 
        {
            this.name = "LightBulb";
            this.currentType = SchedulableType.LightBulb;
            this.startHour = 21;
            this.closeHour = 6;
        }
    }

    public class BussinesClass1:SchedulableObject
    {
        public BussinesClass1():this("NoNamedClass1",8,19)
        {
        }

        public BussinesClass1(string name, int openHour, int closeHour) 
        {

            this.name = name;
            this.currentType = SchedulableType.DayLightBussines;
            this.startHour = openHour;
            this.closeHour = closeHour;
        }
    }

    public class BussinesClass2:SchedulableObject
    {
        public BussinesClass2():this("NoNamedClass2",19,8)
        {
        }

        public BussinesClass2(string name, int openHour, int closeHour) 
        {

            this.name = name;
            this.currentType = SchedulableType.NightBussines;
            this.startHour = openHour;
            this.closeHour = closeHour;
        }
    }

}
