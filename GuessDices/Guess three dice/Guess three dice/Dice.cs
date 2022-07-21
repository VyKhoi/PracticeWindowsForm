using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_three_dice
{
    class Dice
    {
        Bitmap image;
        int val;
        private string pathThis;
        //ptkt
        public  Dice()
        {

        } 
        public Dice(string path,int val)
        {
            image = new Bitmap(path);
            this.val = val;
            pathThis = path;
        }

       public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }
       public int Value
        {
            get { return val; }
            set {  val = value; }
        }
        public string GetPathImage()
        {
            return pathThis;
           // DirectoryInfo pa = new DirectoryInfo();
           // return image.
        }
    }
}
