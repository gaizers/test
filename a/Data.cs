using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apitodoc
{
    class Data
    {
    }

    public class JSON
    {
        public string name { get; set; }
        public string plural { get; set; }
    }

    public class JS
    {
        public string jsFile = string.Empty;
        public string jsonFile = string.Empty;
        public string name = string.Empty;
        public string plural = string.Empty;
        public List<API> apiList = new List<API>();
        public string jsCode = string.Empty;
        public List<FUNCTION> fnList = new List<FUNCTION>();
        //public List<REMOTE> rmList = new List<REMOTE>();
    }

    public class FUNCTION
    {
        public string fnName = string.Empty;
        public string fnCode = string.Empty;
        public string md5 = string.Empty;
        public List<FUNCTION> refFunction = new List<FUNCTION>();
    }

    public class REMOTE
    {
        public string rmName = string.Empty;
        public string rmCode = string.Empty;
    }

    public class Http
    {
        public string path { get; set; }
        public string verb { get; set; }
    }

    public class RemoteMethod
    {
        public string function { get; set; }
        public Http http { get; set; }
    }

    public class API
    {
        public string api = string.Empty;
        public string function = string.Empty;
        public string method = string.Empty;
    }

    public class Export
    {
        public string api = string.Empty;
        public string method = string.Empty;
        public string function = string.Empty;
        public string js = string.Empty;
        public string json = string.Empty;
        public string tables = string.Empty;    //room.type,room.id
        public string fields = string.Empty;    //room.type,room.id
        public string md5 = string.Empty;
    }
}
