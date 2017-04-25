using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphOfFreinds
{
    /*
     * Класс для общения с API вконтакте. 
     * В нём происходят запросы к API и парсинг выражений.
    */
    class SpeakerVK
    {
        public LoginVk vkBrouser;
        public WebBrowser wb;

        public SpeakerVK()
        {
            string url = "https://oauth.vk.com/authorize?client_id=5840936&display=popup&redirect_uri=http://oauth.vk.com/blank.html&scope=4096&response_type=token&v=5.57";
            vkBrouser = new LoginVk();
            vkBrouser.Show();
            wb = (WebBrowser)vkBrouser.Controls["webBrowser1"];
            wb.Navigate(url);
        }

        public int catchToken()
        {
            try
            {
                //http://api.vkontakte.ru/blank.html#access_token=14efb7b325f4d2dd2c0a331af43d3522954e1ff74b537b1c1d1ca8a6970415e4deac90efe8e2365f45384&expires_in=86400&user_id=139286177
                string re = wb.Url.ToString();
                string p1 = re.Split('#')[1];

                VkSettings.Default.id = wb.Url.ToString().Split('=')[3];
                VkSettings.Default.token = p1.Split('&')[0].Split('=')[1];
                VkSettings.Default.auth = true;
            }
            catch
            {
              
            }
            return 0;
        }

        public List<int> giveListOfFreidsUser(string idPeople)
        {
            List<int> iListFreinds = new List<int>();
            String strJSONListFreinds = GET_http("https://api.vk.com/method/friends.get?user_id=" + idPeople);
            if (strJSONListFreinds.IndexOf("error") < 0)
                iListFreinds = ParserFreindList(strJSONListFreinds);

            return iListFreinds;
        }

        public static string GET_http(string url)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string html = sr.ReadToEnd();
            return html;
        }

        private static List<int> ParserFreindList(String srtJSONFreindList)
        {
            List<String> strListFriends;
            List<int> iListFriends = new List<int>();
            int start;
            start = srtJSONFreindList.IndexOf('[') + 1;
            srtJSONFreindList = srtJSONFreindList.Remove(0, srtJSONFreindList.IndexOf('[') + 1);
            int a = srtJSONFreindList.Length;
            int b = srtJSONFreindList.IndexOf(']');
            srtJSONFreindList = srtJSONFreindList.Remove(srtJSONFreindList.IndexOf(']'), -srtJSONFreindList.IndexOf(']') + srtJSONFreindList.Length); 
            strListFriends = srtJSONFreindList.Split(',').ToList();
            if (strListFriends[0] == "")
                return iListFriends;

                foreach (String str in strListFriends)
                    iListFriends.Add(Convert.ToInt32(str));            

            return iListFriends;
        }

    }
}
