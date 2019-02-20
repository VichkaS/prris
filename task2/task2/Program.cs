using System;
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
                string action = command[ 0 ].ToLower();
                string contactName = command[ 1 ].ToLower();

                switch ( action )
                {
                    case "add":
                        AddContact( contactName );
                        break;
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
                var countMatches = 0;
                for ( var i = 0; i < contactName.Length; i++ )
                {
                    if ( i < contact.Length )
                    {
                        if( contactName[i] == contact[i] )
                        {
                            countMatches++;
                        }
                        else
                        {
                            break;
                        }
                    } else
                    {
                        break;
                    }
                }
                if ( countMatches > 0 && countMatches == contactName.Length )
                {
                    count++;
                }
            }
            return count;
        }
    }
}
