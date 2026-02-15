using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace WinFormsApp1.src
{
    internal static class Functional
    {
        private static Dictionary<int, string[]> Base = new Dictionary<int, string[]>();
        private static string serialized = "";
        private static string path = "users.json";
        public static string name = "";
        public static string level = "0";
        public static void AddUser(string[] UserInfo)
        {
            for (int i = 0; true ; i++)
            {
                if (!Base.ContainsKey(i))
                {
                    Base.Add(i, UserInfo);
                    ExportToJson();
                    break;
                }
            }
        }
        public static void RemoveUser(int id)
        {
            if (Base.ContainsKey(id))
            {
                Base.Remove(id);
            }
            ExportToJson();
        }
        public static string[] GetInfo(int id)
        {
            return Base[id];
        }
        public static string GetUsers()
        {
            string res = string.Empty;
            for (int i = 0; i < Base.Count ; i++)
            {
                res += $"{i}, ";
                foreach(string item in Base[i])
                {
                    res += $"{item}, ";
                }
                res += "\n";
            }
            return res;
        }

        public static void ImportJson()
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);

                    var tempDict = JsonSerializer.Deserialize<Dictionary<string, string[]>>(json);
                    if (tempDict != null)
                    {
                        Base.Clear();
                        foreach (var kvp in tempDict)
                        {
                            int id = int.Parse(kvp.Key);
                            Base.Add(id, kvp.Value);
                        }
                    }
                }
                else
                {
                    Base = new Dictionary<int, string[]>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                Base = new Dictionary<int, string[]>();
            }
        }

        public static void ExportToJson()
        {
            serialized = JsonSerializer.Serialize(Base);
            File.WriteAllText(path, serialized);
        }
        public static bool isUserExists(string[] userInfo)
        {
            for(int i = 0;i < Base.Count;i++)
            {
                if (userInfo[0].Equals(Base[i][0]))
                {
                    return true;
                }
            }
            return false;
        }
        public static int BaseLength()
        {
            return Base.Count;
        }
        public static bool IsUserExistsByLogin(string login)
        {
            for (int i = 0; i < Base.Count;i++)
            {
                if(login.Equals(Base[i][0]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
