using Microsoft.Win32;
using PhotographUtility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PhotoGraphArchives.ShowExif
{
    public class EXIFView
    {
        ListBox _lb_Files;
        ListView _lv_Exif;
        Button _btn_Add;
        ObservableCollection<string> _filenames = new ObservableCollection<string>();
        public EXIFView(ListBox lb_Files, ListView lv_Exif, Button btn_Add)
        {
            _lb_Files = lb_Files;
            _lv_Exif = lv_Exif;
            _btn_Add = btn_Add;
            _lb_Files.ItemsSource = _filenames;
            btn_Add.Click += OnAddFile;
            _lb_Files.SelectionChanged += OnSelectFile;
        }

        private void OnAddFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "打开",
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "照片|*.jpg",
                Multiselect = true,
            };
            if (ofd.ShowDialog()??false)
            {
                foreach (var filename in ofd.FileNames)
                {
                    _filenames.Add(filename);
                }
            }
        }

        private void OnSelectFile(object sender, SelectionChangedEventArgs e)
        {
            string filename = e.AddedItems[0] as string;
            if (!string.IsNullOrEmpty(filename))
            {
                _lv_Exif.ItemsSource = new ObservableCollection<ImageProperty>(ImagePropertyUtility.GetImageProperties(filename));
            }
        }

    }
}
