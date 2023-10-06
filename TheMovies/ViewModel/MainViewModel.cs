﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Command;

namespace TheMovies.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private MovieViewModel _movieVM = new();

        public ICommand AddMovieCommand { get;}

        public MainViewModel()
        {
            AddMovieCommand = new AddMovieCommand();

        }
    }
}
