using System;

namespace RPGdotnetPOO.SRC.Entities
{
    public class Knight : Hero
    {
          public Knight (String Name,  int Level, string HeroType){                
           this.Name = Name;
           this.level = Level;
           this.HeroType = HeroType; 
          }
    }
}