using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //新增此命名空間
namespace PartialMethods_ex
{
    partial class SportCar
    {
        partial void getCarName()
        {
            MessageBox.Show("Mitsubishi Eclipse", "汽車資訊");
        }
    }
}
