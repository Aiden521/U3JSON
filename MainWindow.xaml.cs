using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U3JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
                // webclient 
                System.Net.WebClient webClient = new System.Net.WebClient();
                webClient.BaseAddress = "https://raw.githubusercontent.com/IanMcT/WebClientReader/master/teams.txt";
                System.IO.StreamReader streamReader = new System.IO.StreamReader(webClient.OpenRead("https://raw.githubusercontent.com/IanMcT/WebClientReader/master/teams.txt"));
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("Text.txt");
            
                try
                {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
          //        MessageBox.Show(line);
          //        streamWriter.WriteLine(line);
                    if (line.Contains("\"key\":"))
                    {
                        MessageBox.Show(line);
                        streamWriter.WriteLine(line);
                    }
                }
                streamWriter.Write(streamReader.ReadToEnd());
                    streamWriter.Flush();
                    streamWriter.Close();
                    streamWriter.Close();
                    MessageBox.Show("I Have read everything!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "Error");
                }
            }
        }
    }

