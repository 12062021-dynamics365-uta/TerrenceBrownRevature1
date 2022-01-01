﻿using System;

namespace WeatherObservationBeginandEndWithoutVowel
{
    class Program
    {
        static void Main(string[] args)
        {
                SELECT DISTINCT CITY
                FROM STATION
                WHERE CITY NOT LIKE '%a'
                AND CITY NOT LIKE '%e'
                AND CITY NOT LIKE '%u'
                AND CITY NOT LIKE '%i'
                AND CITY NOT LIKE '%o'
                AND CITY NOT LIKE 'e%'
                AND CITY NOT LIKE 'u%'
                AND CITY NOT LIKE 'i%'
                AND CITY NOT LIKE 'o%'
                AND CITY NOT LIKE 'a%';
                        }
    }
}