﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Card
    {
        private string suit;
        private string face;
        private string image;

        public Card(string suit, string face)
        {
            this.suit = suit;
            this.face = face;

            setImage();

        }

        public string getSuit(){

            return suit;

        }

        public string getface(){

            return face;

        }

        public string getImage(){

            return image;

        }

        private void setImage()
        {
            image = face + "_of_" + suit; 
        }

            
     }
}
