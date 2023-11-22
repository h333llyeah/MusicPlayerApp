using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
        //Create Global Variables of String Type Array to save the titles or names of the Tracks and path of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in filles array
                paths = ofd.FileNames; //Save the paths of the tracks in path array
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display songs in Listbox
                }

            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music 
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex]; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to Close the App
            this.Close();
        }
    }
}
