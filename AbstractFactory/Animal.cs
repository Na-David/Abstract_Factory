﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface Animal
    {
        string speak();
    }

    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }

    public class Lion : Animal
    {
        public string speak()
        {
            return "Roar";
        }
    }

    public class Dog : Animal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }

    public class Octopus : Animal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }
    public class Shark : Animal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }
}
