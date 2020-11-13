using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sound_image//project name 
{
    class logicalclass
    {
        public int reload;//declare the datatype
        public int spin;//declare the datatype
        public int shoot;//declare the datatype
        public int luck = 1;//declare the datatype and assigning the value 

        public void reload_chamber()//function  for reload the camber
        {
            reload = 1;
        }

        public int spin_chamber()
        {
            Random rnd_obj = new Random();//to put the bullet on randomly at any place
            spin = rnd_obj.Next(1, 7);//setting the value 1-7 coz only 6 bullets can insert in CAMBER
            return spin;
        }

        public int shoot_bullet()//function
        {
            if (reload == spin)//check if reload & spin is equal
            {
                return 0;
            }
            else if (spin == 6)//when spin is  equal to 6 then it will return 1
            {
                spin = 1;
                return 1;
            }
            else
            {
                spin++;//increment the spin value by 1
                return 1;//it will return value one  
            }

        }

    }
}
