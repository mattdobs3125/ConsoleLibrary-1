﻿using ConsoleLibrary.Services;
using DataLibrary;
using DataLibrary.Models;
using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService ls = new LibraryService();
            while(ls.Running)
            {
                ls.LibrarySelection();
            }

            


        }
    }
}
