﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meta.Vlc.Wpf;
using System.IO;
using System.Windows.Media;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System.Windows;
using System.Windows.Threading;

namespace Tsunami.Gui.Wpf
{
    public delegate void ChangedEventHandler();

    public partial class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event ChangedEventHandler VolumeChanged;
        public event ChangedEventHandler MovieProgressChanged;

        private string _progressTime { get; set; }
        public string ProgressTime
        {
            get
            {
                return _progressTime;
            }
            set
            {
                if(_progressTime != value)
                {
                    _progressTime = value;
                    CallPropertyChanged("ProgressTime");
                }
            }
        }

        private bool _playerStatusVisibility { get; set; }
        public bool PlayerStatusVisibility
        {
            get
            {
                return _playerStatusVisibility;
            }
            set
            {
                if(_playerStatusVisibility != value)
                {
                    _playerStatusVisibility = value;
                    CallPropertyChanged("PlayerStatusVisibility");
                }
            }
        }

        private bool _fullscreenEnabled { get; set; }
        public bool FullScreenEnabled
        {
            get
            {
                return _fullscreenEnabled;
            }
            set
            {
                if (_fullscreenEnabled != value)
                {
                    _fullscreenEnabled = value;
                    CallPropertyChanged("FullScreenEnabled");
                }
            }
        }

        private int _volume { get; set; } 
        public int VolumeValue
        {
            get
            {
                return _volume;
            }
            set
            {
                if (_volume != value)
                {
                    _volume = value;
                    CallPropertyChanged("VolumeValue");
                    VolumeChanged?.Invoke();
                }
            }
        }

        private double _movieProgress { get; set; }
        public double MovieProgress
        {
            get
            {
                return _movieProgress;
            }
            set
            {
                if (_movieProgress != value)
                {
                    _movieProgress = value;
                    CallPropertyChanged("MovieProgress");
                    MovieProgressChanged?.Invoke();
                }
            }
        }

        private double _maxMovieTime { get; set; }
        public double MaxMovieTime
        {
            get
            {
                return _maxMovieTime;
            }
            set
            {
                if (_maxMovieTime != value)
                {
                    _maxMovieTime = value;
                    CallPropertyChanged("MaxMovieTime");
                }
            }
        }


        public Player()
        {
            _progressTime = "00:00:00";
            FullScreenEnabled = true;
            _volume = 50;
            _maxMovieTime = 100;
        }

        private void CallPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}