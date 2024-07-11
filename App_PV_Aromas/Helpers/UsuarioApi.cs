﻿namespace App_PV_Aromas.Helpers
{
    public class UsuarioApi
    {
        public string firstname2 { get; set; }
        public string rawcedula { get; set; }
        public string cedula { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string type { get; set; }
        public string fullname { get; set; }
        public string lastname2 { get; set; }
        public string lastname1 { get; set; }
        public string firstname1 { get; set; }
        public string guess_type { get; set; }
        public string @class { get; set; }
        public object temp { get; set; }
        public string admin { get; set; }
    }

    public class UsuarioResult
    {
        public string license { get; set; }
        public int resultcount { get; set; }
        public string database_date { get; set; }
        public List<UsuarioApi> results { get; set; }
        public string query { get; set; }
    }
}
