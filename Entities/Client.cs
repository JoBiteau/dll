using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteque
{
    class Client : Personne
    {
        public int Num_client { get; set; }
        public string Societe { get; set; }
        public string toString()
        {
            return $"{Prenom} {Nom} - Client : {Num_client} - {Societe}";
        }
    }
}
