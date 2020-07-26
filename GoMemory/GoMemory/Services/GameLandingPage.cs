//using GoMemory.Enums;
//using GoMemory.Helpers;
//using GoMemory.Models;
//using System;
//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;


//namespace GoMemory.Pages
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class GameLandingPage : ContentPage
//    {
//        public GameType GameType { get; set; }
//        public ResumeModel ResumeModel { get; set; }

//        public GameLandingPage(string buttonText)
//        {
//            InitializeComponent();
//            Title = buttonText;
//            SetGameType(buttonText);

//        }

//        private void SetGameType(string buttonText)
//        {

//            switch (buttonText)
//            {
//                case "What you see":
//                    GameType = GameType.Guess;
//                    break;
//                case "Sequential":
//                    GameType = GameType.Sequential;
//                    break;
//                default:
//                    GameType = GameType.ColourComplex;
//                    break;
//            }
//        }


//        protected override void OnAppearing()
//        {
//            base.OnAppearing();
//            CheckResume();
//        }

//        /// <summary>
//        /// check to see if there is a saved game
//        /// </summary>
//        public void CheckResume()
//        {
//            ResumeModel = ResumeHelper.CheckResume(GameType);
//            if (ResumeModel != null)
//            {
//                ResumeBtn.IsEnabled = true;

//            }
//        }

//        public void ResumeBtn_OnClicked(object sender, EventArgs e)
//        {
//            SetGamePlay(ResumeModel.Difficulty, ResumeModel);
//        }

    
//        public async void StatusBtn_OnClicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new StatusPage(GameType));       
//        }





//        /// <summary>
//    


//       
//    }
//}