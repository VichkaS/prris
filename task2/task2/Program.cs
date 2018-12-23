﻿using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        private static HashSet<string> _contacts = new HashSet<string>();

        static void Main( string[] args )
        {
            while ( true )
            {
                string[] command = Console.ReadLine().Split();
                string action = command[ 0 ];
                string contactName = command[ 1 ];

                switch ( action )
                {
                    case "Add":
                    case "add":
                        AddContact( contactName );
                        break;
                    case "Find":
                    case "find":
                        Console.WriteLine( $"Find {contactName} -> { Find( contactName) }" );
                        break;
                    default:
                        Console.WriteLine( "Can not action" );
                        break;
                }
            }
        }

        static void AddContact( string contactName )
        {
            _contacts.Add( contactName );
        }

        static int Find ( string contactName )
        {
            var count = 0;
            foreach( var contact  in _contacts)
            {
                if ( contact.IndexOf(contactName) > -1 )
                {
                    count++;
                }
            }
            return count;
        }
    }
}
