using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Device.Location;

namespace testapp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            m_GeoCoordinateWatcher = new GeoCoordinateWatcher();
            m_GeoCoordinateWatcher.PositionChanged += M_GeoCoordinateWatcher_PositionChanged;
            m_GeoCoordinateWatcher.Start();
        }

        private void M_GeoCoordinateWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {

            InvokeGeoUpdate(e.Position.Location.Latitude, e.Position.Location.Longitude);
        }

        GeoCoordinateWatcher m_GeoCoordinateWatcher;

        delegate void GeoUpdate(double Latitude,double Longitude);
        public void InvokeGeoUpdate(double Latitude, double Longitude)
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new GeoUpdate(LblUpdate) ,Latitude,Longitude);
            }
            else
            {
                this.LblUpdate(Latitude,Longitude);
            }
        }

        public void LblUpdate( double Latitude,double Longitude)
        {
            Lbl_Latitude.Text = Latitude.ToString();
            Lbl_Longitude.Text = Longitude.ToString();
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            String[] str_in = Tbx_In.Lines;
            
            int[] numArray = new int[str_in.Length];

            for(int n = 0; n < numArray.Length; n++)
            {
                try
                {

                    numArray[n] = Convert.ToInt32(str_in[n]);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK);
                    break;
                }
            }
            

            int[] rtnArray = sort(numArray);
            Tbx_out.Clear();

            foreach(int rtn in rtnArray)
            {
                Tbx_out.Text += rtn.ToString() + "\r\n";
            }
        }

        int[] sort(int[] inArray)
        {

            for(int start = 1; start < inArray.Length; start++)
            {
                for(int end = inArray.Length-1; end >= start; end--)
                {
                    if (inArray[end - 1] > inArray[end]){
                        int temp;
                        temp = inArray[end - 1];
                        inArray[end - 1] = inArray[end];
                        inArray[end] = temp;
                    }
                }
            }

            return inArray;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog m_FolderBrowserDialog = new FolderBrowserDialog();

            
            m_FolderBrowserDialog.Description = "フォルダを指定";
            
            m_FolderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            
            m_FolderBrowserDialog.SelectedPath = @"C:\Windows";
            
            m_FolderBrowserDialog.ShowNewFolderButton = true;

            
            if (m_FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(
               m_FolderBrowserDialog.SelectedPath+"\\1.txt",
                true,
                System.Text.Encoding.GetEncoding("shift_jis"));
                sw.Write("緯度：" + Lbl_Latitude.Text + "経度：" + Lbl_Longitude.Text);
                sw.Close();
            }
            
        }
    }
}
