using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomException_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Cars newCar = new Cars();

            try
            {
                string carName = cboCarName.Text;
                string fuelType = cboFuelType.Text;
                double litre = double.Parse(txtLitre.Text);
                newCar.Start(carName, fuelType, litre);
                string msg = "";
                msg = msg + "汽車名稱:" + carName + "\n";
                msg = msg + "燃料種類:" + fuelType + "\n";
                msg = msg + "加油公升:" + litre;
                MessageBox.Show(msg, "無發生任何例外");
            }
            catch (CarException ex)
            {
                MessageBox.Show(ex.Message, "自訂例外類別訊息");
            }
            finally
            {
                newCar = null;
                MessageBox.Show("物件資源釋放完畢^_^", "finally區段");
            }
        }
    }

    class CarException : ApplicationException
    {
        private string carName;//車名
        private string fuelType;//燃料種類
        private double litre;//加油公升數
        private string errorCode;//錯誤代碼
        private string errorMsg;//錯誤訊息
        private string showErrorMsg;//錯誤代碼 + 錯誤訊息

        public CarException(string CarName, string FuelType, double Litre)
        {
            carName = CarName;
            fuelType = FuelType;
            litre = Litre;
            ProtectedCarMethod();
        }

        public void ProtectedCarMethod()
        {
            if (carName == "Tucson")
            {
                if (fuelType == "無鉛汽油")
                {
                    errorCode = "錯誤代碼:A001\n";
                    errorMsg = "Tucson不能加無鉛汽油,只能加柴油.\n";
                    showErrorMsg = showErrorMsg + errorCode + errorMsg;
                }
                if (litre > 65)
                {
                    errorCode = "錯誤代碼:A002\n";
                    errorMsg = "錯誤訊息:Tucson油箱只能加65公升.\n";
                    showErrorMsg = showErrorMsg + errorCode + errorMsg;
                }
            }
            else if (carName == "Eclipse")
            {
                if (fuelType == "柴油")
                {
                    errorCode = "錯誤代碼:B001\n";
                    errorMsg = "錯誤訊息:Eclipse不能加柴油,只能加無鉛汽油.\n";
                    showErrorMsg = showErrorMsg + errorCode + errorMsg;
                }
                if (litre > 60)
                {
                    errorCode = "錯誤代碼:B002\n";
                    errorMsg = "錯誤訊息:Eclipse油箱只能加60公升.\n";
                    showErrorMsg = showErrorMsg + errorCode + errorMsg;
                }
            }
        }

        public override string Message
        {
            get
            {
                return showErrorMsg;
            }
        }
    }

    class Cars
    {
        public void Start(string CarName, string FuelType, double Litre)
        {
            if (CarName == "Tucson")
            {
                if (FuelType == "無鉛汽油")
                {
                    throw new CarException(CarName, FuelType, Litre);
                }
                if (Litre > 65)
                {
                    throw new CarException(CarName, FuelType, Litre);
                }
            }
            else if (CarName == "Eclipse")
            {
                if (FuelType == "柴油")
                {
                    throw new CarException(CarName, FuelType, Litre);
                }
                if (Litre > 60)
                {
                    throw new CarException(CarName, FuelType, Litre);
                }
            }
        }
    }


}
