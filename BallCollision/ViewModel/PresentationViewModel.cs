using Data;
using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class PresentationViewModel : ViewModelBase
    {
        public ModelApi model;
        public ObservableCollection<BallModel> balls { get; set; }

        public ICommand SimulateCommand { get; set; }
        public ICommand StopCommand { get; set; }

        public bool state {  get; set; }

        private Task task;

        public bool running { get; set; }    
        public int BallsCount { get; set; } = 10;

        public PresentationViewModel() : this(ModelApi.CreateApi())
        {

        }

        public PresentationViewModel(ModelApi model)
        {
            running = false;
            this.model = model;
            balls = new ObservableCollection<BallModel>();
            SimulateCommand = new RelayCommand(() => StartButton());
        }

        private void StartButton()
        {
                running = true;
                model.addBallsAndStart(BallsCount);
                task = new Task(UpdatePosition);
                task.Start();
        }

        public void UpdatePosition()
        {
            while (true)
            {
                ObservableCollection<BallModel> treadList = new ObservableCollection<BallModel>();

                foreach (BallModel ball in model.balls)
                {
                    treadList.Add(ball);
                }

                balls = treadList;
                RaisePropertyChanged(nameof(balls));
                Thread.Sleep(10);
            }
        }



    }
}
