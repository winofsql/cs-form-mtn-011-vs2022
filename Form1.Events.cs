using System.Data.Odbc;

namespace cs_form_mtn_011_vs2022
{
    partial class Form1
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            this.処理区分.SelectedIndex = 0;


            // 必要なクラス
            OdbcConnection myCon = new OdbcConnection();
            OdbcCommand myCommand = new OdbcCommand();

            bool result = MysqlConnect(myCon, myCommand);
            if (result == false)
            {
                return;
            }

            // SQL
            string myQuery =
                $@"SELECT
                        *
                    from 所属マスタ
                    order by 所属コード";


            // 実行用オブジェクトに必要な情報を与える
            myCommand.CommandText = myQuery;    // SQL
            myCommand.Connection = myCon;       // 接続

            // 次でする、データベースの値をもらう為のオブジェクトの変数の定義
            OdbcDataReader myReader;

            // SELECT を実行した結果を取得
            myReader = myCommand.ExecuteReader();


            this.所属.Items.Clear();
            // myReader からデータが読みだされる間ずっとループ
            while (myReader.Read())
            {

                string text = myReader.GetString(1);
                string data = myReader.GetString(0);

                this.所属.Items.Add(new ComboData(text, data));

            }
            // 非選択状態
            所属.SelectedIndex = 0;

            myReader.Close();

            myCon.Close();

        }

        // *****************************************
        // 開始時のフォーカス
        // *****************************************
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.社員コード.Focus();
            this.社員コード.SelectAll();
        }

        // *****************************************
        // ( フォームの KeyPreview : True )
        // *****************************************
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    this.SelectNextControl(this.ActiveControl, false, true, true, true);

                }
                else
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
                e.Handled = true;
            }
        }


        // *****************************************
        // ファンクションキ－
        // ( フォームの KeyPreview : True )
        // *****************************************
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ヘッド部.Enabled)
            {
                if (e.KeyCode == Keys.F4)
                {
                    this.処理区分.Focus();
                    this.処理区分.DroppedDown = true;
                }

                if (e.KeyCode == Keys.F6)
                {

                }
            }

        }
    }
}
