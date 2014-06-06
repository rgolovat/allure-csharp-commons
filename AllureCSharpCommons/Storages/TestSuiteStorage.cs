﻿using System.Collections.Generic;
using AllureCSharpCommons.AllureModel;

namespace AllureCSharpCommons.Storages
{
    public class TestSuiteStorage
    {
        private readonly Dictionary<string, testsuiteresult> _map =
            new Dictionary<string, testsuiteresult>();

        internal Dictionary<string, testsuiteresult> Map
        {
            get { return _map; }
        }

        public testsuiteresult Get(string suiteUid)
        {
            return _map[suiteUid];
        }

        public bool Put(string uid)
        {
            if (!_map.ContainsKey(uid))
            {
                _map.Add(uid, new testsuiteresult());
            }
            return false;
        }

        public void Remove(string suiteUid)
        {
            _map.Remove(suiteUid);
        }
    }
}