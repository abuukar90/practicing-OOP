using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace practice_course
{
    public class soccer
    {
        public int Length { get; set; }
        public int height;
        public int width;
        public int volume;

        public soccer()
        {
            Length = 45;
            this.height = 6;
            this.width = 8;


        }


        public void DisplayInfo()
        {
            Console.WriteLine(" length is {0} and hight is {1} and the width is {2} so the volume is {3}  " 
                ,Length , height , width, volume = Length*height*width);
        }


       

    }
}
