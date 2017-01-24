using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGame
{
    abstract class Obstacles
    {
        private int x;
        private int y;
        private int wastfilly;
        Boolean collide;

        //overloaded constructor method
        //If NotMoving
        public Obstacles(int x, int y, int speed, Boolean collision)
        {
            this.x = x;
            this.y = y;
            wastfilly = speed;
            collide = collision;
        }
        //if traffic(Moving)
        //public Obstacles(int x,int y, int speed, /* ¿Color?*/, Boolean collision)
        //    {
        //  this.x = x;
        // this.y = y;
        //wastfilly = speed;
        /*traffic Color code*/
        // collide = collision;
        //} 
        //Sets
        public void setX(int X)
            {
                 x = X;
            }
         public void setY(int Y)
            {
              y = Y;
            }
        
        public void setWastFilly(int WastFilly)
            {
                wastfilly = WastFilly;
           
            }
        public void setCollide(Boolean collision)
            {
                collide = collision;
            }
        //Gets
        public int getX()
            {
                 return x;
            }

        public int getY()
            {
                return y;
            }
        private int getWastFilly()
            {
                return wastfilly;
            }
        public Boolean getCollide()
            {
                return collide;
            }

       

       // new object car1(int xCoord, int yCoord, Boolean collison, int speed);


        
    }



    /* What we need to do:
    make an ArrayList of Obejcts that we can add/subtract from. Each object will need to have the following properties:
                -Spawning position
                -speed (tree vs. oncoming traffic)
                -collision (boolean)

    Make a Traffic Class
        -adds color


    */
}
