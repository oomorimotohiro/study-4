using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Csharp_Study_001
{
    public partial class Main : Form
    {
        const string tasu = "＋";
        const string hiku = "－";
        const string kake = "×";
        const string waru = "÷";
            
        public Main()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 計算ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calc_Click(object sender, EventArgs e)
        {
             string hidari = left.Text;
             string migi = right.Text;
             string enzan = ope.Text;
             decimal kotae;


            try {
                if ((hidari == "") || (migi == "") || (enzan == ""))
                {
                    ShowErrMsg("未記入の項目が存在します");
                    return;

                }

                switch (enzan)
                {
                    case tasu:
                        kotae = decimal.Parse(hidari) + decimal.Parse(migi);
                        break;

                    case hiku:
                        kotae = decimal.Parse(hidari) - decimal.Parse(migi);
                        break;

                    case kake:
                        kotae = decimal.Parse(hidari) * decimal.Parse(migi);
                        break;

                    case waru:
                        kotae = decimal.Parse(hidari) / decimal.Parse(migi);
                        break;

                    default:
                        throw new System.FormatException();
                }

                ShowInfoMsg(kotae.ToString());

            }
            catch (System.DivideByZeroException)
            {
                ShowErrMsg("0では割れません");
            }
            catch (System.OverflowException)
            {
                ShowErrMsg("値が大きすぎます");
            }
            catch (System.FormatException)
            {
                ShowErrMsg("入力内容が不正です");
            }



            
        }

        /// <summary>
        /// 通知ダイアログ表示
        /// </summary>
        /// <param name="message">メッセージ</param>
        private static void ShowInfoMsg(string message)
        {
            MessageBox.Show(message,
                            "計算結果",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// エラーダイアログ表示
        /// </summary>
        /// <param name="message">メッセージ</param>
        private static void ShowErrMsg(string message)
        {
            MessageBox.Show(message,
                            "計算失敗",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
        }

    }
}
