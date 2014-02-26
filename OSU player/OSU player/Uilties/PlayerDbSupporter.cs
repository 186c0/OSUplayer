using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using OSUplayer.OsuFiles;

namespace OSUplayer.Uilties
{
    static internal class DBSupporter
    {
        /// <summary>
        /// ���ļ���ȡSet(allset)
        /// </summary>
        /// <returns>�Ƿ�������ȡ</returns>
        public static bool LoadList()
        {
            if (!File.Exists("list.db")) return false;
            try
            {
                using (var fs = new FileStream("list.db", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    Core.Allsets = (List<BeatmapSet>)formatter.Deserialize(fs);
                }
                return true;
            }
            catch
            {
                File.Delete("list.db");
                return false;
            }
        }

        /// <summary>
        /// ����ȫ��Set(allset)���ļ�
        /// </summary>
        public static void SaveList()
        {
            using (var fs = new FileStream("list.db", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, Core.Allsets);
            }
        }
    }
}