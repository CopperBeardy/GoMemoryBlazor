

using GoMemory.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;


using GoMemory.Shared.Models;
using System.Collections.Generic;
using GoMemory.Shared.Interfaces;

namespace GoMemory.GamePlay
{
    public class WhatYouSeeGamePlay
    {
        //readonly WhatYouSeeGamePlayViewModel _whatYouSeeGamePlayViewModel;

        //correct guesses made by player

        public List<ImageTile> CorrectImageTileGuesses { get; set; }
        //current image tile being used in the game
        public List<ImageTile> CurrentImageTiles { get; set; }

        //ImageTiles that need to be matched
        public List<ImageTile> CurrentPlayTile { get; set; }

        //difficulty of game
        public GameSettings _gameSettings { get; set; }

        public UnorderedGame _game { get; set; }



        readonly IImageHelper imageHelper;

        public WhatYouSeeGamePlay(GameSettings gameSetting, IImageHelper imageHelper)
        {
            this.imageHelper = imageHelper;
            _gameSettings = gameSetting;
            _game = new UnorderedGame(); 
            GetGameTiles();

        }

        public void CreateGuessTiles()
        {
            CorrectImageTileGuesses = CurrentImageTiles.Take(_game.MatchesNeeded).ToList();
        }

        private void GetGameTiles()
        {
            CurrentImageTiles = imageHelper.GetImages(_gameSettings.GridColumnSize * _gameSettings.GridRowSize);

        }


        /// <summary>
        /// Determines if max level for difficulty is reached if not
        /// next round is initialized
        /// </summary>
        public bool NextRound()
        {

            _game.Level++;
            if (_game.Level <= _gameSettings.MaxLevel)
            {
                InitializeRound();
                return true;
            }

            return false;
        }

        private void InitializeRound()
        {
            throw new NotImplementedException();
        }

        //        //TODO REPLACE WITH CSS GRID
        //        //public Grid Grid;
        //        public static Timer EndLevelTimer;


        //        public WhatYouSeeGamePlayPage()//Difficulty difficulty, GameType gameType,)
        //        {

        //            //Title = "What you see";
        //            //GameStatus = new GameStatus
        //            //{
        //            //    Difficulty = difficulty,
        //            //    GameType = gameType
        //            //};

        //            _whatYouSeeGamePlayViewModel = new WhatYouSeeGamePlayViewModel(difficulty, resumeModel);
        //            CreatePageContent();

        //        }


        //        /// <summary>
        //        /// Create the initial layout of the page
        //        /// </summary>
        //        private void CreatePageContent()
        //        {

        //           // Failed.IsVisible = false;
        //          //  LevelLabel.Text = _whatYouSeeGamePlayViewModel.SetLevelText();


        //            //TODO CONFIG GRIDS
        //            //FlexFrame.MinimumHeightRequest = Application.Current.MainPage.Height * 0.6;


        //            AddImagesToselectFlexLayout();

        //            //Grid = _whatYouSeeGamePlayViewModel.CreateNewGrid(Grid);
        //           // Grid.MinimumWidthRequest = Application.Current.MainPage.Width * 0.5;
        //           // Grid.MinimumHeightRequest = Application.Current.MainPage.Height * 0.6;
        //          //  Grid.IsVisible = false;


        //            //StackLayout.Children.Add(Grid);


        //        }

        //        /// <summary>
        //        /// add Images to remember to a flex layout
        //        /// </summary>
        //        private void AddImagesToselectFlexLayout()
        //        {
        //            //TODO ADD TO css GRID
        //           // FlexLayout = _whatYouSeeGamePlayViewModel.CreateSequenceFlexLayout(FlexLayout);
        //        }



        //        /// <summary>
        //        /// Handles the tapping of a image once guessing phase has started
        //        /// </summary>
        //        /// <param name="sender"></param>
        //        /// <param name="ev"></param>
        //        private void GuessImageClicked()
        //        {

        //            bool found;
        //            try
        //            {
        //                //Grid.IsEnabled = false;
        //                //TODO get image clicked
        //                //Image img = sender as Image;



        //                //TOdo 2.Check if image in the playlist answer list
        //                // if it is add to correct guess and track number of correct guess

        //                found = CorrectGuesses.Where(x => x.)(img);
        //                if (found)
        //                {
        //                    if (img != null)
        //                    {
        //                        img.Opacity = 0.5;
        //                        img.IsEnabled = false;
        //                    }

        //                }
        //                else
        //                {
        //                    StackLayout.IsVisible = false;
        //                    Failed.IsVisible = true;

        //                }

        //                if (_whatYouSeeGamePlayViewModel.CheckIsRoundComplete())
        //                {
        //                    GameStatus.Level = _whatYouSeeGamePlayViewModel.GameModel.Level;
        //                    UpdateStatusHelper.UpdateStatus(GameStatus);

        //                    NextRound();

        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                //todo look at what might fail and how to handle
        //                Console.WriteLine(e);
        //                throw;
        //            }
        //            finally
        //            {
        //                Grid.IsEnabled = true;
        //                IsBusy = false;
        //            }

        //        }

        //        private void StartButton_OnClicked(object sender, EventArgs eventArgs)
        //        {
        //            ToggleVisibilities();

        //        }


        //        /// <summary>
        //        /// Initiates next Level of play or signals game completed 
        //        /// 
        //        /// </summary>
        //        public void NextRound()
        //        {
        //            bool next;
        //            next = _whatYouSeeGamePlayViewModel.NextRound();
        //            if (next)
        //            {
        //                LevelLabel.Text = _whatYouSeeGamePlayViewModel.SetLevelText();
        //                AddImagesToselectFlexLayout();
        //                foreach (var image in Grid.Children)
        //                {
        //                    image.Opacity = 1;
        //                    image.IsEnabled = true;
        //                }

        //                ToggleVisibilities();
        //            }
        //            else
        //            {

        //                StackLayout.IsVisible = false;
        //                Failed.IsVisible = false;
        //                Complete.IsVisible = true;
        //            }

        //        }

        //        private void ToggleVisibilities()
        //        {
        //            StartButton.IsVisible = !StartButton.IsVisible;
        //            FlexFrame.IsVisible = !FlexFrame.IsVisible;
        //            Grid.IsVisible = !Grid.IsVisible;
        //            memolabel.IsVisible = !memolabel.IsVisible;
        //        }

        //        private void RetryButton_Clicked(object sender, EventArgs eventArgs)
        //        {
        //            _whatYouSeeGamePlayViewModel.Retry();
        //            NextRound();

        //            //TODO refactor 
        //            StackLayout.IsVisible = true;
        //            Failed.IsVisible = false;
        //        }
    }
}