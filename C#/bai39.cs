﻿bai39 code sau về danh sách các xâu kí tự
using System;
using System.Collections.Generic;

class bai39
{
    public static void Main()
    {
        // create a list
        List<string> albums = new List<string>() { "Red", "Midnight", "Reputation" };

        // iterate through the albums list  
        for (int i = 0; i < albums.Count; i++)
            Console.WriteLine(albums[i]);
    }
}
//Red
//Midnight
//Reputation