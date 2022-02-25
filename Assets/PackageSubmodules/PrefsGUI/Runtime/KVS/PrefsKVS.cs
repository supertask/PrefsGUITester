﻿using PrefsGUI.KVS.Json;

namespace PrefsGUI.KVS
{
    public interface IKVS
    {
        void Save();
        void Load();
        void DeleteAll();

        bool HasKey(string key);
        void DeleteKey(string key);
        T Get<T>(string key, T defaultValue);
        void Set<T>(string key, T v);
    }


    public static class PrefsKVS
    {
        public static IKVS implement = new PrefsKVSJson();

        public static void Save() => implement.Save();
        public static void Load() => implement.Load();
        public static void DeleteAll() => implement.DeleteAll();

        public static bool HasKey(string key) => implement.HasKey(key);
        public static void DeleteKey(string key) => implement.DeleteKey(key);
        public static T Get<T>(string key, T defaultValue) => implement.Get(key, defaultValue);
        public static void Set<T>(string key, T v) => implement.Set(key, v);
    }
}

