using Data;
using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class PresentationViewModel  : ViewModelBase
    {
        public CollisionModel model;

        public ObservableCollection<BallModel> balls { get; set; }

       public ICommand AddBallsCommand { get; set; }

        public int BallsCount { get; set; } = 10;


        public PresentationViewModel()
        {
            balls = new ObservableCollection<BallModel>();
            this.model = new CollisionModel();
            AddBallsCommand = new RelayCommand(() => AddBalls());
        }

        public void AddBalls()
        {
            for(int i = 0; i < balls.Count; i++)
            {
                balls.Add(AddBall());
            }
            RaisePropertyChanged(nameof(balls));
        }

        public BallModel AddBall()
        {
            Random rng = new Random();
            double x = rng.NextDouble() + 100;
            double y = rng.NextDouble() + 100;
            Ball kulka = new Ball(20, new Vector2((float)x, (float) y), new Vector2((float)x, (float)y));
            BallModel bm = new BallModel(kulka);
            return bm;
        }

 
    }
}
