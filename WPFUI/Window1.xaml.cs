using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Engine.ViewModels;

namespace WPFUI
{
    public partial class Window1 : Window
    {
        //scope, datatype, name of variable
        private GameSession _gameSession;

        public Window1()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            DataContext = _gameSession;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.ExperiencePoints += 10;
        }
    }
}