using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bus
{
    internal class EnKlassFörSig
    {

        public static void bus() 
        {
            string file = "NININI.wav";
            string path = Path.Combine(Environment.CurrentDirectory);
            path = path.Remove(path.Length-9,9);
            path += file;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
            player.Play();
        }
        
        
        public static void DetVarEnGångEnRiddare()
        {   
            Console.WriteLine(@" 
  ,^.
  |||
  |||       _T_
  |||   .-.[:|:].-.
  ===_ /\|  ""'""  |/
   E]_|\/ \--|-|''''|
   O  `'  '=[:]| A  |
          /""""""""|  P |
         /""""""""""`.__.'
        []""/""""""\""[]
        | \     / |
        | |     | |
      <\\\)     (///>");

        }
        public static void OchEnTrollKarl()
        {
            Console.WriteLine(@"
C
 (\.   \      ,/)
  \(   |\     )/
  //\  | \   /\\
 (/ /\_#oo#_/\ \)
  \/\  ####  /\/
       `##'");

        }
            public static void OchDeGjordeMassaBus()
            {
                Console.WriteLine(@"
                                    /\
                                   /  \
                                  |    |
                                --:'''':--
                                  :'_' :
                                  _:"":\___
                   ' '      ____.' :::     '._
                  . *=====<<=)           \    :
                   .  '      '-'-'\_      /'._.'
                                    \====:_ ""
                                   .'     \\
                                  :       :
                                 /   :    \
                                :   .      '.
                ,. _            :  : :      :
             '-'    ).          :__:-:__.;--'
           (        '  )        '-'   '-'
        ( -   .00.   - _
       (    .'  _ )     )
       '-  ()_.\,\,   -");
            Console.ReadLine();
            }

    }
}

