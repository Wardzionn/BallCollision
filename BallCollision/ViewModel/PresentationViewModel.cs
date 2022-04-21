using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class PresentationViewModel  : ViewModelBase
    {
        public ObservableCollection<BallModel> balls { get; set; }

        public ICommand AddBallCommand;

        public int BallsCount = 10;

        public PresentationViewModel()
        {
            balls = new ObservableCollection<BallModel>();
            AddBallCommand = new RelayCommand(() => RequestBall());
        }

        private void RequestBall()
        {

        }
    }
}
