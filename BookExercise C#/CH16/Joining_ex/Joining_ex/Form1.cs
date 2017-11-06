using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joining_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<Login> logins = new List<Login>
            {
                new Login {UserID="Ryu",Pwd ="12345",IsVaild =true},
                new Login {UserID="Maggie",Pwd ="54321",IsVaild =true}
            };

            List<UserInfo> userInfos = new List<UserInfo>
            {
                new UserInfo {UserID="Ryu",Name ="許清榮",Sex ="男"},
                new UserInfo {UserID="Maggie",Name ="謝馬姬",Sex ="女"}
            };

            var userQuery = from login in logins
                            join userInfo in userInfos
                            on login.UserID equals userInfo.UserID
                            select new
                            {
                                USERID = login.UserID,
                                PWD = login.Pwd,
                                NAME = userInfo.Name,
                                SEX = userInfo.Sex
                            };

            string result = "將Login資料表和UserInfo資料表聯結後結果:\n";
            foreach (var user in userQuery)
            {
                result = result + "使用者編號:" + user.USERID + "\n";
                result = result + "密碼:" + user.PWD + "\n";
                result = result + "姓名:" + user.NAME + "\n";
                result = result + "性別:" + user.SEX + "\n";
            }
            MessageBox.Show(result, "聯結運算子");
        }
    }
    public class Login
    {
        public string UserID { get; set; }
        public string Pwd { get; set; }
        public bool IsVaild { get; set; }
    }

    public class UserInfo
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}
